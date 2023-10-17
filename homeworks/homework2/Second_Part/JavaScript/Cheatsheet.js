//Array or List

let numeri = [1, 2, 3, 4, 5]; //Dichiarazione di un array

let arrayVuoto = new Array(); //Dichiarazione di un array vuoto

let array = new Array('a', 'b', 'c'); //Dichiarazione di un array di lettere

let stringa = 'ciao';
let arrayDaStringa = Array.from(stringa); //Inserire una stringa dentro ad un array
// arrayDaStringa diventa ['c', 'i', 'a', 'o']

let miscArray = [1, 'due', { nome: 'John' }, [4, 5, 6]]; //Gli array possono contenere dati misti

let arr = [1, 2, 3];
arr.push(4); //Aggiungi un elemento all'array
// arr diventa [1, 2, 3, 4]

let arr1 = [1, 2, 3];
arr.pop(); //Togli un elemento dall'array
// arr diventa [1, 2]

let arr3 = [2, 3, 4];
arr.unshift(1); //Aggiunge uno o più elementi all'inizio dell'array
// arr diventa [1, 2, 3, 4]

let arr4 = [1, 2, 3];
arr.shift(); //Rimuove il primo elemento dall'array
// arr diventa [2, 3]

let arr5 = [1, 2];
let arr6 = [3, 4];
let arr7 = arr5.concat(arr6); //Contatena due array
// arr3 diventa [1, 2, 3, 4]

let arr8 = [1, 2, 3, 4, 5];
let subArray = arr8.slice(1, 4); //Ottieni il sotto array con i valori dalla posizione x alla posizione y
// subArray diventa [2, 3, 4]

let arr9 = [1, 2, 3, 4, 5];
arr9.splice(2, 2, 'a', 'b'); //Modifica l'array rimuovendo, sostituendo o aggiungendo elementi
// arr diventa [1, 2, 'a', 'b', 5]

let arr10 = [1, 2, 3];
arr.forEach(function(element) { //Ciclo che scorre tutti gli elementi dell'array
    console.log(element);
    break; //Interrompe il ciclo
});
// Stampa: 1, 2, 3

let arr11 = [1, 2, 3];
let squared = arr11.map(function(element) { //Modifica gli elementi dell'array in base alla funzione specificata
    return element * element;
});
// squared diventa [1, 4, 9]

let arr12 = [1, 2, 3, 4, 5];
let evenNumbers = arr12.filter(function(element) { //Crea un nuovo array con i soli elementi che rispettano le condizioni del filtro
    return element % 2 === 0;
});
// evenNumbers diventa [2, 4]

///////////////////////////////////////////////////
//Sorted List

class SortedList{

    constructor(){
        this.items = [];
    }

    inserisciOrdinato(lista, elemento) {
        let posizione = 0;
        while (posizione < lista.length && lista[posizione] < elemento) {
            posizione++;
        }
        lista.splice(posizione, 0, elemento);
    }

    //Rimozione di un valore
    rimuoviDaOrdinato(lista, elemento) {
        const posizione = lista.indexOf(elemento);
        if (posizione !== -1) {
            lista.splice(posizione, 1);
        }
    }

    //Ricerca di un elemento 
    ricercaBinaria(lista, elemento) {
        let inizio = 0;
        let fine = lista.length - 1;

        while (inizio <= fine) {
            const medio = Math.floor((inizio + fine) / 2);
            if (lista[medio] === elemento) {
                return medio; //Elemento trovato
            } else if (lista[medio] < elemento) {
                inizio = medio + 1;
            } else {
                fine = medio - 1;
            }
        }
        return -1; //Elemento non trovato
    }
}

//Iterazione su sorted list
sortedList.forEach(function(elemento) {
    console.log(elemento);
});

const elemento = sortedList[2]; //Accedi al terzo elemento (5)

//////////////////////////////////
//Dizionari

//Creazione di un dizionario
const dizionario = {
    chiave1: 'valore1',
    chiave2: 'valore2',
    chiave3: 'valore3'
};

console.log(dizionario.chiave1); //Stampa 'valore1'

//Modifica dei valori
dizionario.chiave2 = 'nuovoValore';
console.log(dizionario.chiave2); //Stampa 'nuovoValore'

//Aggiunta nuove coppie chiave-valore
dizionario.nuovaChiave = 'nuovoValore';

//Verifica l'esistenza di una data chiave
const chiaveEsiste = 'nuovaChiave' in dizionario; //Restituisce true

//Eliminazione di coppie chiave-valore
delete dizionario.chiave3;

//Iterazione sui dizionari
for (const chiave in dizionario) {
    console.log(chiave, dizionario[chiave]);
}

//Ottenere un array di chiavi e uno di valori
const chiavi = Object.keys(dizionario); //Restituisce un array di chiavi
const valori = Object.values(dizionario); //Restituisce un array di valori

//Ottenere il numero di coppie chiavi-valore
const numeroDiCoppie = Object.keys(dizionario).length; //Restituisce il numero di coppie chiave-valore

///////////////////////////////////////
//Hashset

class HashSet {
    constructor() {
      this.items = {};
    }
  
    //Aggiungi un elemento all'insieme
    add(element) {
      if (!this.has(element)) {
        this.items[element] = element;
        return true;
      }
      return false;
    }
  
    //Rimuovi un elemento dall'insieme
    delete(element) {
      if (this.has(element)) {
        delete this.items[element];
        return true;
      }
      return false;
    }
  
    //Verifica se un elemento esiste nell'insieme
    has(element) {
      return this.items.hasOwnProperty(element);
    }
  
    //Restituisci tutti gli elementi dell'insieme come un array
    toArray() {
      return Object.values(this.items);
    }
  
    //Restituisci la dimensione dell'insieme
    size() {
      return Object.keys(this.items).length;
    }
  
    //Svuota l'insieme
    clear() {
      this.items = {};
    }
}

//////////////////////////////////////
//SortedSet
class SortedSet {
    constructor() {
      this.items = [];
    }
  
    //Aggiungi un elemento al set in modo ordinato
    add(element) {
      if (!this.has(element)) {
        this.items.push(element);
        this.items.sort((a, b) => a - b); //Ordina l'array in modo crescente
        return true;
      }
      return false;
    }
  
    //Rimuovi un elemento dal set
    delete(element) {
      const index = this.items.indexOf(element);
      if (index !== -1) {
        this.items.splice(index, 1);
        return true;
      }
      return false;
    }
  
    //Verifica se un elemento esiste nel set
    has(element) {
      return this.items.includes(element);
    }
  
    //Restituisci tutti gli elementi del set
    toArray() {
      return [...this.items];
    }
  
    //Restituisci la dimensione del set
    size() {
      return this.items.length;
    }
  
    //Svuota il set
    clear() {
      this.items = [];
    }
  }
  
//////////////////////////////////////
//Queue

class Queue {
    constructor() {
        this.items = [];
    }

    //Aggiungi un elemento alla coda (enqueue)
    enqueue(element) {
        this.items.push(element);
    }

    //Rimuovi il primo elemento dalla coda (dequeue)
    dequeue() {
        if (this.isEmpty()) {
            return 'La coda è vuota';
        }
        return this.items.shift();
    }

    //Verifica se la coda è vuota
    isEmpty() {
        return this.items.length === 0;
    }

    //Restituisci il numero di elementi nella coda
    size() {
        return this.items.length;
    }

    isEmpty(quene) {
        return queueMicrotask.length === 0;
    }
}

//Svuota la coda
coda.length = 0;

//Conversione da array a coda
const array = [1, 2, 3, 4];
const coda = array.slice();

//Conversione da coda a array
const coda = [1, 2, 3, 4];
const array = coda.slice();

///////////////////////////////////////////////
//Stack

//Creazione dello stack
class Stack {
    constructor() {
        this.items = [];
    }

    //Aggiungi un elemento alla stack (push)
    push(element) {
        this.items.push(element);
    }

    //Rimuovi l'ultimo elemento dalla stack (pop)
    pop() {
        if (this.isEmpty()) {
            return 'La stack è vuota';
        }
        return this.items.pop();
    }

    //Verifica se la stack è vuota
    isEmpty() {
        return this.items.length === 0;
    }

    //Restituisci il numero di elementi nella stack
    size() {
        return this.items.length;
    }
}

/////////////////////////////////////////
//Linkedlist

class Node {
    constructor(data) {
        this.data = data;
        this.next = null;
    }
}

class LinkedList {
    constructor() {
        this.head = null;
    }

    //Aggiungere un elemento alla fine della lista collegata
    append(data) {
        const newNode = new Node(data);
        if (!this.head) {
            this.head = newNode;
        } else {
            let current = this.head;
            while (current.next) {
                current = current.next;
            }
            current.next = newNode;
        }
    }

    //Visualizzare la lista collegata
    display() {
        let current = this.head;
        while (current) {
            console.log(current.data);
            current = current.next;
        }
    }

    //Cercare un elemento nella lista collegata
    find(data) {
        let current = this.head;
        while (current) {
            if (current.data === data) {
                return true;
            }
            current = current.next;
        }
        return false;
    }

    //Eliminare un elemento dalla lista collegata
    delete(data) {
        if (!this.head) {
            return;
        }
        if (this.head.data === data) {
            this.head = this.head.next;
            return;
        }
        let current = this.head;
        while (current.next) {
            if (current.next.data === data) {
                current.next = current.next.next;
                return;
            }
            current = current.next;
        }
    }

    //Inserire un elemento in una specifica posizione
    insertAt(data, position) {
        const newNode = new Node(data);
        if (position === 0) {
            newNode.next = this.head;
            this.head = newNode;
        } else {
            let current = this.head;
            let index = 0;
            while (current && index < position - 1) {
                current = current.next;
                index++;
            }
            if (current) {
                newNode.next = current.next;
                current.next = newNode;
            }
        }
    }

    //Rimozione dell'elemento nella posizione specificata
    removeAt(position) {
        if (position === 0) {
            this.head = this.head ? this.head.next : null;
        } else {
            let current = this.head;
            let index = 0;
            while (current && index < position - 1) {
                current = current.next;
                index++;
            }
            if (current && current.next) {
                current.next = current.next.next;
            }
        }
    }

    //Controllare se la linkedlist è vuota
    isEmpty() {
        return this.head === null;
    }

    //Ottenere l'ultimo elemento della linkedlist
    getLast() {
        let current = this.head;
        while (current && current.next) {
            current = current.next;
        }
        return current ? current.data : null;
    }
}


