using System;

public class Robot
{
    bool nameAssigned = false;
    private string name;
    private static Random r = new Random();
    public string Name
    {
        get
        {
            if (!nameAssigned)
            {
                name = "";
                name += (char)(r.Next('A', 'Z' + 1));
                name += (char)(r.Next('A', 'Z' + 1));
                name += r.Next(9);
                name += r.Next(9);
                name += r.Next(9);
                nameAssigned = true;
            }
            return name;
        }
    }

    public void Reset()
    {
        nameAssigned = false;
    }
}