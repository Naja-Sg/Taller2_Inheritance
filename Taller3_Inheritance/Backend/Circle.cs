namespace Backend;

public class Circle : GeometricFigure

{
    //Fields

    private double _r;


    //Constructors


    public Circle (string name, double r) : base(name)
    {
        R = r;
    }


    //Properties

    public double R 
    { 
        get => _r; 
        set => _r = ValidateR(value); 
    }


    //Public methods
    public override double GetArea()
    {
        double area =  Math.PI *  Math.Pow ((double)R, 2);
        return area;
    }

    public override double GetPerimeter()
    {
        double perimeter = 2 * Math.PI * R;
        return perimeter;
    }


    //Private Methods

    private double ValidateR (double radious)
    {
        if (radious < 0)
        {
            throw new Exception($"The radious: {radious}, is not valid."); ;
        }

        else
        {
            return radious;
        }

    }
}
