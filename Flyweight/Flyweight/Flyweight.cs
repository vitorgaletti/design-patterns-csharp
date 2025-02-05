using Newtonsoft.Json;

namespace Flyweight;

public class Flyweight
{
    private Car _sharedState;

    public Flyweight(Car car)
    {
        this._sharedState = car;
    }
    
    public void Operation(Car uniqueState)
    {
        var s = JsonConvert.SerializeObject(this._sharedState);
        var u = JsonConvert.SerializeObject(uniqueState);
        Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
    }
}