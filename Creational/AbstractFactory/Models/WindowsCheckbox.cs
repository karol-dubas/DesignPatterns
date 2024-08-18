using System;

namespace AbstractFactory.Models;

public class WindowsCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering windows checkbox");
    }
}