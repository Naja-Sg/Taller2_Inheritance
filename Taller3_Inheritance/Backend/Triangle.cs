using System;
using System.Collections.Generic;
using System.Text;

namespace Backend;

public class Triangle : Rectangle
{
    //Fields

    private double _c;
    private double _h;

    //Constructor

    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        C = c;
        H = h;
    }


    //Properties

    public double C 
    { 
        get => _c; 
        set => _c = ValidateC(value); 
    }
    public double H 
    { 
        get => _h; 
        set => _h = ValidateH(value); 
    }

    //Public Methods

    public override double GetArea()
    {
        double area = (B * H) / 2;
        return area;
    }

    public override double GetPerimeter()
    {
        double perimeter = A + B + C;
        return perimeter;
    }


    //Private Methods

    private double ValidateC(double c)
    {
        if (c < 0)
        {
            throw new Exception($"The side length: {c}, is not valid."); ;
        }

        else
        {
            return c;
        }

    }

    private double ValidateH(double h)
    {
        if (h < 0)
        {
            throw new Exception($"The side length: {h}, is not valid."); ;
        }

        else
        {
            return h;
        }

    }

}
