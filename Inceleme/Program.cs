using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceleme
{
    class Program
    {
        static string s2 = "nur";
        static void Main(string[] args)
        {
            Console.WriteLine("naber:");

            Console.WriteLine("isim ne:");
            string ısım = Console.ReadLine();
            Console.WriteLine("soy ismin ne:");
            string soyısım = Console.ReadLine();

            Console.WriteLine(" yaşadınığı yer:");
            string yasadıgınYer = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("isim "  + ısım );
            Console.WriteLine("soyısım "+ soyısım);
            Console.WriteLine("yaşadığı yer " + yasadıgınYer);
            Console.ReadLine();



           
        }
    }
}
