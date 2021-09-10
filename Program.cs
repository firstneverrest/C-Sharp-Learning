using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("blue", "tesla S");
            Console.WriteLine(car.Color);
        }
    }
}