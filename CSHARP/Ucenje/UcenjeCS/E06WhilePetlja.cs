using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06WhilePetlja
    {
        public static void Izvedi()


        {
            bool uvjet = true;
            int i = 0;
            while (uvjet)
            {

                Console.WriteLine(i);

                uvjet = ++i < 10;
            }

            Console.WriteLine("---------------");

            i = 0;
            while (++i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("---------------");

            // continue

            i = 0;
            while (++i < 10)
            {
                if (i == 2) // prilkom ispisa preskače se vrijednost 2
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------");

            // break

            while (true)
            {
                Console.WriteLine("Edunova");
                break;

            }

            Console.WriteLine("---------------");
            // ugnježđivanje ili nesting, nested loops

            i = 0;
            while (++i < 10)
            {
                while (true)
                {
                    Console.WriteLine(i);
                    break;
                }
            }


            Console.WriteLine("---------------");

            // zadatak: Korisnik unosi broj
            // Program ispisuje sve brojeve od unesenog do 100
            // koristeći while petlju


            // ovo je moja verzija koda rješenja 

            //Console.Write("Unesi broj: ");

            //int visina = int.Parse(Console.ReadLine());

            //i = visina;

            //if (visina <= 100)
            //{
            //    while (++i < 100)
            //    {
            //        Console.WriteLine(i);


            //    }

            //}
            //else
            //{
            //    while (--i => 100)
            //    {
            //        Console.WriteLine(i);


            //    }
            //}
            // verzija sa nastave

            Console.Write("unesi broj: ");
            int broj = int.Parse(Console.ReadLine());
            Console.WriteLine(broj);

            if (broj < 100)
            {
                while (broj <= 100)
                {
                    Console.WriteLine(broj++);
                }
            }
            else
            {
                while (broj >= 100)
                {
                    Console.WriteLine(broj--);
                }
            }



        }



    }
}
