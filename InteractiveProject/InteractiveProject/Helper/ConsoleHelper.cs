﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveProject.Helper
{
    public static class ConsoleHelper
    {
        public static bool IsTestMode { get; set; } = true;
        public static void Write(string text)
        {
            if(IsTestMode==false)
                Console.WriteLine(text);
        }

        public static string? Read()
        {   if (IsTestMode== false)
                return Console.ReadLine();
            return null;
        }

        public static char? ReadKey()
        {   if (IsTestMode==false)
                return Console.ReadKey().KeyChar;
            return null;
        }

        public static void Clear()
        {
            if(IsTestMode == false)
                Console.Clear();
        }
    }
}