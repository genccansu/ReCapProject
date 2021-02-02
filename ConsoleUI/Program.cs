using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carsManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carsManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            {

            }
        }
    }
}
