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

    public void Display()
    {
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Marks: " + Marks);
        Console.WriteLine("Grade: " + CalculateGrade());
    }
}