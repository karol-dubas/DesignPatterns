namespace AbstractFactory.Factories;

public interface IGuiFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}