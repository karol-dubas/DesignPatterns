using System;

namespace AbstractFactory.Models;

public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering mac button");
    }
}