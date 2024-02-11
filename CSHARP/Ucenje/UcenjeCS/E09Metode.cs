using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E09Metode
    {

        public static void Izvedi()
        {
            //do OOP-a sve metode će biti static u ovom projektu UcenjeCS
            // POZIV METODE TIP 1
            Tip1();
            Tip2(3,23);

            // Ključna riječ var uzima tip podatka s desne strane
           var ime =  ImeRacunala();// Tip3
            Console.WriteLine(ime);
            // bolje
            Console.WriteLine(ImeRacunala());

            Console.WriteLine(PrimBroj(7) ? "PRIM": "NIJE");

            //Zadatak: ispiši sve prim brojeve između dva prim broja
            SviPrimBrojevi(27, 99);

        }

        private static void SviPrimBrojevi(int Od, int Do)
        {
            for (int i = Od; i<=Do; i++)
            {
                if (PrimBroj(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        // 1. vrsta tipa void, ne prima vrijednost, prima praznu listu parametara
        // TIJELO METODE
        static void Tip1()
        {
            Console.WriteLine("Hello iz tip 1");

        }
        // 2. vrsta tipa void, prima parametre
        static void Tip2(int Od, int Do)
        {
            // ispiši sve parne brojeve između dva primljena parametra
             
            for (int i = Od; i <= Do; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                 }
                Console.WriteLine(i);

                //  može i ovako
                //  if (i % 2 == 0)
                //  {
                //    Console.WriteLine(i);
                //  }
            }
                
             
        }

        // 3. vrsta: određenog tipa koji vraća pozivatelju, ne prima parametre
        static string ImeRacunala()
        {
            return System.Net.Dns.GetHostName();
        }

        // 4. vrsta- najkorisnija- određenog tipa koji vraća pozivatelju i prima parametre
        
        static bool PrimBroj(int Broj)
        {
            for (int i = 2; i < Broj; i++) 
            {
                if(Broj % i == 0)
                {
                    return false; //shortcuircuting
                }
            }  



            return true;
        }



    }
}
