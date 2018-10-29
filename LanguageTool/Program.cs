using LanguageTool.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguateTool
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Count() < 2)
            {
                Console.WriteLine("Please specify 2 arguments: operation filename");
                return;
            }

            var operation = args[0];
            var filename = args[1];

            ICU.DoOperation(operation, filename);
        }
    }
}
