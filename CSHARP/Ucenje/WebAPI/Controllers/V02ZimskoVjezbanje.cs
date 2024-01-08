using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V02")]
    public class V02ZimskoVjezbanje : ControllerBase
    {
        [HttpGet("zad1")]
        public int[] Zad1(int brojevi)// obrati pozornost da ti je ovdje vrsta povratnog podatka int niz na eng. int array, morati ćeš mijenjati ovisno o zadatku
        {
            return null;
        }


    }
}
