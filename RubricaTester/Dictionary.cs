using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricaTester
{
    interface Dictionary
    {
        /*
        verifica se il dizionario contiene almeno una coppia chiave/valore
    */
        bool isEmpty();

        /*
            svuota il dizionario
        */
        void makeEmpty();

        /*
         Inserisce un elemento nel dizionario. L'inserimento va sempre a buon fine.
         Se la chiave non esiste la coppia key/value viene aggiunta al dizionario; 
         se la chiave esiste gia' il valore ad essa associato viene sovrascritto 
         con il nuovo valore; se key e` null viene lanciata IllegalArgumentException
        */
        void insert(IComparable key, Object value);

        /*
         Rimuove dal dizionario l'elemento specificato dalla chiave key
         Se la chiave non esiste viene lanciata DictionaryItemNotFoundException 
        */
        void remove(IComparable key);

        /*
         Cerca nel dizionario l'elemento specificato dalla chiave key
         La ricerca per chiave restituisce soltanto il valore ad essa associato
         Se la chiave non esiste viene lanciata DictionaryItemNotFoundException
        */
        Object find(IComparable key);
    }
}
