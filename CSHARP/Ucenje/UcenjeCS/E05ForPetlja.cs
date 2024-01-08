

namespace UcenjeCS
{
    internal class E05ForPetlja
    {
        public static void Izvedi()
        {
            // ispisati 10 puta Edunova
            // ovo je najgore moguće rješenje
            //Console.WriteLine("edunova");
            //Console.WriteLine("edunova");
            //Console.WriteLine("edunova");
            //Console.WriteLine("edunova");
            //Console.WriteLine("edunova");
            //Console.WriteLine("edunova");
            //Console.WriteLine("edunova");
            //Console.WriteLine("edunova");
            //Console.WriteLine("edunova");
            //Console.WriteLine("edunova");

            // sintaksa for petlje (od kuda, odnosno definiranje početnog stanja ili šta će se napraviti prvo kada kod dođe u prvu iteraciju petlje,
            // najčešće stavljanje varijable koja je brojač na 0 ; "do kuda" odnosno uvjet sa kojim se provjera treba li nastaviti sa petljom ili ne,
            // dnosno treba li napravit još jednu iteraciju;
            // uvećanje/umanjenje- odnosno šta treba kod napraviti kada završi iteracija, kod koji se izvršava nakon što završi iteracija,
            // najčešće uvećanje ili umanjenje varijable koja je brojač za 1, ako si krenuo od 0 onda uvećanje ako od nekog broja onda umanjenje))
            
            for(int i = 0; i < 100 ; i++)
            {
                Console.WriteLine("edunova");
                //Console.WriteLine($"{i}: edunova"); ako hoćeš redni broj uz brojeve da ne brojiš linije
            }

            // može se pisati i sa varijablom deklariranom izvan petlje
            int t;

            for (t = 0; t<10; t++)
            {
                Console.WriteLine("edunova T");
            }

            // varijabla u petlji mijenja vrijedost

            for(int i=0; i<10; i++)
            {
                Console.WriteLine(i+1);
            }


            // ne mora biti uvećanje može i umanjenje

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            // korak uvećanja ili umenjenja može biti veći  od 1

            for(int i = 0; i<20; i += 2)
            {
                Console.WriteLine(i);
            }

            // ispisati sve parne brojeve između 3 i 23

            for (int i = 4; i<23; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("****************");
            // ispisati sve parne brojeve između 3 i 23 koje je unio korisnik

            int manji = 3;
            int veci = 23;

            for(int i = manji; i <= veci; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // ispisati sve parne brojeve neovisno je li korisnik unio prvo veći ili manji broj

            int prviunos = 24;
            int drugiunos = 78;


            int Manji = prviunos < drugiunos ? prviunos : drugiunos;//ako je prviunos (manji <) od drugiunos onda uzmi prviunos (iza znaka ?) inače uzmi drugiunos (iza znaka :)
            int Veci = prviunos > drugiunos ? prviunos : drugiunos;//ako je prviunos (veći >) od drugiunos onda uzmi prviunos (iza znaka ?) inače uzmi drugiunos (iza znaka :)
           
            for (int i = Manji; i <= Veci; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            for(int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    Console.Write((i + 1) * (j + 1) + " ");
                }
                Console.WriteLine();
            }

            // iteracija unutar petlje se može preskočiti- u u ovom slučaju ispiši brojeve od nula do 9 koji nisu dijeljivi sa 3

            for (int i = 0; i < 10; i++)
            {

                if (i % 3 == 0)
                {
                    continue;// on znači nastavi sa slijedećom iteracijom, bez izvršavanja ostalog koda u ovoj iteraciji( u ovom slučaju to je Console.WriteLine(i);
                }

                Console.WriteLine(i);

            }

            // petlja (loop) se može prekinuti

            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    break; 
                }
                Console.WriteLine(i);
            }




        }
    }
}
