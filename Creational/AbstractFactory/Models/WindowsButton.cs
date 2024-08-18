using System;

namespace AbstractFactory.Models;

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering windows button");
    }
}