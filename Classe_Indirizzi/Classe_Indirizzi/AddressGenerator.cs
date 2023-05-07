using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Indirizzi
{
    class AddressGenerator:Interface1
    {
        string ipaddress;
        string subnetmask; 
        public string IpAddress { get { return ipaddress; } set { ipaddress = value;  } }
        public string SubnetMask { get { return subnetmask; } set { subnetmask = value;  } }
        
        public string Get_IpAddress()
        {
            return IpAddress;
        }
        public string Get_Subnetmask()
        {
            return SubnetMask; 
        }
        public AddressGenerator(string stringa,string stri)
        {

        }
        public AddressGenerator()
        {
            
        }
        public string Generateipv4()
        {
            Random random = new Random();
            int[] ipAddress = new int[4];

            for (int j = 0; j < 4; j++)
            {
                ipAddress[j] = random.Next(256);
            }
            return string.Join(".", ipAddress);
        }
        public string Generatesubnetmask()
        {
            Random random = new Random();
            int mask = random.Next(1, 33); // genera un numero casuale da 1 a 32
            // converte il numero in una subnetmask in formato binario
            string binaryMask = new string('1', mask).PadRight(32, '0');
            // suddivide il formato binario in 4 gruppi di 8 bit
            string[] otteto = new string[4];
            for (int i = 0; i < 4; i++)
            {
                otteto[i] = binaryMask.Substring(i * 8, 8);
            }
            // converte ogni gruppo binario in formato decimale e li unisce con il punto
            string subnetMask = string.Join(".", otteto.Select(s => Convert.ToInt32(s, 2)));
            return subnetMask; 
        }
    }
}
