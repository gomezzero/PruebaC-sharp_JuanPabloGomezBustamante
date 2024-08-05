using PruebaC_sharp_JuanPabloGomezBustamante.Models;

var veterinary = new VeterinaryClinic();
var cat1 = new Cat("cat1", new DateOnly(2002, 12, 12), "der", "plata", 5.4, false, "corto");
veterinary.SaveCat(cat1);

Console.Clear();

while (true)
{
    ManagerApp.ShowHeader("Veterinary center");
    // CRUD
    Console.WriteLine("| 1.  Add Dog                              |");
    Console.WriteLine("| 2.  Add Cat                              |");
    Console.WriteLine("| 3.  Delete Dog                           |");
    Console.WriteLine("| 4.  Delete Cat                           |");
    Console.WriteLine("| 5.  Update Dog                           |");
    Console.WriteLine("| 6.  Update Cat                           |");
    // Mostrar informacion
    Console.WriteLine("| 7.  Show All Patiens                     |");
    Console.WriteLine("| 8.  Show Animals                         |");
    Console.WriteLine("| 9.  Show Parents                         |");
    ManagerApp.ShowFooter();
    // metodos para gato
    Console.WriteLine("| 10. Hairdress Cat                        |");
    Console.WriteLine("| 11. Castrate Cat                         |");
    // metodos para perro
    Console.WriteLine("| 12. Hairdress Dog                        |");
    Console.WriteLine("| 13. Castrate Dog                         |");
    Console.WriteLine("| 14. Exit                                 |");
    ManagerApp.ShowFooter();

    Console.Write("Choose an option: ");
    string optionMenu = Console.ReadLine();

    switch (optionMenu)
    {
        
    }
}