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

        public void CastrateAnimal()
        {

        }

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