

using Backend;

var circle = new Circle(name: nameof(Circle), r: 5);
var square = new Square(name: nameof(Square), a: 10);
var rhombus = new Rhombus(name: nameof(Rhombus), a: 5, d1: 7, d2: 10);
var kite = new Kite(name: nameof(Kite), a: 7, b: 8, d1: 6, d2: 5);
var rectangle = new Rectangle(name: nameof(Rectangle), a: 4.568, b: 67.790);
var parallelogram = new Parallelogram(name: nameof(Parallelogram), a: 14.65, b: 54.67, h: 23.09);


var figures = new List<GeometricFigure>
{
    circle, square, rhombus, kite, rectangle, parallelogram
};

foreach (var figure in figures)
{
    Console.WriteLine(figure);
}
