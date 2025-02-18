class Cycling : Activity
{
    private double Speed;

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return Speed * _duration / 60;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }
}
