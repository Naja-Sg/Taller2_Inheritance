using System;
using System.Collections.Generic;
using System.Text;

namespace Backend;

public class Kite : Rhombus
{

    //Fields

    private decimal _b;

    //Constructors
    public Kite(string name, decimal a, decimal d1, decimal d2, decimal b) : base(name, a, d1, d2)
    {
        B = b;
    }


    //Properties

    public decimal B 
    {
        get => _b; 
        set => _b = ValidateB(value); 
    }

    //Public Methods

        public override decimal GetArea()
    {
        decimal area = (D1 *  D2)/2;
        return area;
    }

    public override decimal GetPerimeter()
    {
        decimal perimeter = 2 * (A+B);
        return perimeter;
    }

    //Private Methods

    private decimal ValidateB(decimal b)
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
