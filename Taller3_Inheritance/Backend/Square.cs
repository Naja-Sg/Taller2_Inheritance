namespace Backend;

public class Square : GeometricFigure
{
    //Fields

    private double _a;

    //Constructors

    public Square(string name, double a) : base(name)
    {
        Name = name;
        A = a;
    }

    //Properties

    public double A 
    { 
        get => _a; 
        set => _a = ValidateA(value); 
    
    }

    //Public Methods

    public override double GetArea()
    {
        double area = Math.Pow((double) A, 2);
        return area;
    }

    public override double GetPerimeter()
    {
        double perimeter = 4 * A;
        return perimeter;
    }
    //Private Methods

    private double ValidateA(double a)
    {
        if (a < 0)
        {
            throw new Exception($"The side length: {a}, is not valid."); ;
        }

        else
        {
            return a;
        }

    }

}
