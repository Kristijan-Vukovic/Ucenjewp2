using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V01")]
    public class V01ZimskoVjezbanje: ControllerBase
    {
        [HttpGet("vjezba1")]

        
        public int Vjezba1(int broj1, int broj2, string operacija)// korišten switch zato što je ovdje set dozvoljenih vrijednosti parametra operacija (string) određen. (+, -, *, /) i ispituje se  je li operacija jednaka jednoj od tih vrijednosti
        {
            switch (operacija)
            {
                case "+":
                    return broj1 + broj2;
                case "-":
                    return broj1 - broj2;
                case "*":
                    return broj1 * broj2;
                case "/":
                    return broj1 / broj2;
            }
            return 0;
        }

       


    }
}
