class Running : Activity
{
    private double Distance;

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        Distance = distance;
    }

    public override double GetDistance() 
    {
        return Distance;
    }
    public override double GetSpeed() 
    {
        return (Distance / _duration ) * 60;
    }

    public override double GetPace()
    {
        return _duration / Distance;
    }
}