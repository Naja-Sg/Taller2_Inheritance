using System.Globalization;

namespace Backend;

public abstract class GeometricFigure
{
    //Fields

    //Constructors

    protected GeometricFigure(string name)
    {
        Name = name;
    }

    //Properties

    public string Name { get; set; } = null!;


    //Public Methods

    public abstract double GetArea();

    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name,-15} => Area.....: {GetArea().ToString("N5", CultureInfo.InvariantCulture),14}      Perimeter: {GetPerimeter().ToString("N5", CultureInfo.InvariantCulture),14}\t";
    }

    //Private Methods
}
