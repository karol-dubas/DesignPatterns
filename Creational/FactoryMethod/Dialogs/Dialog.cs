namespace FactoryMethod;

public abstract class Dialog
{
    public abstract IButton CreateButton();

    public void Render()
    {
        var button = CreateButton();
        button.OnClick();
        button.Render();
    }
}