public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points; // i change it to an int because how i'll save the data i don't need it to be a str (JSON file)

    public int Points => _points; // I created this to not make more complicated the code and protect the data points
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool isComplete();
    public virtual string GetDetailsString()
    {
        return "string";
    }
    public abstract string GetStringRepresentation();

    public virtual string GetName()
    {
        return _shortName;
    }


}