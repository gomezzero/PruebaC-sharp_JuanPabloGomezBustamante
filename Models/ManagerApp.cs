using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JuanPabloGomezBustamante.Models
{
    public class ManagerApp
    {
        public static Dog CreateDog()
        {
            Console.WriteLine("Ingrese el nombre del Perro");
            string name = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Ingrese la fecha de nacimiento del Perro (dd/mm/yyyy)");
            DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
            while (!DateOnly.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out birthDate))
            {
                Console.WriteLine("Formato de fecha incorrecto. Ingrese de nuevo (dd/mm/yyyy)");
            }

            Console.WriteLine("Ingrese la raza del Perro");
            string breed = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Ingrese el color del Perro");
            string color = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Ingrese el peso del Perro en kilogramos");
            double weightInKG = Convert.ToDouble(Console.ReadLine().Trim());

            Console.WriteLine("¿El perro está castrado? (si/no)");
            string castrationConfirmation = Console.ReadLine().Trim().ToLower();
            bool breedStatus = true;

            if (castrationConfirmation == "si")
            {
                breedStatus = true;
            }
            else if (castrationConfirmation == "no")
            {
                breedStatus = false;
            }
            else
            {
                Console.WriteLine("Respuesta incorrecta. El perro estara registrado sin castrar");
                breedStatus = false;
            }

            Console.WriteLine("Ingrese el tipo de temperamento del Perro (Timido, Normal, Agresivo)");
            string temperament = Console.ReadLine().Trim().ToLower();
            if (temperament == "timido")
            {
                temperament = "timido";
            }
            else if (temperament == "normal")
            {
                temperament = "normal";
            }
            else if (temperament == "agresivo")
            {
                temperament = "agresivo";
            }
            else
            {
                Console.WriteLine("El temperamento ingresado es incorrecto, ingrese un temperamento valido: ");
                temperament = Console.ReadLine().Trim().ToLower();
            }

            Console.WriteLine("Ingrese el número de microchip del Perro");
            string microchipNumber = Console.ReadLine().Trim();

            Console.WriteLine("Ingrese el volumen del ruido de la Mascota (alto, medio, bajo)");
            string barkVolume = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Ingrese el tipo de pelo del Perro (curto, largo, nulo)");
            string coatType = Console.ReadLine().Trim().ToLower();

            return new Dog(name, birthDate, breed, color, weightInKG, breedStatus, temperament, microchipNumber, barkVolume, coatType);
        }

        public static Cat CreateCat()
        { 
            Console.WriteLine("Ingrese el nombre del gato");
            string name = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Ingrese la fecha de nacimiento del gato (dd/mm/yyyy)");
            DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
            while (!DateOnly.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out birthDate))
            {
                Console.WriteLine("Formato de fecha incorrecto. Ingrese de nuevo (dd/mm/yyyy)");
            }

            Console.WriteLine("Ingrese la raza del gato");
            string breed = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Ingrese el color del gato");
            string color = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Ingrese el peso del gato en kilogramos");
            double weightInKG = Convert.ToDouble(Console.ReadLine().Trim());

            Console.WriteLine("¿El gato está castrado? (si/no)");
            string castrationConfirmation = Console.ReadLine().Trim().ToLower();
            bool breedStatus = true;

            if (castrationConfirmation == "si")
            {
                breedStatus = true;
            }
            else if (castrationConfirmation == "no")
            {
                breedStatus = false;
            }
            else
            {
                Console.WriteLine("Respuesta incorrecta. El gato estara registrado sin castrar");
                breedStatus = false;
            }

            Console.WriteLine("Ingrese la longitud de la pelada del gato (corto, medio, largo)");
            string furLength = Console.ReadLine().Trim().ToLower();

            return new Cat(name, birthDate, breed, color, weightInKG, breedStatus, furLength);
        }

        public static void ShowHeader()
        { }

        public static void ShowFooter()
        { }

        public static void ShowSeparator()
        { }

    }
}