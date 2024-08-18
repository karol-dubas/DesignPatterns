using System.Collections.Generic;

namespace Builder;

public class BuilderTwo : IBuilder
{
    private readonly List<string> _products = new();

    public void BuildA()
    {
        _products.Add("2A");
    }

    public void BuildB()
    {
        _products.Add("2B");
    }

    public void BuildC()
    {
        _products.Add("2C");
    }
}