﻿namespace P03.DetailPrinter
{
    public class Employee
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public override string ToString()
        {
            return $"Name: {this.Name}";
        }
    }
}
