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

            Console.WriteLine("Ingrese la fecha de nacimiento del Perro (yyyy/dd/mm)");
            DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
            while (!DateOnly.TryParseExact(Console.ReadLine(), "yyyy/dd/MM", null, System.Globalization.DateTimeStyles.None, out birthDate))
            {
                Console.WriteLine("Formato de fecha incorrecto. Ingrese de nuevo (yyyy/dd/mm)");
            }

            Console.WriteLine("Ingrese la raza del Perro");
            string breed = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Ingrese el color del Perro");
            string color = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Ingrese el peso del Perro en kilogramos");
            double weightInKG = Convert.ToDouble(Console.ReadLine().Trim());

            Console.WriteLine("¿El perro está castrado? (si/no)");
            string castrationConfirmation = Console.ReadLine().Trim().ToLower();
            bool breedingStatus = true;

            if (castrationConfirmation == "si")
            {
                breedingStatus = true;
            }
            else if (castrationConfirmation == "no")
            {
                breedingStatus = false;
            }
            else
            {
                Console.WriteLine("Respuesta incorrecta. El perro estara registrado sin castrar");
                breedingStatus = false;
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

            Console.WriteLine("Ingrese el tipo de pelo del Perro (corto, largo, mediano, nulo)");
            string coatType = Console.ReadLine().Trim().ToLower();

            if (coatType == "corto")
            {
                coatType = "corto";
            }
            else if (coatType == "largo")
            {
                coatType = "largo";
            }
            else if (coatType == "mediano")
            {
                coatType = "mediano";
            }
            else if (coatType == "nulo")
            {
                coatType = "nulo";
            }

            return new Dog(name, birthDate, breed, color, weightInKG, breedingStatus, temperament, microchipNumber, barkVolume, coatType);
        }

        public static Cat CreateCat()
        {
            Console.WriteLine("Ingrese el nombre del gato");
            string name = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Ingrese la fecha de nacimiento del gato (yyyy/dd/mm)");
            DateOnly birthDate = DateOnly.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese la raza del gato");
            string breed = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Ingrese el color del gato");
            string color = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Ingrese el peso del gato en kilogramos");
            double weightInKG = Convert.ToDouble(Console.ReadLine().Trim());

            Console.WriteLine("¿El gato está castrado? (si/no)");
            string castrationConfirmation = Console.ReadLine().Trim().ToLower();

            bool breedingStatus;

            if (castrationConfirmation == "si")
            {
                breedingStatus = true;
            }
            else if (castrationConfirmation == "no")
            {
                breedingStatus = false;
            }
            else
            {
                Console.WriteLine("Respuesta incorrecta. El gato estara registrado sin castrar");
                breedingStatus = false;
            }

            Console.WriteLine("Ingrese la longitud de la pelada del gato (corto, medio, largo, mediano, nulo)");
            string furLength = Console.ReadLine().Trim().ToLower();
            if (furLength == "corto")
            {
                furLength = "corto";
            }
            else if (furLength == "medio")
            {
                furLength = "medio";
            }
            else if (furLength == "largo")
            {
                furLength = "largo";
            }
            else if (furLength == "nulo")
            {
                furLength = "nulo";
            }
            else if (furLength == "mediano")
            {
                furLength = "mediano";
            }
            else
            {
                Console.WriteLine("ingresaste un valor erroneo porfavor ingresa uno valido");
                furLength = Console.ReadLine().Trim().ToLower();
            }

            return new Cat(name, birthDate, breed, color, weightInKG, breedingStatus, furLength);
        }

        public static Dog UpdateDog()
        {
            return CreateDog();
        }

        public static Cat UpdateCat()
        {
            return CreateCat();
        }

        public static void ShowHeader(string title)
        {
            Console.Clear();
            Console.WriteLine(new string('-', 45));
            Console.WriteLine(title.ToUpper());
            Console.WriteLine(new string('-', 45));
        }

        public static void ShowFooter()
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', 45));
            Console.WriteLine();
        }

        public static void ShowSeparator()
        {
            Console.WriteLine(new string('-', 45));
            Console.WriteLine("");
        }

        public static void BackToMenu()
        {
            Console.WriteLine("Pulse cualquier boton para volver al menu");
            Console.ReadKey();
        }

    }
}