using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JuanPabloGomezBustamante.Models
{
    public class Animal
    {
        private static int ultimoId = 0;
        protected int Id = ++ultimoId;
        protected string Name { get; set; }
        protected DateOnly BirthDate { get; set; }
        protected string Breed { get; set; }
        protected string Color { get; set; }
        protected double WeightInKG { get; set; }

        // metodos
        public Animal(string name, DateOnly birthDate, string breed, string color, double weightInKG)
        {
            Id = ultimoId;
            Name = name;
            BirthDate = birthDate;
            Breed = breed;
            Color = color;
            WeightInKG = weightInKG;
        }

        public void ShowInformacion()
        { }

        protected void BasicReview()
        { }

        protected int CalculateAgeInMonths()
        { return 1; } 
    }
}