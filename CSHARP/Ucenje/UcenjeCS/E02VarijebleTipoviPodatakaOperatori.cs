

namespace UcenjeCS
{
    internal class E02VarijebleTipoviPodatakaOperatori
    {

        public static void Izvedi()
        {

            int varijabla = 3;

            Console.WriteLine(varijabla);

            int i = 1, j = 0, k;


            Console.WriteLine("{0},{1}", i, j);// formatiranje stringa. Kada je riječ o formatiranju u vitičastim zagradama su indexi{}, u ovom slučaju i iden na index 0 a j na 1

            Console.WriteLine($"{i},{j}");// ovdje smo koristili interpolaciju da se ista stvar ispiše, više će se koristi ovaj način, kod posebnih slučajeva koristim način iznad

            
            bool istina = i == 1; //ovo je provjera ako je i 1 pnda će staviti true aakoni je onada će false

            Console.WriteLine(istina);

            //-----------------------

            double broj = 4.89;

            decimal vecibroj = 2.99m;

            // brojevi se nalaze na brojevnoj kružnici
            Console.WriteLine(int.MaxValue);
            int Mb = int.MaxValue;
            Console.WriteLine(Mb + 1);

            i = 3;j = 2; k = 1;

            Console.WriteLine(i+j);// OPERATORI + - * / < > >=  <= == != služe da bi se izvršila neka operacija
            Console.WriteLine(i - j);
            Console.WriteLine(i * j);//množenje
            Console.WriteLine(i / j);//dijeljenje daje cijeli broj zato što je tip podatka int, 
            Console.WriteLine( (decimal) i / j );// ovdje ćeš dobiti decimal, ovo znači pretvori mi prvi iza unutrašnje zagrade (to je i) u decimal i podjeli sa j

            
            // za dvoznamenkasti broj da se ispiše prva znamenka
            int db = 56;
            Console.WriteLine(db/10);

            bool uvjet = i > j; // je li i veći od j(ako DA onda true ako NE onda false)
            uvjet = i < j; // je li i manji od j ( ako DA onda true ako NE onda false)
            uvjet = i >= j; // je li i veći ili jednak j ( ako DA onda true ako NE onda false)
            uvjet = i <= j; // je li i manji ili jednak j ( ako DA onda true ako NE onda false)
            uvjet = i == j;// provjera jednakosti ( ako DA onda true ako NE onda false)
            uvjet = i != j; // provjera nejednakosti ( ako DA onda true ako NE onda false)


            // operator modulo, piše se kao znak za postotak %
            // ostatak nakon cjelobrojnog djeljenja
            
            int ostatak = 9 % 4; //rezultat će biti 1,  9 podijeljeno sa 4 je 2 i do 9 ostane 1 (2*4=8 i do 9 ostane 1)

            //Console.WriteLine(ostatak);


            // za dvoznamenkasrti broj ispiši vrijednost jedinice
            Console.WriteLine(52 % 10);


            i = 1;

            Console.WriteLine(i);//1

            i = i + 1;// uvećavanje za 1
            Console.WriteLine(i);//2

            i += 1; // uvećavanje za 1 ili bilo koji broj koji napišemo iza +=  npr. 3 , kraći način pisanja onoga iznad
            Console.WriteLine(i); // 3

            i++; //uvećavam za još 1 i to isključivo za samo jedan. ne može se kao iznad uvećatio za npr. 3
            Console.WriteLine(i);//4

            // specifičnosti incrementa ++
            // i++ prvo koristi trenutnu vrijdnost pa onda uveća
            Console.WriteLine(i++);//4
            Console.WriteLine(i);//5
            // ++i prvo uveća pa onda koristi
            Console.WriteLine(++i);// 6
            Console.WriteLine(i); //6

            // SVE VRIJEDI ISTOVJETNO i za dekrement (--)

     



            







        }


    }
}
