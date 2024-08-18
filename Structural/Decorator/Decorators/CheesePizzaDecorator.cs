public class CheesePizzaDecorator : PizzaDecorator
{
    public CheesePizzaDecorator(IPizza pizza) : base(pizza) { }

    public override int GetPrice() => base.GetPrice() + 4;
}