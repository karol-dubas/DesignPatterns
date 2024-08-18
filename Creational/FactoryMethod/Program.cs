namespace FactoryMethod;

public class Program
{
    public static void Main()
    {
        Dialog randomDialog = Random.Shared.Next(2) == 1 ? new WindowsDialog() : new MacDialog();
        randomDialog.Render();
    }
}