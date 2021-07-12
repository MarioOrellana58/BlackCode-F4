using System;

namespace Single_ResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeAfter = new Employee("Juan", "Project Manager", 26, 15000);
            Console.WriteLine(employeeAfter);
            var usGovernment = new Government();
            Console.WriteLine(usGovernment.CalculateTax(employeeAfter));
            usGovernment.PayTaxes(employeeAfter);
        }
    }
}
