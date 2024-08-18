using System;

namespace AbstractFactory.Models;

public class MacCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering mac checkbox");
    }
}