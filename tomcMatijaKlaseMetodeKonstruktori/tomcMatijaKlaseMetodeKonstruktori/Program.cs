using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaKlaseMetodeKonstruktori
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceduralni x = new Proceduralni();
            Objektni y = new Objektni();
            Funkcionalni z = new Funkcionalni();

            Console.WriteLine("Upiši te postotak za Proceduralni tip jezika: ");
            x.Postotak = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Upiši te postotak za Objektni tip jezika: ");
            y.Postotak = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Upiši te postotak za Funkcionalni tip jezika: ");
            z.Postotak = Convert.ToDouble(Console.ReadLine());

            if (x.Postotak + y.Postotak + z.Postotak != 100)
            {
                Console.WriteLine("Neispravni podaci!!");
            }
            else
            {
                if (x.Postotak > y.Postotak && x.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najzatupljeniji tip jezika je Proceduralni");
                }
                else if (y.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najzatupljeniji tip jezika je Objektni");
                }
                else
                {
                    Console.WriteLine("Najzatupljeniji tip jezika je Funkcionalni");
                }
            }

            Console.ReadKey();
        }
    }
}
