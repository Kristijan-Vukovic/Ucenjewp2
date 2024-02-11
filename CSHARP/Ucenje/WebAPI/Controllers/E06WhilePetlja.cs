using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E07")]
    public class E07Metode: ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        public int Zad1(int PrviBroj, int DrugiBroj)
        {
           
            // napišite metodu za dva primljena cijela
            //broja vraća njihov zbroj
            // neka ova metoda Zad1 vrati rezultat napisane metode zadatka
           
            return Zbroj(PrviBroj, DrugiBroj);

        }

        private int Zbroj(int prviBroj, int drugiBroj)
        {
            return prviBroj + drugiBroj;
        }

        //DZ
        // Kreirati rutu zad2 koja prima 4 cijela broja
        // i vraća razliku prvi+drugi i treći+ četvrti
        // koristite kreiranu metodu za zbroj dvaju brojeva


        //Kreirati rutu ad3 koja prima ime grada i slovo.
        //ruta vraća broj pojavljivanja slova u primljenom imenu grada
        // koristiti metode


    }

    }
