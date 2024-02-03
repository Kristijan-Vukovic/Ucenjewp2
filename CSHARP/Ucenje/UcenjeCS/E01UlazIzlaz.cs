using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01UlazIzlaz
    {

        public static void Izvedi()
        {



            // ispisi različitih tipova podataka
            //Console.WriteLine(7); // int
            //Console.WriteLine(true);// bool
            //Console.Write("Prvi");// string
            //Console.Write("Drugi");// string
            //Console.WriteLine(3.14);// float ( ustvari double)


            // varijabla je prostor u memoriji

            //Console.Write("Unesi ime: ");
            //string ime = Console.ReadLine();
            //ime = $"upisali ste: '{ime}'";

            //Console.WriteLine(ime);



            //ulaz
            //Console.Write("Unesi visinu u centimetrima: ");

            //int visina = int.Parse(Console.ReadLine());

            //algoritam

            //decimal visinaumetrima = visina / 100m;

            //Console.WriteLine("Visoki ste " + visina / 100m + " metara");


            //izlaz
            // Console.WriteLine($"Visoki ste {visinaumetrima} metara");




            //Console.Write("Unesi visinu u centimetrima: ");

            //int visine = int.Parse(Console.ReadLine());

            //decimal izracunvisine = visine / 100m;


            //Console.WriteLine($"Tvoja visina je: {izracunvisine}  metara({visine / 100m} cm)");





            //Console.Write("ucitaj dec br ");

            //decimal visina = decimal.Parse(Console.ReadLine());

            //Console.WriteLine($"njezina vrijednost je:  {visina} ");



            Console.Write("Unesi duzinu prostorije: ");
            decimal duzina = decimal.Parse(Console.ReadLine());
            Console.Write("unesi širinu prostorije:");
            decimal sirina = decimal.Parse(Console.ReadLine());
            decimal povrsina = duzina * sirina;

            //var povrsina = duzina * sirina; var se koristi da bi ubrzao pisanje jer uvijek postaje onaj tip podatka koji se dobije sa desne strane znaka =

             Console.WriteLine($"povrsina prostorije je: {povrsina} m2");//$ Znak dolara sluzi za interpolaciju odnosno ubacivanje različitih vrijednost u tekst stringa,
            //interpolirane vrijednosti idu u vitičaste zagrade {}, rješavaš se pluseva, brže i čišće je
            // unutar obične zagrade se nalazi PARAMETAR koji su potrebni metodi kako bih ona izračunala rezultat 
            // odnosno vratila ono za što je pozvana ili što se od nje traži

            

        }

    }
}
