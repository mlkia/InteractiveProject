using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveProject.Helper
{
    public static class ConsoleHelper
    {
        public static bool IsTestMode { get; set; }
        public static void Write(string text)
        {
            if(!IsTestMode)
                Console.WriteLine(text);
        }

        public static string? Read()
        {   if (!IsTestMode)
                return Console.ReadLine();
            return null;
        }

        public static char? ReadKey()
        {   if (!IsTestMode)
                return Console.ReadKey().KeyChar;
            return null;
        }

        public static void Clear()
        {
            if(!IsTestMode)
                Console.Clear();
        }
    }
}
