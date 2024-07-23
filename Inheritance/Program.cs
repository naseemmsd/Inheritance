using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inheritance.Car;

namespace Inheritance
{
  public  class Car
    {
        public string model;
        public string color;
        public string price;

        public void PrintCarInformation()
        {
            Console.WriteLine("Model:" + model);
            Console.WriteLine("Color" + color);
            Console.WriteLine("Price" + price);
        }
   

      
    }
    public class Ferrari:Car
    {
        public int speed;

        public void PrintSpeed()
        {
            Console.WriteLine("PrintSpeed:" + speed);
        }
    }
    public class Maruti : Ferrari
    {
      public  float mileage;
        public void PrintCMileage()
        {
            Console.WriteLine("Mileage" + mileage);

        }
        public static void Main(string[] args)
        {
            Maruti myCar = new Maruti();
            myCar.model = "Cvic";
            myCar.color = "red";
            myCar.price = "300000000";
            myCar.mileage = 20.4f;
            myCar.speed = 120;
            myCar.PrintCarInformation();
            myCar.PrintCMileage();
        }
    }
   
}
