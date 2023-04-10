using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour
{
    public class TourOperator
    {                                           /*implementa Dizzionario*/ 

        private string ClientCodeProsiimo;          //dichiaro le variabili del codice cliente
        char carCodice;
        int Numerocodice;
        Dictionary<string, Client> Dixionari = new Dictionary<string, Client>();         
        public TourOperator(string initialClientCode)       //costruttore che prende come parametro in input il codice
        {
            string temp;
            ClientCodeProsiimo = initialClientCode;
            carCodice = ClientCodeProsiimo[0];
            temp = ClientCodeProsiimo[1].ToString() + ClientCodeProsiimo[2].ToString() + ClientCodeProsiimo[3].ToString();
            Numerocodice = Convert.ToInt32(temp);
        }
        public string toString()        //metodo per la visualizzare elementi 
        {
            string tmp = "";
            if (Dixionari.Count > 0)
                foreach (KeyValuePair<string, Client> key in Dixionari)
                    tmp += key.Key + ":" + key.Value.ToString() + "\n";
            else throw new Exception();
            return tmp;
        }
        public void add(string nome, string dest)       //costruisco il metodo per aggiungere al dizionario
        {
            Client cliente = new Client(nome, dest);
            Dixionari.Add(ClientCodeProsiimo, cliente);
            incrementoCode();

        }
        private void incrementoCode()           //metodo per incrementare il codice
        {
            int temp; //variabile temporanea per controllo dell'if
            if (Numerocodice < 999)
            {
                Numerocodice++;
            }
            else
            {

                Numerocodice = 0;
                temp = carCodice;
                temp++;
                carCodice = Convert.ToChar(temp);

            }
            ClientCodeProsiimo = carCodice + Numerocodice.ToString();
        }
        public static void Main(string[] args)
        {
            TourOperator Tour;
            string tmp;
            string[] temp;             
            bool verifica = false;
            do
            {

                Console.WriteLine("Inserisci il codice , del formato indicato qua di seguito ---->%Cnnn%");

                tmp = Console.ReadLine();
                if (tmp.Length == 4)
                    if (char.IsUpper(tmp[0]) && char.IsDigit(tmp[1]) && char.IsDigit(tmp[2]) && char.IsDigit(tmp[3])) //faccio controlli
                    {
                        verifica = true;                  
                    }
                    else
                    {
                        Console.WriteLine("Rispettare il formato");
                    }
                else
                {
                    Console.WriteLine("Rispettare il formato ");
                }
            } while (verifica == false);

            Tour = new TourOperator(tmp);
            while (true)
            {
                Console.WriteLine("Opzioni che puoi scegliere");
                Console.WriteLine("[1]Inserisci.");                //operazioni che si possono fare a scelta dell'utente
                Console.WriteLine("[2]visualizza.");
                tmp = Console.ReadLine();
                switch (tmp)
                {
                    case "1"://parte di inserimento
                        Console.WriteLine("Inserisci nome e destinazione in questo formato----> %nome:destinazione%"); 
                        tmp = Console.ReadLine();                   
                        try
                        {
                            temp = tmp.Split(':');
                            Tour.add(temp[0], temp[1]);
                        }
                        catch
                        {
                            Console.WriteLine("Rispettare il formato");
                        }

                        break;
                    case "2": //case 2 per visualizzare 
                        try
                        {
                            Console.WriteLine(Tour.toString());
                        }
                        catch                                     
                        {
                            Console.WriteLine("Nessun elemento presente");
                        }
                        break;

                }

            }



        }
        // classi interne
        private class Client
        {
            String name; 
            String dest; 
            public Client(String aName, String aDest)
            {
                name = aName;
                dest = aDest;
            }
            public override string ToString()
            {
                return name + ":" + dest;
            }
        }
        private class Coppia 
        {
            String codice;
            Client cliente;
            Coppia(String aCode, Client aClient)
            {
                codice = aCode;
                cliente = aClient;
            }
            
        }
    }
}
