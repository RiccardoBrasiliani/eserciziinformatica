using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            Ipv4Calc calc;
            Console.WriteLine("Inserisci l'indirizzo ip in formato xxxxxxxx.xxxxxxxx.xxxxxxxx.xxxxxxxx/x");
            string risposta = Console.ReadLine();
            calc = new Ipv4Calc(risposta);
            Console.WriteLine(calc.generateIpv4());
            Console.WriteLine(calc.generateSubnet());
            Console.ReadLine();
        }
    }
    interface iAddress
    {
        string generateIpv4();
        string generateSubnet();
    }
    class Ipv4Calc : iAddress
    {
        string bits;
        string[] otteti;
        string ipv4;
        string subnet;
        public Ipv4Calc(string bits)
        {
            this.bits = bits;
        }
        public string generateIpv4()
        {
            otteti = bits.Split('.', '/');
            return $"{Convert.ToInt32(otteti[0], 2).ToString()}.{Convert.ToInt32(otteti[1], 2).ToString()}.{Convert.ToInt32(otteti[2], 2).ToString()}.{Convert.ToInt32(otteti[3], 2).ToString()}";

        }
        public string generateSubnet()
        {
            otteti = bits.Split('.', '/');
            string bit = string.Empty;
            for (int i = 0; i < 32; i++)
            {
                if (i < Convert.ToInt32(otteti[4]))
                    bit += 1;

                else
                    bit += 0;
                if (i == 7)
                    bit += ".";
                if (i == 15)
                    bit += ".";
                if (i == 23)
                    bit += ".";

            }
            otteti = bit.Split('.');
            return $"{Convert.ToInt32(otteti[0], 2).ToString()}.{Convert.ToInt32(otteti[1], 2).ToString()}.{Convert.ToInt32(otteti[2], 2).ToString()}.{Convert.ToInt32(otteti[3], 2).ToString()}";

        }

    }
}
