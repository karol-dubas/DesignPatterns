using AbstractFactory.Models;

namespace AbstractFactory.Factories;

public class WindowsFactory : IGuiFactory
{
    public IButton CreateButton() => new WindowsButton();

    public ICheckbox CreateCheckbox() => new WindowsCheckbox();
}