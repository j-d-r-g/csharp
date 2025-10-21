var circ = new Circulo();
circ.Radio = 20;
var result_area = circ.Area();
var result_perin = circ.Perimetro();

Console.WriteLine($"Area es: {result_area} y el perimtro es: {result_perin} el nuevo radio es: {circ.Add10()}");

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
    Console.WriteLine("numero a dividir: ");
    double n = double.Parse(Console.ReadLine());
    Console.WriteLine("Divisor: ");
    double divisor = double.Parse(Console.ReadLine());
    if (divisor == 0)

    {
        throw new DivideByZeroException();
    }
    Console.WriteLine($"Resultado: {n / divisor} ");
}
catch (DivideByZeroException )
{
     Console.WriteLine("No se puede dividir por cero ");
}