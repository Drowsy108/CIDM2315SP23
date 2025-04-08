using System;
using System.Collections.Generic;

class Student
{
    private int studentID;
    private string studentName;
    public static List<Student> studentList = new List<Student>();

    public string StudentName { get { return studentName; } }

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Name: {studentName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create students
        Student student1 = new Student(111, "Alice");
        Student student2 = new Student(222, "Bob");
        Student student3 = new Student(333, "Cathy");
        Student student4 = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>
        {
            { "Alice", 4.0 },
            { "Bob", 3.6 },
            { "Cathy", 2.5 },
            { "David", 1.8 }
        };

        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

        double totalGPA = 0;
        foreach (var grade in gradebook.Values)
        {
            totalGPA += grade;
        }
        double averageGPA = totalGPA / gradebook.Count;
        Console.WriteLine($"Average GPA: {averageGPA:F2}");

        Console.WriteLine("\nStudents with GPA greater than the average:");
        foreach (var student in Student.studentList)
        {
            if (gradebook[student.StudentName] > averageGPA)
            {
                student.PrintInfo();
            }
        }
    }
}
