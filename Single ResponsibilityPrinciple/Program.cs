using System;

namespace Single_ResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeBefore = new EmployeeBefore("Juan", "Project Manager", 26, 15000);
            Console.WriteLine(employeeBefore);
            employeeBefore.PayTaxes();
            Console.ReadKey();
        }
    }
}
