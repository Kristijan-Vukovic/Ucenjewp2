

namespace UcenjeCS
{
    internal class E04Nizovi
    {
        public static void Izvedi()
        {
            // kreirao sam niz sa 12 integera (elemenata), u ovom slučju niz ima naziv temperature
            int[] temperature = new int[12];
            // prvi integer ( on ga naziva element) niza ima index 0
            // siječanj
            temperature[0] = 2;
            // veljača
            temperature[1] = 1;
            //. ..idu ostali mjesci
            // prosinac
            temperature[11] = 7;

            Console.WriteLine(temperature);// kada napišeš ovako dobit ćeš samo naziv tipa podatka ali ne i vrijednosti

            Console.WriteLine(string.Join(", ", temperature));// string.Join je metoda sa dva parametra koja napravi tekst od niza tako da umetne
                                                              // delimiter (prvi parametar) između svakog od elemenata niza. U ovom slučaju je to zarez između svakog broja

            // ovo iznad se može i jednostavnije napisati
            //int[] temperature = { 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7 };



            // višedimenzionalni nizovi
            int[,] tablica = // tablica je niz nizova tkz dvodimenzionalni niz
            {
                { 1, 2, 3 }, // prvi niz sa 3 elementa index 0
                { 4, 5, 6 }, // drugi niz sa 3 elementa index 1
                { 7, 8, 9 }  // treći niz sa 3 elementa index 2
            };

            // ispisati broj 5 - broj 5 se nalazi u drugom nizu (index 1), te je drugi element toga niza (index 1)
            Console.WriteLine(tablica[1, 1]);
            // ispisati broj 9 - broj 9 se nalazi u trećem nizu (index 2), te je treći element toga niza (index 2)
            Console.WriteLine(tablica[2, 2]);
        }
    }
}
