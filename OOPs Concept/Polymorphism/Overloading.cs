using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.OOPs_Concept.PolymorphismType
{
    class Overloading
    {
        public void Sum(int a,int b)
        {
            Console.WriteLine(a+b);
            Console.ReadLine();

        }
        public void Sum(float a,float b)
        {
            Console.WriteLine(a+b);
            Console.ReadLine();

        }
    }
}
