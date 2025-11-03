using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            DateOnly dateConverted; 
            string nameInput;
            string birthdayInput;

            Console.WriteLine("Hola, bienvenido al calculador de años.");
            Console.WriteLine("Escribe tu nombre:");
            nameInput = Console.ReadLine();

            Console.WriteLine($"¡Un gusto conocerte, {nameInput}!");
            Console.WriteLine("Escribe tu fecha de nacimiento en formato dd/MM/yyyy:");

            birthdayInput = Console.ReadLine(); 
            
                        bool isDateValid = DateOnly.TryParse(birthdayInput, out dateConverted); // ✅ Sintaxis correcta

            if (!isDateValid)
            {
                Console.WriteLine($" La fecha de nacimiento es inválida. Ingresaste: {birthdayInput}");
            }
            else
            {
                // Calcula la edad
                int edad = CalcularEdad(dateConverted);
                Console.WriteLine($"✅ Fecha válida: {dateConverted}");
                Console.WriteLine($"Tienes {edad} años.");
            }

            Console.WriteLine(); 
        }

        
        static int CalcularEdad(DateOnly fechaNacimiento)
        {
            DateOnly hoy = DateOnly.FromDateTime(DateTime.Now);
            int edad = hoy.Year - fechaNacimiento.Year;

            if (fechaNacimiento > hoy.AddYears(-edad))
                edad--;

            return edad;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }
}
