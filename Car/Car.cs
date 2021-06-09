using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Car
    {

        public Car()
        {

        }
        
        public Car(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }
        
        
        //Create a Make property of type string that is public:
        public string Make { get; set; } // get = read set = write

        // Create a Model property of type string that is public:
        public string Model { get; set; }

        //Create a Year property of type int that is public:
        public int Year {get;set;}

        
    }
}
