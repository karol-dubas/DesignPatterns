using AbstractFactory.Models;

namespace AbstractFactory.Factories;

public class MacFactory : IGuiFactory
{
    public IButton CreateButton() => new MacButton();

    public ICheckbox CreateCheckbox() => new MacCheckbox();
}