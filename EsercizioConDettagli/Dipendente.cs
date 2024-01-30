using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioConDettagli
{
    internal class Dipendente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Età { get; set; }



        public void GetName()
        {
           
            Nome = Console.ReadLine();
        }

        public void GetCognome()
        {
         
            Cognome = Console.ReadLine();
        }

        public void GetEtà()
        {
          
            Età = Convert.ToInt32(Console.ReadLine());
        }

      public void GetDettagli()
        {
            Console.WriteLine(Nome + " "+ Cognome + " "+ Età );

        }

    }
}
