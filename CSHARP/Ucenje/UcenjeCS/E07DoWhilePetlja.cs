using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07DoWhilePetlja
    {
        public static void Izvedi()


        {
           // mora li se ući u for i while petlju? NE
           // ako uvjet na početku nije zadovoljen ne ulazi se
           // što nas dovodi do Do Whilea
           // do while osigurava minimalno jedno izvođenje
           // uvjet je na kraju petlje

            // ako napišemo while (false) neće nikada ući ali
            // ako napišemo do while (false) onda će ući jednom
                         
            do
            {
                Console.WriteLine("Edunova");
            } while (false);

            // continue, break i ugnježđivanje isto kao kod for i while

            // prekidanje vanjske petlje

            for (; ; )
            {
                while (true)
                {
                    do
                    {
                        //break; //1
                        // kako prekinuti vanjski for
                        goto nakonfor;
                    } while (true);
                    // ovdje se nastavlja 1
                    // break; //2
                }
                // ovdje se nastavlja 2
            }
            nakonfor:  // ovo je labela
            Console.WriteLine("odradio");

        }



    }
}
