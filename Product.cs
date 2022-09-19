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
    private float price;
    private uint iva;

    public Product(string newName, string newDescription, double newPrice)
    {
        this.id_code = this.SetCode();
        this.SetName(newName);
        this.SetDescription(newDescription);
        this.SetPrice(newPrice);
        this.iva = 22;
    }

    public Product(string newName, string newDescription, double newPrice, uint newIva)
    {
        this.id_code = this.SetCode();
        this.SetName(newName);
        this.SetDescription(newDescription);
        this.SetPrice(newPrice);
        this.SetIva(newIva);
    }

    public uint GetCode()
    {
        return this.id_code;
    }

    private uint SetCode()
    {
        Random rand = new Random();
        return Convert.ToUInt32(rand.Next(1, 99999999));
    }

    public string GetName()
    {
        return this.name;
    }

    public void SetName(string newName)
    {
        if (newName.Trim(' ') != "")
        {
            this.name = newName;
        }
    }

    public string GetDescription()
    {
        return this.description;
    }

    public void SetDescription(string newDescription)
    {
        if (newDescription.Trim(' ') != "")
        {
            this.description = newDescription;
        }
    }

    public float GetPrice()
    {
        return this.price;
    }

    public float GetFullPrice()
    {
        float fullPrice = this.price + (float)((this.iva * this.price) / 100);
        return fullPrice;
    }

    public void SetPrice(double newPrice)
    {
        if(newPrice > 0)
        {
            this.price = (float)newPrice;
        }
    }
    public uint GetIva()
    {
        return this.iva;
    }

    public void SetIva(uint newIva)
    {
        if(newIva != 0)
        {
            this.iva = newIva;
        }
    }
}