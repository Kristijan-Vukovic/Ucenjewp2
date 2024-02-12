﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E10ObradaIznimki
    {

        public static void Izvedi()
        {

            int pb = UcitajBroj("Unesi prvi broj: ");
            int db = UcitajBroj("Daj mi i drugi: ");
            IspisiBrojeve(pb, db);
        }

        private static void IspisiBrojeve(int pb, int db)
        {
            throw new NotImplementedException();
        }

        private static int UcitajBroj(string v)
        {
            for (; ; )
            {
                Console.Write(v);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Nisi unio broj");
                }
            }
         
            //return 0;
            

            
        }
    }
}
