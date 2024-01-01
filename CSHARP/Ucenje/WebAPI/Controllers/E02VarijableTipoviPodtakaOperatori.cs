using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E02")]
    public class E02VarijableTipoviPodtakaOperatori : ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        public int Zad1() 
        {
            // vratite najmanji broj
            return int.MinValue;

        }

        [HttpGet("Zad2")]
        //ili ovako [Route("Zad2")], mada je ono iznad brže 
        public float Zad2(int i, int j)
        {
            // vraća se rezultat dijeljenja između i/j
            return (float)i / j;
        }
        [HttpGet("zad3")]
        //ili ovako [Route("zad3")], mada je ono iznad brže
        public float Zad3(int i, int j)
        {
            // vraća se zbroj množenja i dijeljenja
           float mnozenje = (float)i * j; // --može i ovako--   var mnozenje = (float)i *j;
           float podijeljno = (float)i / j;  // var podijeljno = (float)i / j;
            return mnozenje + podijeljno;

        }
        [HttpGet("zad4")]
        //ili ovako [Route("zad4")], mada je ono iznad brže
        public string Zad4(string s, string s1) 
        {
            // vrati unešene vrijednost spojene jedna uz drugu
            return s + s1;
        }

        [HttpGet("zad5")]
        //ili ovako [Route("zad5")], mada je ono iznad brže
        public bool IstiSu(int a, int b)
        {
            // vrati true ako su jednake vrijednosti a i b
            return a == b;

        }
    }
}
