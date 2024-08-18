public class SalamiPizzaDecorator : PizzaDecorator
{
    public SalamiPizzaDecorator(IPizza pizza) : base(pizza) { }

    public override int GetPrice() => base.GetPrice() + 5;
}