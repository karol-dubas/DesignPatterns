using AbstractFactory;
using AbstractFactory.Factories;

namespace AbstractFactory;

public class Application
{
    private readonly IGuiFactory _guiFactory;
    
    public Application(IGuiFactory guiFactory) => _guiFactory = guiFactory; 

    public void CreateUi()
    {
        var button = _guiFactory.CreateButton();
        button.Render();

        var checkbox = _guiFactory.CreateCheckbox();
        checkbox.Render();
    }
}