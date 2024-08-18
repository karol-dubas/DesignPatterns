namespace FactoryMethod;

public class WindowsDialog : Dialog
{
    public override IButton CreateButton() => new WindowsButton();
}