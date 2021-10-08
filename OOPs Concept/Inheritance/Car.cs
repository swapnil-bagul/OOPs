using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.OOPs_Concept.Inheritance
{
    class Car
    {
        public string model;
        public string color;
        public int price;

        public void PrintCarInformation()
        {
            Console.WriteLine("model: " + model);
            Console.WriteLine("color: " + color);
            Console.WriteLine("price: " + price);
            Console.ReadLine();
        }
    }
    class Maruti:Car 
    {
        public float milege;

        public void Printmilege()
        {
            Console.WriteLine("milege: " + milege);

        }
       /* public static void Main(string[]args)
        {
            Maruti myCar = new Maruti();
            myCar.milege = 25.5F;
            myCar.model = "Alto";
            myCar.color = "Silver";
            myCar.price = 400000;
            myCar.Printmilege();
            myCar.PrintCarInformation();
            Toyota myCar1 = new Toyota();
            myCar1.milege = 30;
            myCar1.model = "Innova";
            myCar1.color = "White";
            myCar1.price = 800000;
            myCar1.highestSpeed = 140;
            myCar1.PrintCarInformation();
            myCar1.Speed();
            
            
        }*/
       
    }
    class Toyota:Car
    {
        public int milege;
        public int highestSpeed;
        public void Speed()
        {
            Console.WriteLine("Milege: " + milege);
            Console.WriteLine("Speed: " + highestSpeed);
        }

       
       
    }
}
