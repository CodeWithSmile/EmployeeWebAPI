﻿namespace Employee.Model
{
    public class Employees
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public double salary { get; set; }
        public Employees()
        {
        }
        public Employees(int id, string name, int age ,double salary)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
    }
}
