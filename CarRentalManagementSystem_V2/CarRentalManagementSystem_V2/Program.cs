using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V2
{
    internal class Program
    {
        
      static void Main(string[] args)
        {    
                CarRepository repository = new CarRepository();
                bool exit = false;

                while (!exit)
            {   
                Console.Clear();
                Console.WriteLine("\nCarRental Management System:");
                Console.WriteLine("1. Add a Car");
                Console.WriteLine("2. View All Cars");
                Console.WriteLine("3. Update a Car");
                Console.WriteLine("4. Delete a Car");
                Console.WriteLine("5.view a Car");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.CreateCar(repository);
                        break;
                    case "2":
                        Console.Clear();
                        repository.ReadCar();
                        break;
                    case "3":
                        Console.Clear();
                        Console.UpdateCar(repository);
                        break;
                    case "4":
                        Console.Clear();
                        DeleteCar(repository);
                        break;

                    case "5":
                        Console.Clear();
                        ReadCarById(repository);
                        break;
                    case "6":
                        Console.Clear();
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Pleace select valid choice");
                        break;
                }

                if (exit)
                {
                    exit = true;
                    Console.ReadLine();

                }

            }
      }

        static void CreateCar(CarRepository repository)
        {
            Console.WriteLine("Enter Car Brand:");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter Car Model:");
            string model = Console.ReadLine();

            Console.WriteLine("Enter Car Model:");
            decimal rentalprice = decimal.Parse(Console.ReadLine());

            repository.CreateCar(brand, model, rentalprice);
        }

            static void UpdateCar(CarRepository repository)
            {

            Console.WriteLine("Enter Car ID  to update:");
            int carid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new Brand:");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter new Model:");
            string model = Console.ReadLine();

            Console.WriteLine("Enter Car Model:");
            decimal rentalprice = decimal.Parse(Console.ReadLine());

            repository.UpdateCar(carid, brand, model, rentalprice);
        }

        static void DeleteCar(CarRepository repository)
        {
            Console.WriteLine("Enter Car ID  to delete:");
            int id = int.Parse(Console.ReadLine());

            repository.DeleteCar(id);
        }

        static void ReadById(CarRepository repository)
        {
            Console.WriteLine("Enter Car ID  to View:");
            int id = int.Parse(Console.ReadLine());

            var rental = repository.ReadCarById(id);
            Console.WriteLine(rental.ToString());

        }


        static void ReadCar(CarRepository repository)
        {
            var carList = repository.ReadCars();
            foreach (var car in carList)
            {
                Console.WriteLine(car);
            }
        }

       
    }
}
