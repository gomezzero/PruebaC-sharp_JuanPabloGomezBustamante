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

        public void UpdateDog(string nameDogUpdate, List<Dog> ListOfDog)
        {
            Dog dogUppdate = ListOfDog.FirstOrDefault(e => e.GetName() == nameDogUpdate);

            if (dogUppdate != null)
            {
                string deleteDog = nameDogUpdate;
                DeleteDog(deleteDog);

                var nuevosDatos = ManagerApp.UpdateCat();
                SaveCat(nuevosDatos);
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
                string deleteCat = nameCatUpdate;
                DeleteCat(deleteCat);

                var nuevosDatos = ManagerApp.UpdateCat();
                SaveCat(nuevosDatos);
            }
        }

        public void DeleteCat(string deleteCat)
        {
            Console.WriteLine($"seguiro que quieres eliminar al perro identificado con: {deleteCat}");
            Console.WriteLine("si - no");
            string question = Console.ReadLine();
            if (question == "si")
            {
                ListOfCat.RemoveAll(e => e.GetName() == deleteCat);
                Console.WriteLine("El perro fue eliminado");
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
            foreach (var dog in ListOfDog)
            {
                Console.WriteLine($"Id: {dog.GetId()}, Name: {dog.GetName()}, Breed: {dog.BreedingStatus}");
            }
            foreach (var cat in ListOfCat)
            {
                Console.WriteLine($"Id: {cat.GetId()}, Name: {cat.GetName()}, BreedingStatus: {cat.BreedingStatus}");
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
    
        public void ShowParents(string nameParenst)
        {
            Dog dog = ListOfDog.FirstOrDefault(e => e.GetName() == nameParenst);
            Cat cat = ListOfCat.FirstOrDefault(e => e.GetName() == nameParenst);

            if (dog!= null)
            {
                Console.WriteLine($"El perro {dog.GetName()} nacido: {dog.GetBirthDate()} ");
            }
            else if (cat!= null)
            {
                Console.WriteLine($"El gato {cat.GetName()} es dueño de: {cat.GetBirthDate()} ");
            }
            else
            {
                Console.WriteLine("No se encontro ningún animal con ese nombre");
            } 
        }
    }
}