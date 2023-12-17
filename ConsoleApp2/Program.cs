using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murad", "Hesen", "Abbas", "Merdan", "Tural", "Elnur", "Xaliq" };
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("******************");
            List<string> isimler2 = new List<string> { "Engin", "Murad", "Hesen", "Abbas", "Merdan", "Tural", "Elnur", "Xaliq","Zakir","Uqur"};
            isimler2.Add("SAMIR");
            isimler2.Add("XXX");
            foreach (var item in isimler2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
