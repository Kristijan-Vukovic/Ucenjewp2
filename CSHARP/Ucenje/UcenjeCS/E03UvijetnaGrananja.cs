

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using System.Threading.Channels;

namespace UcenjeCS
{
    internal class E03UvijetnaGrananja
    {
        public static void Izvedi()
        {

            int i = 7; // 

            // Binarno granjanje 

            bool uvjet = i == 7;
           
            // uvjet ima vrijednost true, u slučju ispod ide pitanje ako je true onda izvrši komad blok koda

            if (uvjet)
            {
                Console.WriteLine($"ušao sam u true {i} dio naredbe");
            }

            // ovo gore i sada slijedeće je minimalni dio if naredbe, kod if naredbe izvršava se prva slijedeća naredba koja može biti blok koda
            //inače se u pravilu piše
            if (i == 7)
            {
                Console.WriteLine("isti uvjet kao i prethodno");
            }
            // drugi dio if naredbe (neobavezni) je else

            if (i < 5)
            {
                Console.WriteLine("i je manji od 5");
            }
            else 
            {
                Console.WriteLine("i nije manji o 5");
            }

            



            // puni izgled if naredbe

            if (i == 2)
            {
                Console.WriteLine("i je 2");

            }
            else if (i == 3)
            {
                Console.WriteLine(3);
            }
            else
            {
                Console.WriteLine("i nije nit 2 niti 3, pokušajte ponovo");
            }

            int j = 2;
            if (i == 7)
            {
                if(j== 2)
                {
                    Console.WriteLine("oba uvijeta su zadovoljena ugnježdeno");
                }
            }

            


            // korištenje logičkih operatora 
            // logičko i & , uvjetovano i && (čita se and)
            i = 5;
            if (i==7 & j == 2) // jedan & provjeravaju se oba uvjeta (i == 7 & j == 2) bez obzira ako se na prvom padne
            {
                Console.WriteLine("oba uvjeta su zadovoljena");            

            }

            if (i == 7 && j == 2) // && ukoliko padne (false) na prvom uvjetu  ne provjerava se drugi
            {
                Console.WriteLine("oba uvjeta su zadovoljena");
            }


            // logičko ili | (altgr+w) i uvjetovano ili || (čita se or)

            // jedna ravna crta, operator, | provjerava sve uvjete bezobzira što je prvi (true), dok ako se napišu dvije crte || provjera prestaje čim nađe prvi koji je (true).
            // p.s ne moarju biti 2 uvjeta može ih biti i više
           
            if (i == 5 | j == 1)
            { 
                Console.WriteLine("Dovoljno je da jedan od uvijeta bude zadovoljen da bi se ovo ispisalo- odnosno izvršila operacija u bloku koda, koji se,usput, kod metode naziva tijelo"); 
            }
            
            if (i == 5 || j == 1)
            {
                Console.WriteLine(" U ovom slučaju Prvi uvjet zadovoljen drugi se na provjerava. U slučaju da prvi nije zadovoljen provjera prestaje čim s zadovolji --prvi koji je (true)");
            }
        
            // logičko NE (!), uskličnik je operator, ( uskličnik je unarni operator što znači da se primjenjuje na ono što se nalazi nakon njega, samo negira ono što je iza. NPR. ako je iza njega vrijednost true on će ju pretvoriti u false i obrnuto
            // p.s operatori & i | su binarni i oni se primjenjuju i na vrijednosti njima sa lijeve desne starne

            if(!(i==4 || j == 15)) // bez uskličnika bi se čitalo ako je i 4 ili j 15 onda uđi u blok. a sa uskličnikom se čita ako nije istina da je i 4 ili j 15 onda uđi u blok.
            {
                Console.WriteLine("Niti je i==4 niti je j==15");
            }

            // skarćeni način pisanja: inline if

            Console.Write("upiši broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj > 10) { Console.WriteLine("Osijek"); }
            else { Console.WriteLine("Zagreb"); }

            //   ovo se može kraće pisati sa inline if (ternarni operator- jedini operator koji ima tri stvari na koje se odnosi)
            // koristi se u obliku (uvjet) (?) (kod ako se utvrdi da je uvjet istina) (:)  (kod ako se utvrdi da je uvjet neistina)

            Console.WriteLine(broj > 10 ? "Osijek" : "Zagreb"); // čita se, ako je broj veći od 10 uzmi Osijek inače uzmi Zagreb

            /* može i ovako, u ovom slučaju varijabla (poruka) se može koristiti pri pozivu metoda ili kao rezultat metode ili šta god
            var poruka = broj < 10 ? "manji je od 10" : "Slavonski Brod";
            Console.WriteLine(poruka);
            */


            // VIŠESTRUKO GRANANJE ----switch naredba grananja, u switchu se provjerava samo je li varijabla jednaka nekoj vrijednosti dok u if-u ili else-u možeš koristiti više različitih varijabli i ne mora nužno biti samo jednako
            // - switch znači,
            // uzmi mi vrijednost varijable (u primjeru je to ocjena) u slučaju da joj je vrijednost
            // jedan od caseova izvrši pripadajući blok koda (u primjeru je to onsole.WriteLine("bla,bla"). Svi blokovi završavaju na break.
            // U slučaju da varijabla nema ni jednu od case vrijednosti izvršava se default blok ako je naveden

            int ocjena = 4;

            switch (ocjena) // ov o je isto kao i if ili else if ali.... kod njih možeš imati =, <,> ,&& itd dok switch ima samo ako je jednako = 
            {
                case 1: // iza svakog casea mora ići break;
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                // ovo iznad se može pisati i zajedno ako se treba izvršiti ista stvar, ovo je jedina iznimka kada ne ide break odmah na kraju casea , zato što ide case za caseom
                //case 2:
                //case 3:
                //    Console.WriteLine("dovoljan ili dobar");
                //    break;
                case 4:
                    Console.WriteLine("Vrlo dobar");
                    break;
                case 5:
                    Console.WriteLine("Odličan");
                    break;
                default:
                    Console.WriteLine("Nije ocjena");
                    break;

            }
            string ime = "Pero";

            switch (ime)
            {
                case "Marko":
                    Console.WriteLine("OK");
                    break;
                case "Pero":
                    Console.WriteLine("Super");
                    break;
            }

            


         


        }

    }
}
