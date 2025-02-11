using System;

public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _sectionProblem;

    public MathAssignment(string name, string topic, string bookSection, string problem) : base(name, topic)  
    {
        _textBookSection = bookSection;
        _sectionProblem = problem;
    }

    public string GetHomeWorkList()
    {
        return $"Section {_textBookSection} Problems {_sectionProblem}";
    }
}