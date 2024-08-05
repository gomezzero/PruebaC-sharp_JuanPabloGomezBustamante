using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace PruebaC_sharp_JuanPabloGomezBustamante.Models
{
    public class Cat : Animal
    {
        public bool BreedingStatus { get; set; }
        public string FurLength { get; set; }

        // metodos

        public Cat(string name, DateOnly birthDate, string breed, string color, double weightInKG, bool breedingStatus, string furLength) : base(name, birthDate, breed, color, weightInKG)
        {
            Name = name;
            BirthDate = birthDate;
            Breed = breed;
            Color = color;
            WeightInKG = weightInKG;
            BreedingStatus = breedingStatus;
            FurLength = furLength;
        }

        public void CastrateAnimal(string nameCatCastrate ,List<Cat> ListOfCat)
        {
             Cat catCastrate = ListOfCat.FirstOrDefault(e => e.GetName() == nameCatCastrate);

            if (catCastrate!= null || BreedingStatus == true)
            {
                Console.WriteLine($"El gato {nameCatCastrate} no ah pasado por castracion ya que ya esta castrado");
            }
            else if (catCastrate!= null || BreedingStatus == false)
            {
                Console.WriteLine($"El gato {nameCatCastrate} ha pasado por castracion");
                BreedingStatus = true;
            }            
        }

        public void HairdressCat(string nameHirdressCat, List<Cat> ListOfCat)
        {
            Cat cat = ListOfCat.FirstOrDefault(e => e.GetName() == nameHirdressCat);

            if (cat != null || cat.FurLength == "largo")
            {
                Console.WriteLine($"El gato {nameHirdressCat} ha pasado por peluqueria");
            }
            else if (cat != null || cat.FurLength == "mediano")
            {
                Console.WriteLine($"El gato {nameHirdressCat} ha pasado por peluqueria");
            }
            else if (cat != null || cat.FurLength == "corto")
            {
                Console.WriteLine($"El gato {nameHirdressCat} no puede pasar por peluqueria devido a que su pelo es corto");
            }
            else if (cat != null || cat.FurLength == "nulo")
            {
                Console.WriteLine($"El gato {nameHirdressCat} no puede pasar por peluqueria devido a que no tiene pelo");
            }
        }

        // Mostrar los campos protected
        public int GetId()
        {
            return Id;
        }

        public string GetName()
        {
            return Name;
        }

        public DateOnly GetBirthDate()
        {
            return BirthDate;
        }

        public string GetBreed()
        {
            return Breed;
        }

        public string GetColor()
        {
            return Color;
        }

        public double GetWeightInKG()
        {
            return WeightInKG;
        }

        public override void ShowInformacion()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Raza: {Breed}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Peso: {WeightInKG} kg");
            Console.WriteLine($"Edad: {CalculateAgeInMonths()} meses");
            Console.WriteLine($"capado:  {BreedingStatus}");
            Console.WriteLine($"Longitud del pelo: {FurLength}");
            BasicReview();
        }

        public void ShowAnimals(string typeAnimal)
        {
            if (typeAnimal.ToLower() == "cat")
            {
                foreach (var cat in VeterinaryClinic.ListOfCat)
                {
                    Console.WriteLine($"Id: {cat.Id}, Name: {cat.Name}, Breed: {cat.Breed}");

                }
            }
            else
            {
                Console.WriteLine("Tipo de animal no válido");
            }
        }

    }
}