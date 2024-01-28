using System;

public class Fraction
{

    private int __numerator;
    private int __denominator;

    public Fraction()
    {

        __denominator = 1;
        __numerator = 1;
    }

    public Fraction(int wholeNumber)
    {
        __numerator = wholeNumber;
        __denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        __denominator = bottom;
        __numerator = top;
    }

    public string GetFraction()
    {

        string __fraction = $"{__numerator}/{__denominator}";
        return __fraction;
    }

    public double GetValue()
    {

        return (double)__numerator / (double)__denominator;
    }

}