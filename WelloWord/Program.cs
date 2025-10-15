namespace HelloWord
{
    class Program
    {
        static void Main()
        {
            DateOnly dateConverted = new DateOnly();
            string nameInput;
            string BirthdayInput;
            Console.WriteLine("Hola Bienvenido a el calculador de años");
            Console.WriteLine("Escribe tu nombre: ");
            nameInput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameInput}");
            Console.WriteLine("Escribe tu fehca de nacimiento dd/mm/aa: ");
            BirthdayInput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(BirthdayInput, out dateConverted);
            if (isDateValid == false) Console.WriteLine($"La fecha de nacimiento es invalida usted nos envio este dato erronero {BirthdayInput} ");
            var person = new Person
            {
                Name = nameInput,
                Birthday = dateConverted,
                Age = DateTime.Now.Year -dateConverted.Year
            };
            Console.WriteLine($"Tu nombre:  {person.Name}");
            Console.WriteLine($"tu fecha de nacimiento {person.Birthday}");
            Console.WriteLine($"tu edad es: {person.Age} años");
            Console.WriteLine();

        }

    }


    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }




}


