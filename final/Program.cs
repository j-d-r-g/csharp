using System.ComponentModel.Design;

namespace itm.csharp.basic
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"hola, {nombre} elige un ejercicio del siguiente menu:");
            Menu.MostrarMenu();
            while (true)
            {
              Console.Write("\nIngresa el número del ejercicio o 'q'/'exit' para salir: ");
                string entrada = Console.ReadLine().ToLower();

                // Salir del bucle
                if (entrada == "q" || entrada == "exit")
                {
                    Console.WriteLine("\nHasta luego 👋");
                    break;
                }

                // Verificar si la entrada es un número válido
                if (int.TryParse(entrada, out int eleccion) && eleccion >= 1 && eleccion <= 15)
                {
                    Console.Clear();
                    Console.WriteLine($"--- Ejecutando ejercicio {eleccion} ---\n");

                    // Llamar al challenge correspondiente
                    EjecutarChallenge(eleccion);

                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    Menu.MostrarMenu();
                }
                else
                {
                    Console.WriteLine("\nOpción no válida. Por favor, ingrese un número entre 1 y 15 o 'q'/'exit' para salir.");
                }
                
            }
            Console.WriteLine("hasta luego");
        }
           
    }
}



