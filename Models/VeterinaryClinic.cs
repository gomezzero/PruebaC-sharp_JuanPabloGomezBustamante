using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JuanPabloGomezBustamante.Models
{
    public class VeterinaryClinic
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public static List<Dog> ListOfDog = new List<Dog>();
        public static List<Cat> ListOfCat = new List<Cat>();

        // metodos
        public VeterinaryClinic()
        { }
        public VeterinaryClinic(string name, string address)
        {
            Name = name;
            Address = address;
        }

        // Metodos perros 

        public void SaveDog(Dog newDog)
        {
            ListOfDog.Add(newDog);
        }

        public void UpdateDog(string nameDogUpdate, List<Dog> ListOfDog)
        {
            Dog dogUppdate = ListOfDog.FirstOrDefault(e => e.GetName() == nameDogUpdate);

            if (dogUppdate != null)
            {
                ListOfCat.RemoveAll(e => e.GetName() == nameDogUpdate);


                var nuevosDatos = ManagerApp.UpdateDog2();
                SaveDog(nuevosDatos);
            }
        }

        public void DeleteDog(string deleteDog)
        {
            Console.WriteLine($"seguiro que quieres eliminar al perro identificado con: {deleteDog}");
            Console.WriteLine("si - no");
            string question = Console.ReadLine();
            if (question == "si")
            {
                ListOfDog.RemoveAll(e => e.GetName() == deleteDog);
                Console.WriteLine("El perro fue eliminado");
            }
            else
            {
                Console.WriteLine("En tendido");
            }
        }

        // Metodos gatos
        public void SaveCat(Cat newCat)
        {
            ListOfCat.Add(newCat);
        }

        public void UpdateCat(string nameCatUpdate, List<Cat> ListOfCat)
        {
            Cat catUppdate = ListOfCat.FirstOrDefault(e => e.GetName() == nameCatUpdate);

            if (catUppdate != null)
            {
                ListOfCat.RemoveAll(e => e.GetName() == nameCatUpdate);
                
                var nuevosDatos = ManagerApp.UpdateCat2();
                SaveCat(nuevosDatos);
            }
        }

        public void DeleteCat(string deleteCat)
        {
            Console.WriteLine($"seguiro que quieres eliminar al gato identificado con: {deleteCat}");
            Console.WriteLine("si - no");
            string question = Console.ReadLine();
            if (question == "si")
            {
                ListOfCat.RemoveAll(e => e.GetName() == deleteCat);
                Console.WriteLine("El gato fue eliminado");
            }
            else
            {
                Console.WriteLine("En tendido");
            }
        }

        // metodos de mostrar

        public void ShowAllPatiens()
        {
            Console.WriteLine("Patientes en la clinica:");
            Console.WriteLine(" ");

            Console.WriteLine("Perros:");
            foreach (var dog in ListOfDog)
            {
                Console.WriteLine($"Id: {dog.GetId()}, Name: {dog.GetName()}, Breed: {dog.BreedingStatus}");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Gatos:");

            foreach (var cat in ListOfCat)
            {
                Console.WriteLine($"Id: {cat.GetId()}, Name: {cat.GetName()}, BreedingStatus: {cat.BreedingStatus}");
            }
            Console.WriteLine(" ");

        }


        public void ShowParents(string nameParenst)
        {
            Dog dog = ListOfDog.FirstOrDefault(e => e.GetName() == nameParenst);
            Cat cat = ListOfCat.FirstOrDefault(e => e.GetName() == nameParenst);

            if (dog != null)
            {
                Console.WriteLine($"El perro {dog.GetName()} nacido el: {dog.GetBirthDate()} con el color: {dog.GetColor()} y el peso: {dog.GetWeightInKG()} esta en nuestr base de datos");
            }
            else if (cat != null)
            {
                Console.WriteLine($"El gato {cat.GetName()} nacido el: {cat.GetBirthDate()} con el color: {cat.GetColor()} y el peso: {cat.GetWeightInKG()} esta en nuestr base de datos");
            }
            else
            {
                Console.WriteLine("No se encontro ningún animal con ese nombre en nustra base de datos");
            }
        }
    }
}