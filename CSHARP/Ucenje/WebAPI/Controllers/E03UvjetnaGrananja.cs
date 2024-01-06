using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E03")]
    public class E03UvjetnaGrananja: ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        public string Zad1(int broj) 
        {
            // Za primljeni cijeli broj vraća se paran ili neparan, ovisno kakav je primljen broj


            // rješenje 1 sa if i else . U ovon sučaju else ne treba

            //if ( broj % 2 == 0 )
            //{
            //    return "PARAN";
            //}
            //else
            //{
            //    return "NEPARAN";
            //}

            // rješenje 2, samo if

            //if (broj % 2 == 0)
            //{
            //    return "PARAN";
            //}
            //return "NEPARAN";

            // rješenje 3

            return broj % 2 == 0 ? "PARAN" : "NEPARAN";

        }

        [HttpGet ("zad2")]
        public string OcjenaTekstom(int ocjena)
        {
            switch (ocjena)
            {
                case 1:
                    return "Nedovoljan";
                case 2:
                    return "Dovoljan";
                case 3:
                    return "Dobar";
                case 4:
                    return "Vrlo dobar";
                case 5:
                    return "Odličan";
                //default:
                   // return "Nije ocjena";
              
            }

            return "Nije ocjena";

        }
        
    }
}
