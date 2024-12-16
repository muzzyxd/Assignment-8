using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3__HashTables_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable employees = new Hashtable();

            employees.Add(1001, "Muzammil");
            employees.Add(1002, "Zohaib");
            employees.Add(1003, "Haris");
            employees.Add(1004, "Haseeb");

            employees[1002] = "Wasiq";

            employees.Remove(1003);

            Console.WriteLine("Employee List:");
            foreach (object entry in employees.Keys)
            {
                Console.WriteLine($"Id: {entry}, Name: {employees[entry]}");
            }
            Console.ReadLine();
        }
    }
}
