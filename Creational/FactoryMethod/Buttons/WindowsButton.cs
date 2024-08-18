namespace FactoryMethod;

public class WindowsButton : IButton
{
    public void OnClick()
    {
        Console.WriteLine("Windows button click");
    }

    public void Render()
    {
        Console.WriteLine("Windows button");
    }
}