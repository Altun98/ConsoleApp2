﻿using System;
using System.Runtime.InteropServices.ComTypes;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();

            isimler.Add("Hesen");
            Console.WriteLine("Hello World!");
        }
    }
}
