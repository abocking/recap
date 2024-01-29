using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap
{
    internal class Student
    {
        public string name;
        public int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void DoLab (int labNo)
        {
            if (labNo >= 1 && labNo <= 20)
            {
                Console.WriteLine($"{name} is {age} years old and is doing lab {labNo}");
            }
            else
            {
                Console.WriteLine("Error: Invalid lab number. Please enter a lab number between 1 and 20.");
            }
        }
    }
}
