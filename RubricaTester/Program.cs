using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricaTester
{
    class Program
    {
        public static void main(string[] args)
        {
            Menu();
            Console.ReadLine(); 
        }
        static void Menu()
        {
            Rubrica persona = new Rubrica();
            string nome;string numero;
            while (true)
            {
                Console.WriteLine("scegli cosa vuoi fare ");
                Console.WriteLine("[1] Inserimento");
                Console.WriteLine("[2] Rimuovi");
                Console.WriteLine("[3] Visualizza");
                Console.WriteLine("[4] Reset");
                nome = Console.ReadLine();
                switch (nome)
                {
                    case "1":
                        Console.WriteLine("Inserisci il nome dell'utente");
                        nome = Console.ReadLine();
                        Console.WriteLine("Inserisci il numero di telefono");
                        numero = Console.ReadLine();
                        if (long.TryParse(numero, out long num))
                            persona.insert(nome, num);
                        else
                            Console.WriteLine("imput errorato");
                        break;
                    case "2":
                        Console.WriteLine("Inserisci il nome dell'utente da eliminare");
                        nome = Console.ReadLine();
                        try
                        {
                            persona.remove(nome);
                        }
                        catch
                        {
                            Console.WriteLine("chiave errata");
                        }
                        break;
                    case "3":
                        try
                        {
                            Console.WriteLine(persona.toString());
                        }
                        catch
                        {
                            Console.WriteLine("Nessun elemento trovato");
                        }

                        break;
                    case "4":
                             persona.makeEmpty();
                        break;
                    default:
                        break;

                }
                Console.WriteLine("\n");
            }
        }
    }
}

        
    

