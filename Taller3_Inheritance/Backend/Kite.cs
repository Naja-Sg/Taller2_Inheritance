using System;
using System.Collections.Generic;
using System.Text;

namespace Backend;

public class Kite : Rhombus
{

    //Fields

    private double _b;

    //Constructors
    public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
    {
        B = b;
    }


    //Properties

    public double B 
    {
        get => _b; 
        set => _b = ValidateB(value); 
    }

    //Public Methods

        public override double GetArea()
    {
        double area = (D1 *  D2)/2;
        return area;
    }

    public override double GetPerimeter()
    {
        double perimeter = 2 * (A+B);
        return perimeter;
    }

    //Private Methods

    private double ValidateB(double b)
    {
        if (b < 0)
        {
            throw new Exception($"The side length: {b}, is not valid."); ;
        }

        else
        {
            return b;
        }

    }
}
