using System.Collections.Generic;

namespace PacktLibrary;

public class Person
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public List<Person> Children = new ();
    public static decimal InterestRate;
}
public class TextAndNumber
{
    public string Text { get; set; }
    public decimal Number { get; set; }
}
public class LifeTheUniverseAndEverything
{
    public TextAndNumber GetTheData() => new TextAndNumber
    {
        Text = "What's the meaning of life?",
        Number = 42
    };
    public (string Text, int Number) GetTheDataTuple() => (Text: "What's the meaning of life?", Number: 42);
    
}

public record ImmutableVehicle
{
    public int Wheels { get; init; }
    public string Color { get; init; }
    public string Brand { get; init; }
}