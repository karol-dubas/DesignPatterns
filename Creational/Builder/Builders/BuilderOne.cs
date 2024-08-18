using System.Collections.Generic;
using System.Linq;

namespace Builder;

public class BuilderOne : IBuilder
{
    private readonly List<string> _products = new();
    
    public void BuildA()
    {
        _products.Add("1A");
    }

    public void BuildB()
    {
        _products.Add("1B");
    }

    public void BuildC()
    {
        _products.Add("1C");
    }

    public IEnumerable<string> GetProducts()
    {
        var result = _products.ToList();
        _products.Clear();
        return result;
    }
}