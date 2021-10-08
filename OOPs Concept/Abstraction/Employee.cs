using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.OOPs_Concept.Abstraction
{
    class Employee
    {
        public int empId;
        public string empName;
        public double grossPay;
        double taxDeducation = 0.1;
        double netSalary;

        public Employee (int eId, string eName, double eGrossPay)
        {
            empId = eId;
            empName = eName;
            grossPay = eGrossPay;

        }
        void CalculateSalary()
        {
            if(grossPay >= 30000)
            {
                netSalary = grossPay - (taxDeducation * grossPay);
                Console.WriteLine("Your salary is " + netSalary);
            }
            else
            {
                Console.WriteLine("Your salary is " + grossPay);
            }
        }
        public void ShoeEmployeeDetails()
        {
            this.CalculateSalary();
        }


    }
    
    
    

}
