using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E08ForEachPetlja
    {
        public static void Izvedi()


        {
            int[] niz = { 1, 2, 3, };
                
            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);
            }

            // gornji kod je ekvivalent donjem

            foreach (int element in niz)// inače ide i umjesto element ali je ovdje napisanon da nas nebi bunilo da je i inkrement jer u ovovm slučaju on to nije
            {
                Console.WriteLine(element);
            }
            // sve ostale značajke petlji jednako funkcioniraju


            // tip podatka string

            string ime = "Edunova";

            Console.WriteLine(ime);

            foreach (char c in ime)
            {
                Console.WriteLine(c + ": " + (int)c);
            }

            Console.WriteLine("-----------------------");


            // korisnik unosi tekst- Osijek je super grad
            // koje je slovo unio koliko puta
            //O 1
            //s 2
            //i 1
            //j 2
            // .....i tako do kraja Osijek je super grad

            Console.Write("unesi tekst: ");
            string unos = Console.ReadLine();

            Console.WriteLine(unos);

            int[] slova = new int[unos.Length]; 
            int index = 0;
            int ukupno;
            foreach(char c in unos)
            {
                ukupno = 0;
                foreach (char cc in unos)
                {
                    if (c == cc)
                    {
                        ukupno++;
                    }
                }
                slova[index++] = ukupno;
            }
            Console.WriteLine(string.Join(",", slova));

            // napomna se odnosi na kod od linije 78 pa dalje--->  ne treba mi toliko prostra pošto je ovdje niže (na liniji 78) new char[unos.Length] pa dužina ne može biti veća od koliki je unos
            // najveći nedostatak nizova je taj što se na početku mora reći koliko će biti elemenata
            // (ako znaš onda je to u redu, ako ne onda je zeznuto)
            char[] JedinstvenaSlova = new char[unos.Length];
            bool postoji;
            index = 0;
            foreach (char c in unos)
            {
                postoji = false;
                foreach(char cc in JedinstvenaSlova)
                {
                    if (c == cc)
                    {
                        postoji = true;
                        break;
                    }
                }
            if (!postoji)
                {
                    JedinstvenaSlova[index++] = c;
                }
            }
            Console.WriteLine(string.Join(",", JedinstvenaSlova));
        }



    }
}
