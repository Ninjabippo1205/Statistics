Ecco il codice C# con commenti dettagliati che spiegano cosa fa ogni singola funzione:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Array
        int[] array = {1,2,3};
        int[] array1 = new int[10];

        array1[9] = 5;

////////////////////////////////////////////////////////
        //List
        List<int> numeri = new List<int> { 1, 2, 3, 4, 5 }; //Dichiarazione di una lista di interi.

        List<object> miscArray = new List<object> { 1, "due", new { nome = "John" }, new List<int> { 4, 5, 6 } }; //Lista con dati misti.

        List<int> arr = new List<int> { 1, 2, 3 };
        arr.Add(4); //Aggiunta di un elemento alla fine della lista.

        List<int> arr1 = new List<int> { 1, 2, 3 };
        arr1.RemoveAt(arr1.Count - 1); //Rimozione dell'ultimo elemento dalla lista.

        List<int> arr3 = new List<int> { 2, 3, 4 };
        arr3.Insert(0, 1); //Aggiunta di un elemento in una posizione specifica.

        List<int> arr4 = new List<int> { 1, 2, 3 };
        arr4.RemoveAt(0); //Rimozione del primo elemento dalla lista.

        List<int> arr5 = new List<int> { 1, 2 };
        List<int> arr6 = new List<int> { 3, 4 };
        List<int> arr7 = new List<int>(arr5);
        arr7.AddRange(arr6); //Concatenazione di due liste.

        List<int> arr8 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> subArray = arr8.GetRange(1, 3); //Estrazione di un sottoinsieme di elementi.

        List<int> arr9 = new List<int> { 1, 2, 3, 4, 5 };
        arr9.RemoveRange(2, 2); //Rimozione e aggiunta di elementi specifici.

        List<int> arr10 = new List<int> { 1, 2, 3 };
        foreach (var element in arr10)
        {
            Console.WriteLine(element); //Ciclo per scorrere gli elementi e stamparli.
            break; //Interruzione del ciclo.
        }

        List<int> arr11 = new List<int> { 1, 2, 3 };
        List<int> squared = arr11.ConvertAll(element => element * element); //Modifica degli elementi della lista.

        List<int> arr12 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> evenNumbers = arr12.FindAll(element => element % 2 == 0); //Creazione di una nuova lista con elementi che soddisfano una condizione.
////////////////////////////////////////////////////////////////
        //LinkedList
        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.AddLast(1);

        LinkedListNode<int> node = linkedList.First;
        while (node != null)
        {
            Console.WriteLine(node.Value); //Iterazione attraverso la lista collegata e stampa degli elementi.
            node = node.Next;
        }

        LinkedList<int> list1 = new LinkedList<int>();
        LinkedList<int> list2 = new LinkedList<int>();
        LinkedList<int> mergedList = new LinkedList<int>(list1.Concat(list2)); //Unione di due liste collegate.
//////////////////////////////////////////////////
        //Sorted List
        SortedList<int, string> sortedList = new SortedList<int, string>();
        sortedList.Add(1, "One");
        sortedList.Add(2, "Two");
        sortedList.Add(3, "Three"); //Creazione di un dizionario ordinato.

        int element = sortedList.Values[2]; //Accesso a un elemento in base all'indice.
///////////////////////////////////////////////////
        //Dizionari
        Dictionary<string, string> dizionario = new Dictionary<string, string>
        {
            { "chiave1", "valore1" },
            { "chiave2", "valore2" },
            { "chiave3", "valore3" }
        };

        Console.WriteLine(dizionario["chiave1"]); //Accesso a un valore mediante chiave.

        dizionario["chiave2"] = "nuovoValore"; //Modifica di un valore.

        dizionario["nuovaChiave"] = "nuovoValore"; //Aggiunta di una nuova coppia chiave-valore.

        bool chiaveEsiste = dizionario.ContainsKey("nuovaChiave"); //Verifica dell'esistenza di una chiave.

        dizionario.Remove("chiave3"); //Rimozione di una coppia chiave-valore.

        foreach (var pair in dizionario)
        {
            Console.WriteLine(pair.Key + ": " + pair.Value); //Iterazione sui dizionari e stampa delle coppie chiave-valore.
        }

        string[] chiavi = dizionario.Keys.ToArray(); //Estrazione di un array di chiavi.
        string[] valori = dizionario.Values.ToArray(); //Estrazione di un array di valori.
        int numeroDiCoppie = dizionario.Count; //Calcolo del numero di coppie chiave-valore.
///////////////////////////////////////////////////////////
        //HashSet
        HashSet<object> mioSet = new HashSet<object>();
        mioSet.Add(1);
        mioSet.Add("stringa");
        mioSet.Add(new { oggetto = true });

        mioSet.Add(1);
        mioSet.Add(2);
        mioSet.Add(1); //Aggiunta di elementi a un insieme.

        int dimensione = mioSet.Count; //Calcolo della dimensione dell'insieme.

        mioSet.Remove(1); //Rimozione di un elemento dall'insieme.

        bool esiste = mioSet.Contains(1); //Verifica dell'esistenza di un elemento.

        foreach (var elemento in mioSet)
        {
            Console.WriteLine(elemento); //Iterazione sull'insieme e stampa degli elementi.
        }

        object[] arrayDaSet = mioSet.ToArray(); //Conversione dell'insieme in un array.

/////////////////////////////////////////////////////////////
        //Queue
        Queue<object> coda = new Queue<object>();
        coda.Enqueue(1);
        coda.Enqueue("stringa");
        coda.Enqueue(new { oggetto = true });

        object elementoRimosso = coda.Dequeue(); //Rimozione del primo elemento dalla coda.
        int dimensioneCoda = coda.Count; //Calcolo della dimensione della coda.
        bool codaVuota = coda.Count == 0; //Verifica se la coda è vuota.

        coda.Clear(); //Svuotamento della coda.
        List<object> codaDaArray = new List<object>(new object[] { 1, 2, 3, 4 });
        object elementoDallaCoda = codaDaArray.Dequeue(); //Rimozione del primo elemento dalla coda.

//////////////////////////////////////////////////////////
        //Stack
        Stack<object> stack = new Stack<object>();
        stack.Push(1);
        stack.Push("stringa");
        stack.Push(new { oggetto = true });

        object elementoRimossoDalStack = stack.Pop(); //Rimozione dell'ultimo elemento dallo stack.
        int dimensioneStack = stack.Count; //Calcolo della dimensione dello stack.
        bool stackVuoto = stack.Count == 0; //Verifica se lo stack è vuoto.
    }
}