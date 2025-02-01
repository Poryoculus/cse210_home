using System;
using System.Diagnostics;

public class Fraction 
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int userTop)
    {
        _top = userTop;
        _bottom = 1;
    }
    public Fraction(int userTop, int userBottom)
    {
        _top = userTop;
        _bottom = userBottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int Numerator)
    {
        _top = Numerator;
    }

     public int GetBottom()
    {
        return _top;
    }

    public void SetBottom(int Denominator)
    {
        _bottom = Denominator;
    }

    public string GetFractionString()
    {
        string strTop = _top.ToString();
        string strBottom = _bottom.ToString();
        return $"{strTop}/{strBottom}";
    }
    public double GetDecimalValue()
    {
        
        return (double) _top / _bottom;
    }


}