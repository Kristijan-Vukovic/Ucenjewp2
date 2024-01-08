using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E05")]
    public class E05ForPetlja: ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        public int[] Zad1(int brojevi)
        {
            // vraća niz s brojevima od 1 do brojevi

            int[] niz = new int[brojevi];// deklariranje niza tako da ima onoliko elemenata kolka je vrijednost parametra brojevi
            for (int i = 0; i < brojevi; i++)// for petlja koja iterira od nula do vrijednsoti parametra brojevi
            {
                niz[i] = i + 1;// (i + 1 znači da vrijednst 1 bude na indexu 0) puni jedan po jedan index niza, na vrijednst za jedan veću od indexa. U slučaju da je index 0 vrijednsot se diže za +1
            }
            return niz;

            //return Enumerable.Range(1, brojevi).ToArray(); // Ova linija zamjenjuje sav kod ove metode (od int[] niz = ...; do return niz;)
        }
         




        [HttpGet ("zad2")]

        public int ZbrojBrojeva(int broj)
        {
            int suma = 0;
            // vraća zbroj brojeva od 1 do primljenog broja. Ako se upiše broj 100 odraditi će se 100 iteracija
            for (int i = 1; i <= broj; i++)
            {
                suma += i; //+= uvećaj mi za, u ovom slučaju za i
            }
            return suma;

            // DZ napravi isti izračun sa duplo manje iteracija. Rješenje ispod
            //int suma = 0;

            //for (int i = 1; i <= broj; i+= 2)
            //{
            //    if (i + 1 <= broj)
            //        suma += i + (i + 1);
            //    else
            //        suma += i;
            //}
            //return suma;
        }
        


    }
}
