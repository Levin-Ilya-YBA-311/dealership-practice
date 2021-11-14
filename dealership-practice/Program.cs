using System;

namespace dealershippractice
   
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Domain.Car(1, 2, "BMV-iX", 2021, 1.2, "blue", 1200000.00);
            var brand = new Domain.Brand(1, "Volvo", "Sweden");
            var carsale = new Domain.Carsale(3, 1, 2, DateTime.Today, 1300000, 1);
            var woker = new Domain.Woker(6, "Jon Smitt", "seller");
            Console.WriteLine($"car={car} brand= {brand} carsale={carsale} woker={woker}");
        }
    }
}
