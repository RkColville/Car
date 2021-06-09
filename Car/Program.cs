using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.Year = 2021;
            myObj.Make = "Tesla";
            myObj.Model = "Model S";
            //Console.WriteLine(myObj.Year);
            //Console.WriteLine(myObj.Make);
            //Console.WriteLine(myObj.Model);
            

            var bmw = new Car()
            {
                Year = 2010,
                Make = "BMW",
                Model = "B52 LoveShack"
                
            };

            var myCar = new Car(2003, "Toyota", "4Runner");

            var carList = new List<Car>() { myCar, bmw, myObj };
            //Console.WriteLine(carList.Capacity);

            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }
            Console.ReadLine();
        }
   }
    
}
