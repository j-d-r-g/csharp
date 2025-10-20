
var circ = new Circulo();

circ.Radio = 20;
var result_area = circ.Area();
var result_perin = circ.Perimetro();
Console.WriteLine($"el area es: {result_area} y el perimtro es: {result_perin}")

int prev = 0, next = 1, sum;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(prev);
    sum = prev + next;
    prev = next;
    next = sum;
}

try
{
    Console.WriteLine("numero a dividir:");
    double n = double.Parse(Console.ReadLine());
    Console.WriteLine("divisor:");
    double divisor = double.Parse(Console.ReadLine());
    if (divisor == 0)
    {
        throw new DivideByZeroException();
    }
}

/*
abstract class Figura
{
    public abstract double Area();
    public abstract double Perimetro();

}
*/


interface IExtracalculations
{
    public double Add10();
}
interface IFigura
{
    public double Area();
    public double perimetro();

}

class CirculO 
{
    public double Radio { get; set; }
    public double Area() => Math.PI * Radio * Radio;
    public  double Perimetro() => 2 * Math.PI * Radio;

public double Add10()
{
        return Radio + 10;
}

}

