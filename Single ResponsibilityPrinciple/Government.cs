using System;
using System.Collections.Generic;
using System.Text;

namespace Single_ResponsibilityPrinciple
{
    class Government
    {
        public double CalculateTax(Employee employee)
        {
            return employee.Salary * 0.30;
        }

        public void PayTaxes(Employee employee)
        {
            double taxes = CalculateTax(employee);
            Console.WriteLine("Se pago {0} en impuestos por parte de {1}", taxes, employee.Name);
        }
    }
}
