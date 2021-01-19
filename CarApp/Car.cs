using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Car()
        {
            Make = "No Entry";
            Model = "No Entry";
            Year = 0000;
            Price = 0.00;
        }

        public Car(string make, string model, int year, double price)
        {
            Make = make ?? throw new ArgumentNullException(nameof(make));
            Model = model ?? throw new ArgumentNullException(nameof(model));
            Year = year;
            Price = price;
        }

        public override string ToString()
        {
            string output = $"Make: { Make }" + Environment.NewLine;
            output += $"Model: { Model }" + Environment.NewLine;
            output += $"Year: { Year }" + Environment.NewLine;
            output += $"Price: { Price.ToString("C2") }" + Environment.NewLine;

            return output;
        }
    }
}
