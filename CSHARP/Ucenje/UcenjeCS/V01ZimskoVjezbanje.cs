using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class V01ZimskoVjezbanje
    {
        public static void Izvedi()// zadatak 1- Napisati program koji ispisuje sve brojeve od 1 do 100
        {
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(i + 1);
            //}
            //Console.WriteLine("***************");// zadatak 2- Napisati program koji ispisuje sve brojeve od 100 do 1 
            //{ }
            //for (int i = 100; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 0 ; i < 100 ; i++)// zadatak 3 -Napisati program koji ispisuje sve brojeve od 1 do 100 koji su cjelobrojno djeljivi s 7
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }

        }


    }
}
