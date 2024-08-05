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

        public void CastrateAnimal()
        { }

        public void Hairdress()
        { }

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
    }
}