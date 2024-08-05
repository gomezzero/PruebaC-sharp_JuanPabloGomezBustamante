using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JuanPabloGomezBustamante.Models
{
    public class Dog : Animal
    {
        public bool BreedingStatus { get; set; }
        public string Temperament { get; set; }
        public string MicrochipNumber { get; set; }
        public string BarkVolume { get; set; }
        public string CoatType { get; set; }

        // metodos
        public Dog(string name, DateOnly birthDate, string breed, string color, double weightInKG, bool breedingStatus, string temperament, string microchipNumber, string barkVolume, string coatType)
                : base(name, birthDate, breed, color, weightInKG)
        {
            Name = name;
            BirthDate = birthDate;
            Breed = breed;
            Color = color;
            WeightInKG = weightInKG;
            BreedingStatus = breedingStatus;
            Temperament = temperament;
            MicrochipNumber = microchipNumber;
            BarkVolume = barkVolume;
            CoatType = coatType;
        }

        public Dog(string name, DateOnly birthDate, string breed, string color, double weightInKG)
               : base(name, birthDate, breed, color, weightInKG)
        { }

        public void CastrateDog(string nameDogCastrate ,List<Dog> ListOfdog)
        { 
             Dog dogCastrate = ListOfdog.FirstOrDefault(e => e.GetName() == nameDogCastrate);

            if (dogCastrate!= null || BreedingStatus == true)
            {
                Console.WriteLine($"El perro {nameDogCastrate} no ah pasado por castracion ya que ya esta castrado");
            }
            else if (dogCastrate!= null || BreedingStatus == false)
            {
                Console.WriteLine($"El perro {nameDogCastrate} ha pasado por castracion");
                BreedingStatus = true;
            }            
        }

        public void HairdressDog(string nameHirdress, List<Dog> listOfDog)
        {
            Dog dog = listOfDog.FirstOrDefault(e => e.GetName() == nameHirdress);

            if (dog != null || dog.CoatType == "largo")
            {
                Console.WriteLine($"El perro {nameHirdress} ha pasado por peluqueria");
            }
            else if (dog != null || dog.CoatType == "mediano")
            {
                Console.WriteLine($"El perro {nameHirdress} ha pasado por peluqueria");
            }
            else if (dog != null || dog.CoatType == "corto")
            {
                Console.WriteLine($"El perro {nameHirdress} no puede pasar por peluqueria devido a que su pelo es corto");
            }
            else if (dog != null || dog.CoatType == "nulo")
            {
                Console.WriteLine($"El perro {nameHirdress} no puede pasar por peluqueria devido a que no tiene pelo");
            }
            else
            {
                Console.WriteLine("perro no encontrado");
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
            Console.WriteLine($"temperamento: {Temperament}");
            Console.WriteLine($"Microchip: {MicrochipNumber}");
            Console.WriteLine($"Volumen del ruido: {BarkVolume}");
            Console.WriteLine($"Tipo de pelo: {CoatType}");
            BasicReview();
        }

        public void ShowAnimals(string typeAnimal)
        {
            if (typeAnimal.ToLower() == "dog")
            {
                foreach (var dog in VeterinaryClinic.ListOfDog)
                {
                    Console.WriteLine($"Id: {dog.Id}, Name: {dog.Name}, Breed: {dog.Breed}");
                }
            }
            else
            {
                Console.WriteLine("Tipo de animal no válido");
            }
        }
    }
}