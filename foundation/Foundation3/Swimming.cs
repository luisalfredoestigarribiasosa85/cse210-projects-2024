using System;

public class Swimming : Activity
{
    private int _laps;
    private const double METERS_PER_LAP = 50;
    private const double METERS_TO_MILES = 0.000621371;

    public Swimming(DateTime date, int minutes, int laps) 
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * METERS_PER_LAP * METERS_TO_MILES;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}
