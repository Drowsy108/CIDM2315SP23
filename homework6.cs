namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1: Create 2 New Professors
            Professor professor1 = new Professor("Alice", "Java", 9000);
            Professor professor2 = new Professor("Bob", "Math", 8000);

            // Q1: Create 2 New Students
            Student student1 = new Student("Lisa", "Java", 90);
            Student student2 = new Student("Tom", "Math", 80);

            Console.WriteLine("Professor Details:");
            Console.WriteLine($"Name: {professor1.ProfName}, Class: {professor1.ClassTeach}, Salary: {professor1.GetSalary()}");
            Console.WriteLine($"Name: {professor2.ProfName}, Class: {professor2.ClassTeach}, Salary: {professor2.GetSalary()}");

            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Name: {student1.StudentName}, Class: {student1.ClassEnroll}, Grade: {student1.GetGrade()}");
            Console.WriteLine($"Name: {student2.StudentName}, Class: {student2.ClassEnroll}, Grade: {student2.GetGrade()}");

            double salaryDifference = professor1.GetSalary() - professor2.GetSalary();
            Console.WriteLine($"\nSalary Difference: {salaryDifference}");

            double totalGrade = student1.GetGrade() + student2.GetGrade();
            Console.WriteLine($"Total Grade (Lisa's Java + Tom's Math): {totalGrade}");
        }
    }

    class Professor
    {
        private string profName;
        private string classTeach;
        private double salary;

        public Professor(string name, string course, double salaryAmount)
        {
            profName = name;
            classTeach = course;
            salary = salaryAmount;
        }

        public string ProfName => profName;
        public string ClassTeach => classTeach;

        public void SetSalary(double salaryAmount)
        {
            salary = salaryAmount;
        }

        public double GetSalary()
        {
            return salary;
        }
    }

    class Student
    {
        private string studentName;
        private string classEnroll;
        private double studentGrade;

        public Student(string name, string course, double grade)
        {
            studentName = name;
            classEnroll = course;
            studentGrade = grade;
        }

        public string StudentName => studentName;
        public string ClassEnroll => classEnroll;

        public void SetGrade(double grade)
        {
            studentGrade = grade;
        }

        public double GetGrade()
        {
            return studentGrade;
        }
    }
}
