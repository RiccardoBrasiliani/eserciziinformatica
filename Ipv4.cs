
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
            IPAddressGenerator generator = new IPAddressGenerator();
            string ipAddress = generator.GenerateIPAddress();
            string subnetMask = generator.GenerateSubnetMask();
            Console.WriteLine("Indirizzo IP: {0}", ipAddress);
            Console.WriteLine("Subnet Mask: {0}");
            Console.ReadLine();
        }
    

public class IPAddressGenerator
{
    private Random random;

    public IPAddressGenerator()
    {
        random = new Random();
    }

    public string GenerateIPAddress()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 4; i++)
        {
            sb.Append(random.Next(256));
            if (i != 3) sb.Append(".");
        }
        return sb.ToString();
    }

    public string GenerateSubnetMask()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 4; i++)
        {
            sb.Append(random.Next(256));
            if (i != 3) sb.Append(".");
        }
        return sb.ToString();
     }
}
