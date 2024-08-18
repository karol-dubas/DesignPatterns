using System;
using AbstractFactory.Factories;

namespace AbstractFactory;

internal class Program
{
    // If something is created in the same way in many places, it makes sense to use one of the
    // factory patterns.

    private static void Main()
    {
        IGuiFactory randomFactory = Random.Shared.Next(2) == 1 ? new WindowsFactory() : new MacFactory();
        var app = new Application(randomFactory);
        app.CreateUi();
    }
}