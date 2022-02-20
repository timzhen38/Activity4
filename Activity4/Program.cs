using System;

interface ICustomer
{
    int Age { get; set; }
    string Name { get; set; }
    double MoneySpent { get; set; }
}

class Customer: ICustomer
{
    //properties
    private int age;
    private string name = "Tim";
    private double moneySpent;
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public string Name
    {
        get { return name.ToUpper(); }
        set { name = value; }
    }
    public double MoneySpent
    {
        get { return moneySpent; }
        set { moneySpent = value; }
    }

    //indexer
    private string[] itemsPurchased = new string[100];

    public string this[int i]
    {
        get { return itemsPurchased[i]; }
        set { itemsPurchased[i] = value; }
    }

    //instance method
    public void AddMoneySpent(double money)
    {
        moneySpent += money;
    }
}

class MainClass
{
    static void Main()
    {
        var customer = new Customer();
        customer.Age = 21;
        customer.MoneySpent = 10.50;
        customer[0] = "Cheeseburger";
        Console.WriteLine(customer.Name + " { Age: " + customer.Age + 
                                            " | Money Spent: $" + customer.MoneySpent + 
                                            " | Items Purchased: " + customer[0] + " }");

        customer.AddMoneySpent(1999.99);
        customer[1] = "NVIDIA GeForce RTX 3090";
        Console.WriteLine(customer.Name + " { Age: " + customer.Age +
                                            " | Money Spent: $" + customer.MoneySpent +
                                            " | Items Purchased: " + customer[0] + ", " + customer[1] + " }");

    }
}