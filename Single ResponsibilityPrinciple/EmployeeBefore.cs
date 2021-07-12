using System;
using System.Collections.Generic;
using System.Text;

namespace Single_ResponsibilityPrinciple
{
    class EmployeeBefore
    {
        private string name;
        private string position;
        private int age;
        private double salary;

        public EmployeeBefore(string name, string position, int age, double salary)
        {
            this.name = name;
            this.position = position;
            this.age = age;
            this.salary = salary;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", name, position, age, salary);
        }
        //Estos dos métodos deberían salir de empleado
        public double CalculateTax()
        {
            return salary * 0.30;
        }

        public void PayTaxes()
        {
            double taxes = CalculateTax();
            Console.WriteLine("Se pago {0} en impuestos por parte de {1}", taxes, name);
        }
        /*El empleado tiene dos razones para cambiar, cambios en el
            empleado como tal o cambios en la forma de calcular impuestos*/
    }
}
