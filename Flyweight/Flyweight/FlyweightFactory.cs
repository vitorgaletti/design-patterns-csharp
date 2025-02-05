namespace Flyweight;

public class FlyweightFactory
{
    private List<Tuple<Flyweight, string>> flyweights = [];

    public FlyweightFactory(params Car[] args)
    {
        foreach (var elem in args)
        {
            flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), this.getKey(elem)));
        }
    }

    private string getKey(Car key)
    {
        List<string> elements = [];
        
        elements.Add(key.Model);
        elements.Add(key.Color);
        elements.Add(key.Company);
        
        if (key is { Owner: not null, Number: not null })
        {
            elements.Add(key.Owner);
            elements.Add(key.Number);
        }
        
        elements.Sort();
        
        return string.Join("_", elements);
    }

    public Flyweight GetFlyweight(Car sharedState)
    {
        var key = this.getKey(sharedState);

        if (flyweights.Where(t => t.Item2.Equals(key)).Count() == 0)
        {
            Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
            this.flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
        }
        else
        {
            Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
        }

        return flyweights.FirstOrDefault(t => t.Item2.Equals(key)).Item1;
    }

    public void listFlyweights()
    {
        var count = flyweights.Count;
        Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
        foreach (var flyweight in flyweights)
        {
            Console.WriteLine(flyweight.Item2);
        }
    }
}