using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E10Copy
    {

    public static void Izvedi()
        {
            int pb = UcitajBroj("Unesi prvi broj: ");
            int db = UcitajBroj("Daj mi drugi: ");

            IspisiBrojeve(pb, db);
        }


        private static void IspisiBrojeve(int pb, int db)
        {
            var Manji = pb <= db ? pb : db; 
            var Veći = pb >= db ? pb : db;

            for (int i = Manji; i<= Veći; i++)
            {
                Console.WriteLine(i);
            }
        }
        private static int UcitajBroj(string v)
        {
            for (; ; ) 
            {
                Console.WriteLine(v);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("nisi unio broj, probaj ponovo");
                }
            }
        }
    }
}
