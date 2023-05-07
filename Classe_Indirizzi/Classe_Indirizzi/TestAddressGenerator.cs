using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Indirizzi
{
    class TestAddressGenerator:AddressGenerator
    {
        public static void Main()
        {
            int scelta;
            string[] stringa = new string[4];
            AddressGenerator tmp = new AddressGenerator();
            AddressGenerator indirizzo;
            Console.WriteLine("Ciao vuoi generare un indirizzo ip e una subnetmask se si digita 1 altrimenti digita 2");
            scelta = Convert.ToInt32(Console.ReadLine());
            try
            {
                switch (scelta)
                {
                    case 1:
                        indirizzo = new AddressGenerator(tmp.Generateipv4(), tmp.Generatesubnetmask());
                        Console.WriteLine("ecco l'indirizzo ip e la subnetmask");
                        Console.WriteLine(tmp.Generateipv4());
                        Console.WriteLine(tmp.Generatesubnetmask());
                        break;
                    case 2:
                        break;
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("risposta errata");
            }
        }
    }
}
