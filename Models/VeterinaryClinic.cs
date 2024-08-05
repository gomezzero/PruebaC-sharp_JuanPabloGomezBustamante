using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JuanPabloGomezBustamante.Models
{
    public class VeterinaryClinic
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Dog> ListOfDog = new List<Dog>();
        public List<Cat> ListOfCat = new List<Cat>();

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

        public void UpdateDog(Dog newDog)
        { 

        }

        public void DeleteDog(int id)
        {
            Console.WriteLine($"seguiro que quieres eliminar al perro identificado con: {id}");
            Console.WriteLine("si - no");
            string question = Console.ReadLine();
            if (question == "si")
            {
                ListOfDog.RemoveAll(e => e.GetName() == id);
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

        public void UpdateCat(Cat cat)
        { }

        public void DeleteCat(Cat cat)
        {
            ListOfCat.Remove(cat);
        }

        // metodos de mostrar

        public void ShowAllPatiens()
        {
            Console.WriteLine("Patientes en la clinica:");
            foreach (var dog in ListOfDog)
            {
                Console.WriteLine($"Id: {dog.GetId()}, Name: {dog.GetName()}, Breed: {dog.GetBreed}");
            }
            foreach (var cat in ListOfCat)
            {
                Console.WriteLine($"Id: {cat.GetId()}, Name: {cat.GetName()}, Breed: {cat.GetBreed}");
            }
        }

        public void ShowAnimals(string type)
        {
            if (type.ToLower() == "dog")
            {
                foreach (var dog in ListOfDog)
                {
                    Console.WriteLine($"Id: {dog.GetId}, Name: {dog.GetName}, Breed: {dog.GetBreed}");
                }
            }
            else if (type.ToLower() == "cat")
            {
                foreach (var cat in ListOfCat)
                {
                    Console.WriteLine($"Id: {cat.GetId}, Name: {cat.GetName}, Breed: {cat.GetBreed}");
                }
            }
            else
            {
                Console.WriteLine("Tipo de animal no válido");
            }
        }
    }
}