using System;
using System.Collections.Generic;
using System.Text;

namespace Single_ResponsibilityPrinciple
{
    class Employee
    {
        private string name;
        private string position;
        private int age;
        private double salary;

        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

        public Employee(string name, string position, int age, double salary)
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

        //ya solo cuenta con cosas que sí son de su responsabilidad, solo cuenta con una razón para cambiar
    }
}
