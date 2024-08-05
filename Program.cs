using PruebaC_sharp_JuanPabloGomezBustamante.Models;

var veterinary = new VeterinaryClinic();
var cat1 = new Cat("cat1", new DateOnly(2002, 12, 12), "der", "plata", 5.4, false, "corto");
var dog1 = new Dog("cat1", new DateOnly(2002, 12, 12), "der", "plata", 5.4, false, "agresibo", "corto", "fuerte", "largo");
veterinary.SaveCat(cat1);

VeterinaryClinic.ListOfDog = new List<Dog>();
VeterinaryClinic.ListOfCat = new List<Cat>();

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
    // metodos para gato
    Console.WriteLine("| 10. Hairdress Cat                        |");
    Console.WriteLine("| 11. Castrate Cat                         |");
    Console.WriteLine("| 13. Show In formacion cat                |");
    // metodos para perro
    Console.WriteLine("| 12. Hairdress Dog                        |");
    Console.WriteLine("| 13. Castrate Dog                         |");
    Console.WriteLine("| 13. Show In formacion Dog                |");
    Console.WriteLine("| 14. var all cats                         |");
    Console.WriteLine("| 15. var all dogs                         |");
    Console.WriteLine("| 0. Exit                                  |");
    ManagerApp.ShowFooter();

    Console.Write("Choose an option: ");
    string optionMenu = Console.ReadLine();

    switch (optionMenu)
    {
        case "1":
            Console.Clear();
            ManagerApp.ShowHeader("Add Dog");
            veterinary.SaveDog(ManagerApp.CreateDog());

            ManagerApp.BackToMenu();
            ManagerApp.ShowFooter();
            break;
        case "2":
            Console.Clear();
            ManagerApp.ShowHeader("Add Cat");
            veterinary.SaveCat(ManagerApp.CreateCat());

            ManagerApp.BackToMenu();
            ManagerApp.ShowFooter();
            break;

        case "3":
            Console.Clear();
            ManagerApp.ShowHeader("Delete Dog");

            Console.WriteLine("ingrese el nombre del perro que desea eliminar");
            string deleteDog = Console.ReadLine().Trim().ToLower();
            veterinary.DeleteDog(deleteDog);

            ManagerApp.BackToMenu();
            ManagerApp.ShowFooter();
            break;

        case "4":
            Console.Clear();
            ManagerApp.ShowHeader("Delete Cat");

            Console.WriteLine("ingrese el nombre del gato que desea eliminar");
            string deleteCat = Console.ReadLine().Trim().ToLower();
            veterinary.DeleteCat(deleteCat);

            ManagerApp.BackToMenu();
            ManagerApp.ShowFooter();
            break;

        case "5":
            Console.Clear();
            ManagerApp.ShowHeader("Update Dog");

            Console.WriteLine("ingrese el nombre del perro que desea actualizar");
            string updateDog = Console.ReadLine().Trim().ToLower();
            veterinary.UpdateDog(updateDog, VeterinaryClinic.ListOfDog);

            ManagerApp.BackToMenu();
            ManagerApp.ShowFooter();
            break;

        case "6":
            Console.Clear();
            ManagerApp.ShowHeader("Update Cat");

            Console.WriteLine("ingrese el nombre del gato que desea actualizar");
            string updateCat = Console.ReadLine().Trim().ToLower();
            veterinary.UpdateCat(updateCat, VeterinaryClinic.ListOfCat);

            ManagerApp.BackToMenu();
            ManagerApp.ShowFooter();
            break;

        case "7":
            Console.Clear();
            ManagerApp.ShowHeader("Show All Patiens");

            veterinary.ShowAllPatiens();

            ManagerApp.BackToMenu();
            ManagerApp.ShowFooter();
            break;

        case "8":
            Console.Clear();
            ManagerApp.ShowHeader("Show Animals");

            Console.WriteLine("Ingrese el tipo de animal (dog o cat)");
            string typeAnimal = Console.ReadLine().Trim().ToLower();
            if (typeAnimal == "dog")
            {
                dog1.ShowAnimals(typeAnimal);
            }
            else if (typeAnimal == "cat")
            {
                cat1.ShowAnimals(typeAnimal);
            }

            ManagerApp.BackToMenu();
            ManagerApp.ShowFooter();
            break;

        case "9":
            Console.Clear();
            ManagerApp.ShowHeader("Show Parents");

            Console.WriteLine("ingrese el nombre del paciente");
            string nameParenst = Console.ReadLine().Trim().ToLower(); ;
            veterinary.ShowParents(nameParenst);

            ManagerApp.BackToMenu();
            ManagerApp.ShowFooter();
            break;

        case "10":
            Console.Clear();
            ManagerApp.ShowHeader("Hairdress Cat");

            Console.WriteLine("ingrese el nombre del gato que desea peluqueria");
            string nameHirdressCat = Console.ReadLine().Trim().ToLower();
            cat1.HairdressCat(nameHirdressCat, VeterinaryClinic.ListOfCat);

            ManagerApp.BackToMenu();
            ManagerApp.ShowFooter();
            break;

        case "11":
            Console.Clear();
            ManagerApp.ShowHeader("Castrate Cat");
            Console.WriteLine("ingrese el nombre del gato que desea castrar");
            string nameCatCastrate = Console.ReadLine().Trim().ToLower();
            cat1.CastrateAnimal(nameCatCastrate, VeterinaryClinic.ListOfCat);

            ManagerApp.BackToMenu();
            ManagerApp.ShowFooter();
            break;

        case "12":
            Console.Clear();
            ManagerApp.ShowHeader("Hairdress Dog");
            Console.WriteLine("ingrese el nombre del perro que desea peluqueria");
            string nameHirdressDog = Console.ReadLine().Trim().ToLower();
            dog1.HairdressDog(nameHirdressDog, VeterinaryClinic.ListOfDog);

            ManagerApp.BackToMenu();
            ManagerApp.ShowFooter();
            break;

        case "13":
            Console.Clear();
            ManagerApp.ShowHeader("Castrate Dog");
            Console.WriteLine("ingrese el nombre del perro que desea castrar");
            string nameDogCastrate = Console.ReadLine().Trim().ToLower();
            dog1.CastrateDog(nameDogCastrate, VeterinaryClinic.ListOfDog);

            ManagerApp.BackToMenu();
            ManagerApp.ShowFooter();
            break;

        case "14":
            Console.Clear();
            cat1.ShowInformacion();
            ManagerApp.BackToMenu();
            break;

        case "15":
            Console.Clear();
            dog1.ShowInformacion();
            ManagerApp.BackToMenu();
            break;

        default:
            Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
            break;

    }
}