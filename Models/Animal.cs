using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JuanPabloGomezBustamante.Models
{
    public abstract class Animal
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

        public abstract void ShowInformacion();

        protected void BasicReview()
        { 
            if (WeightInKG < 1)
            {
                Console.WriteLine("El animal es muy pequeño");
            }
            else if (WeightInKG < 5)
            {
                Console.WriteLine("El animal es pequeño");
            }
            else if (WeightInKG < 10)
            {
                Console.WriteLine("El animal es mediano");
            }
            else
            {
                Console.WriteLine("El animal es grande");
            }
        }

        protected int CalculateAgeInMonths()
        { 
            return (DateTime.Today.Year * 12 + DateTime.Today.Month) - (BirthDate.Year * 12 + BirthDate.Month);
        } 
    }
}