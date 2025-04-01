using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating Customer objects
        Customer cus1 = new Customer("Alice", 33, "Amarillo", 198.5);
        Customer cus2 = new Customer("Bob", 23, "Amarillo", 226);
        Customer cus3 = new Customer("Cathy", 45, "Amarillo", 89.0);
        Customer cus4 = new Customer("David", 58, "Amarillo", 198.5);
        Customer cus5 = new Customer("Jack", 28, "Canyon", 561.6);
        Customer cus6 = new Customer("Tom", 36, "Canyon", 98.4);
        Customer cus7 = new Customer("Tony", 24, "Canyon", 18.5);
        Customer cus8 = new Customer("Sam", 35, "Canyon", 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        // Call methods
        TotalCredits(customer_list);
        AmarilloAverageAge(customer_list);
        CanyonAge(customer_list);
    }

    // Q1: Method to calculate and print the total credit of all customers
    public static void TotalCredits(Customer[] customer_list)
    {
        double totalCredit = 0;
        foreach (Customer customer in customer_list)
        {
            totalCredit += customer.CustomerCredit;
        }
        Console.WriteLine($"Total Credit: {totalCredit}");
    }

    // Q2: Method to calculate and print the average age of customers living in Amarillo
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        int totalAge = 0;
        int count = 0;
        foreach (Customer customer in customer_list)
        {
            if (customer.CustomerCity == "Amarillo")
            {
                totalAge += customer.CustomerAge;
                count++;
            }
        }
        double averageAge = (count > 0) ? (double)totalAge / count : 0;
        Console.WriteLine($"Average Age of Customers in Amarillo: {averageAge:F2}");
    }

    // Q3: Method to print names of customers who live in Canyon and are older than 30
    public static void CanyonAge(Customer[] customer_list)
    {
        Console.WriteLine("Customers in Canyon older than 30:");
        foreach (Customer customer in customer_list)
        {
            if (customer.CustomerCity == "Canyon" && customer.CustomerAge > 30)
            {
                Console.WriteLine(customer.CustomerName);
            }
        }
    }
}

// Q0: Customer class definition
class Customer
{
    public string CustomerName { get; }
    public int CustomerAge { get; }
    public string CustomerCity { get; }
    public double CustomerCredit { get; }

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        CustomerName = customerName;
        CustomerAge = customerAge;
        CustomerCity = customerCity;
        CustomerCredit = customerCredit;
    }
}
