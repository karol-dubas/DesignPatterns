namespace Builder;

public class Director
{
    public IBuilder Builder { get; set; }

    public void BuildMinimal()
    {
        Builder.BuildA();
    }

    public void BuildFull()
    {
        Builder.BuildA();
        Builder.BuildB();
        Builder.BuildC();
    }
}