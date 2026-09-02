
namespace Backend;

public class Parallelogram : Rectangle
{

    //Fields

    private double _h;

    //Constructor

    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }


    // Properties

    public double H 
    { 
        get => _h; 
        set => _h = value; 
    }

    //Public Methods

    public override double GetArea()
    {
        double area = B * H;
        return area;
    }

    public override double GetPerimeter()
    {
        double perimeter = 2 * ( A + B);
        return perimeter;
    }

    // Private methods

    private decimal ValidateH(decimal h)
    {
        if (h < 0)
        {
            throw new Exception($"The height: {h}, is not valid."); ;
        }

        else
        {
            return h;
        }

    }
}
