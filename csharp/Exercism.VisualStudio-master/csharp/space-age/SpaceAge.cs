using System;

public class SpaceAge
{
    long seconds;
    public SpaceAge(long seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth()
    {
        return Math.Round(seconds / (3600.0 * 24.0 * 365.25),2);
    }

    public double OnMercury()
    {
        return Math.Round(seconds / (3600.0 * 24.0 * 365.25 * 0.2408467), 2);
    }

    public double OnVenus()
    {
        return Math.Round(seconds / (3600.0 * 24.0 * 365.25 * 0.61519726), 2);
    }

    public double OnMars()
    {
        return Math.Round(seconds / (3600.0 * 24.0 * 365.25 * 1.8808158), 2);
    }

    public double OnJupiter()
    {
        return Math.Round(seconds / (3600.0 * 24.0 * 365.25 * 11.862615), 2);
    }

    public double OnSaturn()
    {
        return Math.Round(seconds / (3600.0 * 24.0 * 365.25 * 29.44749), 2);
    }

    public double OnUranus()
    {
        return Math.Round(seconds / (3600.0 * 24.0 * 365.25 * 84.016846), 2);
    }

    public double OnNeptune()
    {
        return Math.Round(seconds / (3600.0 * 24.0 * 365.25 * 164.79132), 2);
    }
}