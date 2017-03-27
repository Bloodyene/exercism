using System;
using System.Collections.Generic;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class Garden
{
    List<string> children = new List<string> { "Alice", "Bob","Charlie", "David",
        "Eve", "Fred", "Ginny", "Harriet", "Ileana", "Joseph", "Kincaid", "Larry"};
    string[] windowSills;
    public Garden(IEnumerable<string> children, string windowSills)
    {
        this.children = new List<string>();
        foreach (var i in children)
        {
            this.children.Add(i);
        }
        this.children.Sort();
        this.windowSills = windowSills.Split('\n');
    }

    public IEnumerable<Plant> GetPlants(string child)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static Garden DefaultGarden(string windowSills)
    {
        return new Garden(, windowSills);
    }
}
//- Alice, Bob, Charlie, David,
//- Eve, Fred, Ginny, Harriet,
//- Ileana, Joseph, Kincaid, and Larry.