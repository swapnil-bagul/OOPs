using System;
using System.Collections.Generic;
using System.Text;


namespace OOPs.OOPs_Concept.ObjectClass
{
    class Calculator
    {
        
        int num1 =20;
        int num2 =10;
        int res;

         public void Add()
        {
            res = num1 + num2;
            Console.WriteLine("Addition " + res);
            Console.ReadLine();

        }
       public  void Sub()
        {
            res = num1 - num2;
            Console.WriteLine("Substraction " + res);
            Console.ReadLine();

        }
        /*public static void Main(string[]args)
        {
            Calculator obj = new Calculator();
            obj.Add();
            obj.Sub();

        }
        */



    }
}
