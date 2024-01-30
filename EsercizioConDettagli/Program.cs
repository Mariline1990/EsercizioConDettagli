using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioConDettagli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dipendente dipendente1 = new Dipendente();

            Console.WriteLine("inserisci il nome");
            dipendente1.GetName();

            Console.WriteLine("inserisci il cognome");
            dipendente1.GetCognome();

            Console.WriteLine("inserisci il Età");
            dipendente1.GetEtà();
           

            dipendente1.GetDettagli();

            Console.ReadLine();

        }
    }
}