public abstract class PizzaDecorator : IPizza
{
    private IPizza _pizza;

    public PizzaDecorator(IPizza pizza) =>  _pizza = pizza;
    
    public virtual int GetPrice() => _pizza.GetPrice();
}