using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E01")]
    public class E01UlazIzlaz : ControllerBase
    {
        
        //[HttpGet("Hello/{ime}")]
        //public string HelloWorld(string ime)
        //{
        //    return "Hello " + ime;
        //}

        //[HttpGet("Hello/{ime}/{prezime}/{godine}/{dostupan}")]

        [HttpGet("Hello/{ime}/{prezime}/{godine}/{dostupan}")]

        //[Route("Hello")]
        public string Helloworld(string ime, string prezime, int godine, bool dostupan)
        {
            //return ime + " " + prezime + " " + godine;

            //return $"{ime} {prezime} {godine}";

            return $" upisali ste {ime} {prezime}, koji ima {godine} godine, {dostupan}";


        }

 

    }

}
