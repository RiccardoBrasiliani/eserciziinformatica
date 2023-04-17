using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricaTester
{
    class Rubrica:Dictionary
    {
        Dictionary<string, long> dizionario = new Dictionary<string, long>();
        string cont;

        public bool isEmpty()
        {
            if (dizionario.Count == 0)
                return true;
            else
                return false;    
        }
        public void makeEmpty()
        {
            dizionario.Clear(); 
        }
        public void insert(IComparable key, Object value)//controllo se la chiave è nulla, se lo è sollevo una eccezione
        {
            if (key == null)
                throw new Exception("IllegalArgumentException");
            if (!dizionario.ContainsKey((string)key))
                dizionario.Add((string)key, (long)value);            //se non e presente la chiave, l'aggiungo insieme al valore
            else
                dizionario[(string)key] = (long)value;                 // se è gia presente sostituisco il valore
        }
        public void remove(IComparable key)
        {
            try
            {
                dizionario.Remove((string)key);
            }
            catch
            {
                throw new Exception("DictionaryItemNotFoundException");
            }
        }
        public Object find(IComparable key)
        {
            if (dizionario.TryGetValue((string)key, out long value)) //cerca la chiave e se c'è la ritorna con value
                return value;
            else
                throw new Exception("DictionaryItemNotFoundException");
        }
        public string toString()
        {
            cont = "";
            if (dizionario.Count > 0)
                foreach (KeyValuePair<string, long> key in dizionario)  
                    cont += key.Key + " : " + key.Value.ToString() + "\n"; //aggiungo alla stringa contenuto i valori che prendo dal dizionario
            else throw new Exception();
            return cont;
        }


        private class Pair
        {
            public Pair(string aName, long aPhone)
            {
                name = aName;
                phone = aPhone;
            }
            /*
              Restituisce una stringa contenente
              - la nome, "name"
              - un carattere di separazione ( : )
              - il numero telefonico, "phone"
          */
            public string getName()
            { return name; }
            public long getPhone()
            { return phone; }
            public string toString()
            { return name + " : " + phone; } 
            private string name;
            private long phone;
        }
    }
}

