//using POO.Bussines;
using POO.Bussines;

Beer erdingerBeer = new Beer("Erginger", 3, 12, 250);
var delirium = new ExpiringBeer("Delirium", 4, 8, new DateTime(2024, 12, 01), 350);
Drink drink = new Beer("Poker", 3500, 8, 750);
//drink.Quantity = 850;

//var coronaBeer = new Beer("Corona", 1.5m);
//Console.WriteLine(erdingerBeer.Name + " $ " + erdingerBeer.Price);
//Console.WriteLine(coronaBeer.Name + " $ "+ coronaBeer.Price);
//Console.WriteLine(erdingerBeer.GetInfo());
//Console.WriteLine("------------");
////Console.WriteLine(delirium.GetInfoEx());
//Console.WriteLine("------------");
//Console.WriteLine(delirium.GetInfo("A beer than caduce"));
//Console.WriteLine(delirium.GetInfo(2));
//Console.WriteLine("------------");
//Console.WriteLine("------------");
//Console.WriteLine(delirium.GetCategory());
//Console.WriteLine(erdingerBeer.SAlcohol);

Drink drinkTwo = new Wine(500);
//Show(drinkTwo);
//drinkTwo = new Beer("Erginger", 3, 12, 250);
//Show(drinkTwo);
//drinkTwo = new ExpiringBeer("Delirium", 4, 8, new DateTime(2024, 12, 01), 350);
//Show(drinkTwo);
//void Show(Drink drink) => Console.WriteLine(drinkTwo.GetCategory());
//SendSome(delirium);
//void SendSome(ISend some) 
//{
//    Console.WriteLine("------------------");
//    some.Send();
//    Console.WriteLine("------------------");
//}
//var service = new Service(100, 10);
//ISalable[] concepts = [
//    erdingerBeer,
//    delirium,
//    service
//];

//decimal GetTotal(ISalable[] concepts) 
//{
//    decimal total = 0;
//    foreach (var concept in concepts) 
//    {
//        total += concept.GetPrice();
//    }
//    return total;
//}

//Console.WriteLine("-----------------");
//Console.WriteLine(GetTotal(concepts));
//Console.WriteLine("-----------------");

var elements = new Collection<int>(3);
elements.Add(1);
elements.Add(2);
elements.Add(3);
elements.Add(4);
elements.Add(5);
Console.WriteLine("-----------------");
foreach (var element in elements.Get())
{
    Console.WriteLine(element);
}
var names = new Collection<string>(2);
names.Add("Duvan");
names.Add("Yesid");
names.Add("Vivas");
Console.WriteLine("-----------------");
foreach (var name in names.Get())
{
    Console.WriteLine(name);
}
var beers = new Collection<Beer>(2);
beers.Add(erdingerBeer);
beers.Add(delirium);
Console.WriteLine("-----------------");
foreach (var beer in beers.Get())
{
    Console.WriteLine(beer.GetInfo());
}

//static
Console.WriteLine($"Objects created: {Beer.QuantityObjects}");

Console.WriteLine($"Result: {Operations.Add(1,2)}");
Console.WriteLine($"Result: {Operations.Mul(10, 20)}");