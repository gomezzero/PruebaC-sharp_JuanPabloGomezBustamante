using PruebaC_sharp_JuanPabloGomezBustamante.Models;

var veterinary = new VeterinaryClinic();
var cat1 = new Cat("cat1", new DateOnly(2002, 12, 12), "der", "plata", 5.4, false, "corto");
veterinary.SaveCat(cat1);

Console.Clear();
veterinary.SaveCat(ManagerApp.CreateCat());

Console.WriteLine("ingrese el nombre");
string deleteCat = Console.ReadLine();

veterinary.DeleteCat(deleteCat);

veterinary.ShowAllPatiens();
