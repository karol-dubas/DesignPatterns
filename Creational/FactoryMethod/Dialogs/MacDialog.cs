namespace FactoryMethod;

public class MacDialog : Dialog
{
    public override IButton CreateButton() => new MacButton();
}