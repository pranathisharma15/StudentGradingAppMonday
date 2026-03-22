using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nStudent " + (i + 1));

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Marks: ");
            int marks = int.Parse(Console.ReadLine());

            Student s = new Student(name, age, marks);
            s.Display();
            s.SaveToDatabase();   

        }
    }
}