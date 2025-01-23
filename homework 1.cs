namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
            double X = 2.5; // im not to sure as to why I cant use decimal instead of double?
            double Y = 3.3;
            double Z = 4 * X * X + 3 * Y;
            Console.WriteLine($"When X = {X} and Y = {Y}, Z = {Z:F2}");
    }
}
