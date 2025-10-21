
namespace itm.csharp.basic
{
   public class challenge1
    {
        public void Run()
        {
            Console.Write("Ingresa un número: ");
        double num = Convert.ToDouble(Console.ReadLine());

            if (num > 0)
                Console.WriteLine($"El número es positivo. Su cuadrado es: {num * num}");
            else if (num == 0)
                Console.WriteLine("Ingresaste cero. Su cuadrado es 0.");
            else
                Console.WriteLine("El número es negativo");
        }
    }

    public class challenge2
    {
        public void run()
        {
         Console.Write("Ingresa el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"El primer número ({num1}) es mayor. Su doble es: {num1 * 2}");
            }
            else
            {
                Console.WriteLine($"El segundo número ({num2}) es mayor o igual. Su triple es: {num2 * 3}");
            }
        
         }
    }

    public class challenge3
    {
        public void run()
        {
                    Console.Write("Ingresa un número: ");
            double num = Convert.ToDouble(Console.ReadLine());

            if (num > 0)
            {
                double raiz = Math.Sqrt(num);
                Console.WriteLine($"El número es positivo. Su raíz cuadrada es: {raiz}");
            }
            else
            {
                double cuadrado = Math.Pow(num, 2);
                Console.WriteLine($"El número no es positivo. Su cuadrado es: {cuadrado}");
            }

         }
    }

    public class challenge4
    {
        public void run()
        {
          Console.Write("Ingresa el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double perimetro = 2 * Math.PI * radio;
            Console.WriteLine($"El perímetro del círculo con radio {radio} es: {perimetro}");
        
         }
    }

    public class challenge5
    {
        public void run()
        {
            Console.Write("Ingresa un número entre 1 y 7: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            string dia;

            switch (numero)
            {
                case 1: dia = "Lunes"; break;
                case 2: dia = "Martes"; break;
                case 3: dia = "Miércoles"; break;
                case 4: dia = "Jueves"; break;
                case 5: dia = "Viernes"; break;
                case 6:
                case 7:
                    dia = "Es fin de semana. No es un día laborable."; break;
                default:
                    dia = "Número fuera de rango. Debe estar entre 1 y 7."; break;
            }

        }
    }

 public class challenge6
        {
            public void run()
            {
                Console.Write("Ingresa tu salario anual: ");
                double salario = Convert.ToDouble(Console.ReadLine());

                if (salario > 12000)
                {
                    double excedente = salario - 12000;
                    double impuesto = excedente * 0.15;
                    Console.WriteLine($"Resultado : {impuesto}");
                }
                else
                {
                    Console.WriteLine(" No debes pagar impuesto.");
                }
            }
        }

        public class challenge7
        {
            public void run()
            {
                Console.Write("Ingresa el primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa el segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (num2 != 0)
                {
                    double residuo = num1 % num2;
                    Console.WriteLine($"El residuo de dividir {num1} entre {num2} es: {residuo}");
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                }
            }
        }

        public class challenge8
        {
            public void run()
            {
                int suma = 0;

                for (int i = 1; i <= 50; i++)
                {
                    if (i % 2 == 0)
                    {
                        suma += i;
                    }
                }

                Console.WriteLine($"La suma de los números pares entre 1 y 50 es: {suma}");
            }
        }

        public class challenge9
        {
            public void run()
            {
                Console.WriteLine("No lo supe hacer");
            }
        }
        public class challenge10
        {
            public void run()
            {
                Console.Write("Ingrese una palabra: ");
                string palabra = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(palabra))
                {
                    Console.WriteLine("No ingresaste ninguna palabra.");
                    return;
                }

                Console.WriteLine($"La palabra '{palabra}' tiene {palabra.Length} caracteres.");
            }
        }

        public class challenge11
        {
            public void run()
            {
                double suma = 0;

                for (int i = 1; i <= 4; i++)
                {
                    Console.Write($"Ingresa el número {i}: ");
                    double numero = Convert.ToDouble(Console.ReadLine());
                    suma += numero;
                }

                double promedio = suma / 4;
                Console.WriteLine($"El promedio de los cuatro números es: {promedio}");
            }

        }
        public class challenge12
        {
            public void run()
            {
                double menor = double.MaxValue;

                for (int i = 1; i <= 5; i++)
                {
                    Console.Write($"Ingresa el número {i}: ");
                    double numero = Convert.ToDouble(Console.ReadLine());

                    if (numero < menor)
                        menor = numero;
                }

                Console.WriteLine($"El número más pequeño es: {menor}");

            }
        }

        public class challenge13
        {
            public void run()
            {
                Console.Write("Ingresa una palabra: ");
                string palabra = Console.ReadLine().ToLower();

                int contadorVocales = 0;
                foreach (char c in palabra)
                {
                    if ("aeiouáéíóú".Contains(c))
                    {
                        contadorVocales++;
                    }
                }

                Console.WriteLine($"La palabra '{palabra}' tiene {contadorVocales} vocal(es).");


            }
        }

        public class challenge14
        {
            public void run()
            {
                Console.Write("Ingresa un número: ");
                if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
                {
                    long factorial = 1;

                    for (int i = 1; i <= numero; i++)
                    {
                        factorial *= i;
                    }

                    Console.WriteLine($"El factorial de {numero} es: {factorial}");
                }
                else
                {
                    Console.WriteLine("Por favor ingresa un número entero no negativo válido.");
                }
            }
        }

        public class challenge15
        {
            public void run()
            {
                Console.Write("Ingresa un número: ");
                if (double.TryParse(Console.ReadLine(), out double numero))
                {
                    if (numero >= 10 && numero <= 20)
                    {
                        Console.WriteLine($"El número {numero} está dentro del rango de 10 a 20.");
                    }
                    else
                    {
                        Console.WriteLine($"El número {numero} está fuera del rango de 10 a 20.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                }
            }
        }












    

}
