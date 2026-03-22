using System;
using System.Data.SqlClient;

class Student
{
    public string Name;
    public int Age;
    public int Marks;

    public Student(string name, int age, int marks)
    {
        Name = name;
        Age = age;
        Marks = marks;
    }

    public string CalculateGrade()
    {
        return Marks switch
        {
            >= 90 => "A",
            >= 75 => "B",
            >= 50 => "C",
            _ => "Fail"
        };
    }

    public void SaveToDatabase()
    {
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=StudentDB;Trusted_Connection=True;";

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Students (Name, Age, Marks, Grade) VALUES (@Name, @Age, @Marks, @Grade)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Age", Age);
            cmd.Parameters.AddWithValue("@Marks", Marks);
            cmd.Parameters.AddWithValue("@Grade", CalculateGrade());

            con.Open();
            cmd.ExecuteNonQuery();
        }

        Console.WriteLine("Saved to database!");
    }

    public void Display()
    {
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Marks: " + Marks);
        Console.WriteLine("Grade: " + CalculateGrade());
    }
}