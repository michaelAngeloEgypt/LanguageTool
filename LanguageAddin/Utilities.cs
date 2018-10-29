using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageAddin
{
    public static class Utilities
    {
        public static string RootFolder = @"C:\LanguageTool";
      
        public static bool ScanFile(string inputFile, string outputFile)
        {
            XLogger.Info($"input file path: {Path.GetFullPath(inputFile)}");
            XLogger.Info($"output file path: {Path.GetFullPath(outputFile)}");

            #region health checks
            if (!File.Exists(inputFile))
                throw new ArgumentException("File not found: " + inputFile, "inputFile");
            #endregion health checks



            string fullCommand = "", commandOutput = "";

            StringBuilder sb = new StringBuilder(Environment.NewLine);
            var exePath = Path.Combine(RootFolder,"Bin", "ICUconsole.exe");

            try
            {
                string tempBatch = Path.Combine(RootFolder, "scanFile.bat");
                tempBatch.DeleteFile();

                fullCommand
                    = string.Format(
@"{0} ""{1}"" ""{2}""
@echo off
echo %ERRORLEVEL% ", exePath, inputFile, outputFile);

                File.WriteAllText(tempBatch, fullCommand);
                string arguments = "";


                bool res = ExecuteCommand(tempBatch, Environment.CurrentDirectory, arguments, out commandOutput);
                sb.AppendLine("commandOutput: " + commandOutput);
                var outputLines = commandOutput.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var lastLine = outputLines.Last();
                XLogger.Info(sb.ToString());

                //res &= !String.IsNullOrWhiteSpace(fileCommandOutput);
                return (lastLine.Trim() == "0");
            }
            catch (Exception x)
            {
                x.Data.Add("fullCommand", fullCommand);
                x.Data.Add("fileCommandOutput", commandOutput);

                XLogger.Error(x);
                return false;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="command"></param>
        /// <param name="commandOutput"></param>
        /// <param name="commandParams"></param>
        /// <returns></returns>
        public static bool ExecuteCommand(string command, string workingDir, string commandArguments, out string commandOutput) //, params string[] commandParams
        {

            commandOutput = "";

            try
            {
                int exitCode;
                ProcessStartInfo processInfo;
                Process process;

                processInfo = new ProcessStartInfo("cmd", String.Concat("/c ", command));

                /*
                //another way
                processInfo = new ProcessStartInfo();
                processInfo.FileName = command;
                //processInfo.WorkingDirectory = Path.GetDirectoryName(command);
                */

                //StringBuilder finalArgs = new StringBuilder();
                //if (commandParams != null && commandParams.Length > 0)
                //    processInfo.Arguments = String.Join(" ", commandParams);
                //processInfo.Arguments = commandArguments;
                processInfo.WorkingDirectory = workingDir;
                //processInfo.CreateNoWindow = true;        //using this will break the GPG command!!
                processInfo.UseShellExecute = false;
                //processInfo.WindowStyle = ProcessWindowStyle.Hidden;


                // *** Redirect the output ***
                processInfo.RedirectStandardError = true;
                processInfo.RedirectStandardOutput = true;

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("before StartInfo!!");
                sb.AppendLine("processInfo.WorkingDirectory " + processInfo.WorkingDirectory);
                sb.AppendLine("processInfo.FileName " + processInfo.FileName);
                sb.AppendLine("processInfo.Arguments " + processInfo.Arguments);
                //XLogger.Info(sb.ToString());
                process = Process.Start(processInfo);
                process.WaitForExit();

                // *** Read the streams ***
                //string output = process.StandardOutput.ReadToEnd();
                //string error = process.StandardError.ReadToEnd();

                exitCode = process.ExitCode;

                /*
                Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
                Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
                Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");
                */

                commandOutput = String.Concat(process.StandardOutput.ReadToEnd(), Environment.NewLine, process.StandardError.ReadToEnd());
                process.Close();

                //not always valid
                //if (!String.IsNullOrWhiteSpace(error))
                //    throw new ApplicationException("Commnad returned an error:  " + error);

                return true;
            }
            catch (Exception x)
            {
                x.Data.Add("command", command);
                XLogger.Error(x);

                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static bool DeleteFile(this string filename)
        {
            try
            {
                if (!File.Exists(filename))
                    return true;

                if (filename.IsFileLocked())
                    return false;

                File.Delete(filename);
                string strCmdText;
                //strCmdText = String.Concat("DEL ", newReport);
                strCmdText = String.Format("/c sdelete -p 1 -s -z -q -a '{0}'", filename);
                Process p = new Process();
                ProcessStartInfo psi = new ProcessStartInfo("CMD.exe", strCmdText);
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                p.StartInfo = psi;
                p.Start();
                string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// check if a file is locked
        /// </summary>
        /// <see cref="http://stackoverflow.com/questions/876473/is-there-a-way-to-check-if-a-file-is-in-use"/>
        /// <returns></returns>
        public static bool IsFileLocked(this string filename)
        {
            if (!File.Exists(filename))
                return false;

            FileInfo file = new FileInfo(filename);
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }


        /// <summary>
        /// CASE-SENSITIVE: Get string value before [first] a.
        /// </summary>
        public static string Before(this string value, string a)
        {
            if (String.IsNullOrWhiteSpace(value))
                return "";

            int posA = value.IndexOf(a);
            if (posA == -1)
            {
                return "";
            }
            return value.Substring(0, posA);
        }
        /// <summary>
        /// CASE-SENSITIVE: Get string value after [last] a.
        /// </summary>
        public static string After(this string value, string a)
        {
            if (string.IsNullOrWhiteSpace(value))
                return "";

            int posA = value.LastIndexOf(a, StringComparison.InvariantCultureIgnoreCase);
            if (posA == -1)
            {
                return "";
            }
            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= value.Length)
            {
                return "";
            }
            return value.Substring(adjustedPosA);
        }

    }
}
