using System;
using System.Collections.Generic;
using System.Text;

namespace Backend;

public class Rectangle : Square
{

    //Fields

    private double _b;

    // Constructors
    public Rectangle(string name, double a, double b) : base(name, a)
        
    {
        A = a;
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
        double area = A * B;
        return area;
    }

    public override double GetPerimeter()
    {
        double perimeter = 2 * (A + B);
        return perimeter;
    }

    //Private methods

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
