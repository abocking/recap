using Recap;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Please enter the name for student {i+1}: ");
                string name = Console.ReadLine();

                while (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Error: name cannot be empty. Please enter a valid name.");
                    Console.WriteLine($"Please enter the name for student {i + 1}: ");
                    name = Console.ReadLine();
                }

                Console.WriteLine($"Please enter the age for student {i + 1}: ");
                int age;

                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Invalid input. Please enter a valid age");
                    Console.WriteLine($"Please enter the age for student {i + 1}: ");
                }

                students[i] = new Student(name, age); 
            } 

            for (int i = 0; i < students.Length; i++)
            {
                students[i].DoLab(5 + (i * 5));
            }
        }
    }
}