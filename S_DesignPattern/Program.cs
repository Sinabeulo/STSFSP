using S_DesignPattern.AbstractFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input.ToUpper())
            {
                case "AFP":
                    Tester AFP_tester = new Tester();
                    AFP_tester.Test();
                    break;
            }
            Console.ReadLine();
        }
    }
}
