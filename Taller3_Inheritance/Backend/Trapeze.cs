using System;
using System.Collections.Generic;
using System.Text;

namespace Backend;

public class Trapeze : Triangle
{

    //Fields

    private double _d;

    //Constructor
    public Trapeze(string name, double a, double b, double c, double h, double d) : base(name, a, b, c, h)
    {
        D = d;
    }


    //Properties

    public double D 
    { 
        get => _d; 
        set => _d = ValidateD(value); 
    }

    //Public Methods

    public override double GetArea()
    {
        double area = (B + D) * (H / 2);
        return area;
    }

    public override double GetPerimeter()
    {
        double perimeter = A + B + C + D;
        return perimeter;
    }

    //Private Methods

    private double ValidateD(double d)
    {
        if (d < 0)
        {
            throw new Exception($"The side length: {d}, is not valid."); ;
        }

        else
        {
            return d;
        }

    }


}
