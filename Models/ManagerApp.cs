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
            ShowFooter();

            Console.WriteLine("Ingrese la fecha de nacimiento del Perro (yyyy/dd/mm)");
            DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
            DateTime birthDateConfirmation = DateTime.Parse(birthDate.ToString());
            if (birthDateConfirmation > DateTime.Today.Date.AddYears(-1))
            {
                Console.WriteLine("La fecha de nacimiento ingresada es incorrecta, ingrese una fecha valida: ");
                birthDate = DateOnly.Parse(Console.ReadLine());
            }
            ShowFooter();


            Console.WriteLine("Ingrese la raza del Perro");
            string breed = Console.ReadLine().Trim().ToLower();
            ShowFooter();

            Console.WriteLine("Ingrese el color del Perro");
            string color = Console.ReadLine().Trim().ToLower();
            ShowFooter();

            Console.WriteLine("Ingrese el peso del Perro en kilogramos");
            double weightInKG = Convert.ToDouble(Console.ReadLine().Trim());
            ShowFooter();

            Console.WriteLine("¿El perro está castrado? (true/false)");
            bool breedingStatus = Convert.ToBoolean(Console.ReadLine);
            if (breedingStatus != false && breedingStatus != true)
            {
                Console.WriteLine("ingresa un valor valido");
                breedingStatus = Convert.ToBoolean(Console.ReadLine());
            }
            ShowFooter();

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
            ShowFooter();

            Console.WriteLine("Ingrese el número de microchip del Perro");
            string microchipNumber = Console.ReadLine().Trim();
            ShowFooter();

            Console.WriteLine("Ingrese el volumen del ruido de la Mascota (alto, medio, bajo)");
            string barkVolume = Console.ReadLine().Trim().ToLower();
            ShowFooter();

            Console.WriteLine("Ingrese el tipo de pelo del Perro (corto, largo, mediano, nulo)");
            string coatType = Console.ReadLine().Trim().ToLower();
            ShowFooter();

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
            ShowFooter();

            return new Dog(name, birthDate, breed, color, weightInKG, breedingStatus, temperament, microchipNumber, barkVolume, coatType);
        }

        public static Cat CreateCat()
        {
            Console.WriteLine("Ingrese el nombre del gato");
            string name = Console.ReadLine().Trim().ToLower();
            ShowFooter();

            Console.WriteLine("Ingrese la fecha de nacimiento del Gato (yyyy/dd/mm)");
            DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
            DateTime birthDateConfirmation = DateTime.Parse(birthDate.ToString());
            if (birthDateConfirmation > DateTime.Today.Date.AddYears(-1))
            {
                Console.WriteLine("La fecha de nacimiento ingresada es incorrecta, ingrese una fecha valida: ");
                birthDate = DateOnly.Parse(Console.ReadLine());
            }
            ShowFooter();


            Console.WriteLine("Ingrese la raza del gato");
            string breed = Console.ReadLine().Trim().ToLower();
            ShowFooter();

            Console.WriteLine("Ingrese el color del gato");
            string color = Console.ReadLine().Trim().ToLower();
            ShowFooter();

            Console.WriteLine("Ingrese el peso del gato en kilogramos");
            double weightInKG = Convert.ToDouble(Console.ReadLine().Trim());
            ShowFooter();

            Console.WriteLine("¿El gato está castrado? (true/false)");
            bool breedingStatus = Convert.ToBoolean(Console.ReadLine());
            ShowFooter();

            if (breedingStatus != false && breedingStatus != true)
            {
                Console.WriteLine("ingresa un valor valido");
                breedingStatus = Convert.ToBoolean(Console.ReadLine());
            }
            ShowFooter();

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
            ShowFooter();

            return new Cat(name, birthDate, breed, color, weightInKG, breedingStatus, furLength);
        }

        public static Dog UpdateDog2()
        {
            return CreateDog();
        }

        public static Cat UpdateCat2()
        {
            return CreateCat();
        }

        public static void ShowHeader(string title)
        {
            Console.Clear();
            Console.WriteLine(new string('-', 44));
            Console.WriteLine(title.ToUpper());
            Console.WriteLine(new string('-', 44));
        }

        public static void ShowFooter()
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', 44));
            Console.WriteLine();
        }

        public static void ShowSeparator()
        {
            Console.WriteLine(new string('-', 44));
            Console.WriteLine("");
        }

        public static void BackToMenu()
        {
            Console.WriteLine("Pulse cualquier boton para volver al menu");
            Console.ReadKey();
        }

    }
}