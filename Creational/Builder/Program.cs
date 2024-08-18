namespace Builder;

class Program
{
    static void Main()
    {
        var director = new Director();

        var builderOne = new BuilderOne();
        director.Builder = builderOne;
        
        director.BuildMinimal();
        var productsOne = builderOne.GetProducts();
        
        var builderTwo = new BuilderTwo();
        director.Builder = builderTwo;
        director.BuildFull();
    }
}