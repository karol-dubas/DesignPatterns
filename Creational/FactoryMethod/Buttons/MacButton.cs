namespace FactoryMethod;

public class MacButton : IButton
{
    public void OnClick()
    {
        Console.WriteLine("Mac button click");
    }

    public void Render()
    {
        Console.WriteLine("Mac button");
    }
}