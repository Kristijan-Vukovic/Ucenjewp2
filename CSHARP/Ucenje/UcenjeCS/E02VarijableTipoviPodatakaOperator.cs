

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodatakaOperator
    {

        public static void Izvedi()
        {

            int Varijabla = 3;

            Console.WriteLine(Varijabla);

            int i=1, j=0, k;

            Console.WriteLine("{0},{1}", i, j);

            bool Istina = i == 1;

            Console.WriteLine(Istina);

            double Broj = 4.89;
            decimal VeciBroj = 2.99M;

            // brojevi se nalaze na brojevnoj kružnici
            Console.WriteLine(int.MaxValue);
            int Mb = int.MaxValue;
            Console.WriteLine(Mb+1);

            i = 3; j = 2; k = 1;

            Console.WriteLine(i + j);
            Console.WriteLine(i - j);
            Console.WriteLine(i * j); //množenje
            Console.WriteLine(i/j);// djeljenje daje cijeli broj i onda se napravi ovo ispod dobiješ rez u decimalnom obliku
            Console.WriteLine((float)i/j); // dijeljenje sa decimalnim rezultatom

            // za dvoznamenkasti broj ispiši prvu znamenku
            int db = 56;
            Console.WriteLine(db/10);

            bool uvjet = i > j;
            uvjet = i >= j;
            uvjet = i <= j;
            uvjet = i < j;
            uvjet = i == j; // provjera jednakosti
            uvjet = i!= j;// provjera ne jednakosti


            // operator modulo
            // ostatak nakon cjelobrojnog djeljenja
            int ostatak = 9 % 2;

        }

    }
}
