using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarmanTerningspil
{
    class Program
    {
        static void Main(string[] args)
        {
            Spil spil = new Spil(); 
            for (int i = 0; i < 10; i++)
            {
                if (spil.Play() == true)
                {
                    Console.WriteLine("Du har vundet");
                }
                else
                {
                    Console.WriteLine("Du har tabt");
                }
            }

            Console.ReadLine();

        }
    }
}
