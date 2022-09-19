//Creare una classe Prodotto che gestisce i prodotti dello shop.
//Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva
//Usate opportunamente i livelli di accesso (public, private):
//i costruttori,
//i metodi getter e setter
//eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.
//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)

public class Product
{
    private uint id_code;
    private string name;
    private string description;
    private uint price;
    private uint iva;

    public Product(string newName, string newDescription, uint newPrice)
    {
        Random rand = new Random();
        this.id_code = Convert.ToUInt32(rand.Next(1, 99999999));
        this.name = newName;
        this.description = newDescription;
        this.price = newPrice;
        this.iva = 22;
    }

    public Product(string newName, string newDescription, uint newPrice, uint newIva)
    {
        Random rand = new Random();
        this.id_code = Convert.ToUInt32(rand.Next(1, 99999999));
        this.name = newName;
        this.description = newDescription;
        this.price = newPrice;
        this.iva = newIva;
    }
}