using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E04")]
    public class E04Nizovi: ControllerBase
    {
        [HttpPost]
        [Route("zad1")]
        public string Zad1(string[] podaci)
        {
            // vrati prvi element primljenog niza
            return podaci[0];
        }

        // može i sa HttpGet ako na parametar dodamo atribut [FromQuery]
        // Kompleksni tipovi podataka se po defaultu pokušavaju poslati kroz Body od Requesta, no HttpGet ne dozvoljava slanje Bodya
        // Umjesto toga, podaci se šalju kroz URL (putem Query Stringa - npr. https://localhost/E04/Zad1?podaci=pero&podaci=miro)
        //[HttpGet]
        //[Route("zad1")]
        //public string Zad1([FromQuery] string[] podaci)
        //{
        //    // vrati prvi element primljenog niza
        //    return podaci[0];
        //}


        [HttpPut("zad2")]

        public int Zad2(string[] podaci)
        {
            //Ruta prima cijele brojeve kao nizove znakova
            // ruta će primiti 3 broja
            //ruta će vratiti najveći broj

            int b1 = int.Parse(podaci[0]);
            int b2 = int.Parse(podaci[1]);
            int b3 = int.Parse(podaci[2]);

            if (b1 >= b2 && b1 >= b3)// provjeri je li b1 veći ili jednak i od b2 i od b3 ako je onda je on najveći broj pa ga vrati return b1
                return b1;
            if (b2 >= b1 && b2 >= b3)// provjeri je li b2 veći ili jednak i od b1 i od b3 ako je onda je on najveći broj pa ga vrati return b2
                return b2;
            return b3;// ako ni b1 ni b2 nisu najveći onda vrati b3

            // sve je moglo i sa 2 linije
            int[] b = { int.Parse(podaci[0]), int.Parse(podaci[1]), int.Parse(podaci[2]) };
            return b.Max();

            // sve je moglo i sa 1 linijom
            return podaci.Select(int.Parse).Max();// za svaki element u podaci, izvedi int.Parse, a nakon toga nađi Max broj u nizu i vrati ga
        }

        [HttpDelete("Zad3")]
        public string BrojElemenataNiza(int[] podaci)
        {
            return podaci.Length.ToString();

        }


    }
}
