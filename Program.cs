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


//Product myProduct = new Product("Pizza Margherita", "La classica pizza napoletana", 4.99);

//float myPrice = myProduct.GetPrice();

//float myFullPrice = myProduct.GetFullPrice();

//string fullProductName = myProduct.GetFullName();

//string productName = myProduct.GetName();

//myProduct.SetName("Pizza Diavola");

//myProduct.SetName("");

//string productDescription = myProduct.GetDescription();

//myProduct.SetDescription("Per gli amanti del piccante");

//myProduct.SetDescription("        ");

//myProduct.SetPrice(2);

//myProduct.SetPrice(0);

//myProduct.SetPrice(-1);

//uint productIva = myProduct.GetIva();

//myProduct.SetIva(21);

//myProduct.SetIva(0);

Water myWater = new Water("Fontenoce", "Acqua", 1.99, 22, 1.5, 7, "Bocca di Piazza");

Wine myWine = new Wine("Lambrusco", "Lambrusco Mantovano DOC", 14.99, 22, 0.75, 14, "Cantina Sociale Quistello");

try
{
    CannedFood myFood = new CannedFood("test", "test", 1.99, 22, 400, "22-10-2023", "22-09-2021");
} catch(Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine();

try
{
    CannedFood myFood = new CannedFood("test", "test", 1.99, 22, 200, "22-10-2023", "22-09-2021");
    Console.WriteLine("Prodotto creato correttamente!");
    Console.WriteLine(myFood.GetFullName());
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    Console.WriteLine(myWater.GetFullName());
    myWater.Drink(1);
    Console.WriteLine("Litri: " + myWater.Quantity);
    Console.WriteLine("Galloni: " + Water.ToGallons(myWater.Quantity));
    myWater.Drink(0.5);
    Console.WriteLine("Litri: " + myWater.Quantity);
    myWater.Fill(1);
    Console.WriteLine("Litri: " + myWater.Quantity);
    Console.WriteLine("Galloni: " + Water.ToGallons(myWater.Quantity));
    myWater.Empty();
    Console.WriteLine("Litri: " + myWater.Quantity);
    myWater.Drink(0.1);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}