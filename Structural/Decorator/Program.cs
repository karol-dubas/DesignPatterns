using System;

namespace Decorator;

// Decorator allows to extend the behavior of objects by wrapping them in special objects

public class Program
{
    static void Main()
    {
        IPizza randomBasePizza = Random.Shared.Next(2) == 1 ? new SmallPizza() : new LargePizza();

        var pizza1 = new CheesePizzaDecorator(randomBasePizza);
        var pizza2 = new SalamiPizzaDecorator(pizza1);
        var pizza3 = new SalamiPizzaDecorator(pizza2);

        int price = pizza3.GetPrice();
        Console.WriteLine(price);
    } 
}