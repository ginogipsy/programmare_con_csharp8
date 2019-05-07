﻿/*
 * Programmare con C# 8 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 15: CAller Info Attributes
 */
using System;
using System.Runtime.CompilerServices;

namespace CallerInfoAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            LogInfo(); //riga 15
            PropertyInt = 1;
        }

        public static int PropertyInt
        {
            get
            {
                LogInfo();
                return 0;
            }
            set
            {
                LogInfo();
            }
        }

        public static void LogInfo(
                [CallerMemberName] string memberName = null,
                [CallerFilePath] string filePath = null,
                [CallerLineNumber] int lineNumber = 0)
        {
            Console.WriteLine(memberName);
            Console.WriteLine(filePath);
            Console.WriteLine(lineNumber);
        }
    }
}
