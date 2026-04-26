//*Task 1

//public static class MathUtilities 
//{
//    public static int Square(int number)
//    {
//        return number * number;
//    }
//    public static int SquareRoot(int number)
//    {
//        return (int)Math.Sqrt(number);
//    }
//    public static int Max(int a, int b)
//    {
//        return (a > b) ? a : b;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int num1 = 16;
//        int num2 = 25;

//        Console.WriteLine(MathUtilities.Square(num1));

//        Console.WriteLine(MathUtilities.SquareRoot(num1));

//        Console.WriteLine(MathUtilities.Max(num1, num2));
//    }
//}

/////////////////////////////////////////////////////////////////////////
//*Task 2

//public class Converter
//{
//    public static double CelsiusToFahrenheit(double celsius)
//    {
//        return (celsius * 9 / 5) + 32;
//    }
//    public static double KilometersToMiles(double kilometers)
//    {
//        return kilometers * 0.621371;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        double celsius = 25;
//        double kilometers = 10;
//        Console.WriteLine(Converter.CelsiusToFahrenheit(celsius));
//        Console.WriteLine(Converter.KilometersToMiles(kilometers));
//    }
//}

///////////////////////////////////////////////////////////////////
//*Task 3

//public class VisitorCounter
//{
//    public static int Count = 0;

//    public VisitorCounter()
//    {
//        Count++;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        VisitorCounter visitor1 = new VisitorCounter();
//        VisitorCounter visitor2 = new VisitorCounter();
//        VisitorCounter visitor3 = new VisitorCounter();
//        Console.WriteLine("Total visitors: " + VisitorCounter.Count);
//    }
//}

///////////////////////////////////////////////////////////////////
//*Task 4

//public class Company
//{
//    public static string CompanyName { get; set; } = "My Company";
//    public string EmployeeName { get; set; }

//    public Company(string employeeName) 
//    {
//        this.EmployeeName = employeeName;
//    }

//    public void Display()
//    {
//        Console.WriteLine($"Employee: {EmployeeName}, Company: {CompanyName}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine(Company.CompanyName);
//        Company.CompanyName = "Tech Solutions";
//        Console.WriteLine(Company.CompanyName);

//        Company employee1 = new Company("Alice");
//        Company employee2 = new Company("Bob");

//        employee1.Display();
//        employee2.Display();
//    }
//}

//////////////////////////////////////////////////////////////////////
//*Task 5

//public class Test
//{
//    public int Add(int x, int y)
//    {
//        return x + y;
//    }
//    public int Add(int x, int y, int z)
//    {
//        return x + y + z;
//    }
//}
////////////////////////////////////////
//public class Animal
//{
//    public virtual void Speak() 
//    {
//        Console.WriteLine("Animal makes a sound");
//    }
//}

//public class Dog : Animal 
//{
//    public override void Speak() 
//    {
//        Console.WriteLine("Dog Barks");
//    }
//}

//public class Cat : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Cat Meows");
//    }
//}
///////////////////////////////////////////
//public class Person
//{
//    private int id;
//    private string name;

//    public int Id
//    {
//        get { return id; }
//        set { id = value; }
//    }

//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Person p = new Person();

//        p.Id = 1;
//        p.Name = "Ahmad";

//        Console.WriteLine("ID: " + p.Id);
//        Console.WriteLine("Name: " + p.Name);
//    }
//}
//////////////////////////////////////////////////////
//public abstract class Shape
//{
//    public abstract double GetArea();
//}

//public class Rectangle : Shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public override double GetArea()
//    {
//        return Width * Height;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Rectangle r = new Rectangle();
//        r.Width = 5;
//        r.Height = 10;

//        Console.WriteLine(r.GetArea());
//    }
//}

//////////////////////////////////////////////////////////////////////
//*Task 6

//public class Calculator
//{
//    public int Add(int a, int b)
//    {
//        return a + b;
//    }
//    public int Add(int a, int b, int c)
//    {
//        return a + b + c;
//    }
//    public decimal Add(decimal a, decimal b)
//    {
//        return a + b;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Calculator calc = new Calculator();
//        Console.WriteLine(calc.Add(5, 10));
//        Console.WriteLine(calc.Add(5, 10, 15));
//        Console.WriteLine(calc.Add(5.5m, 10.5m));
//    }
//}

////////////////////////////////////////////////////////////
//*Task 7

//public class Animal
//{
//    public virtual void Speak()
//    {
//        Console.WriteLine("Animal makes a sound");
//    }
//}

//public class Dog : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Dog Barks");
//    }
//}

//public class Cat : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Cat Meows");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Animal myDog = new Dog();
//        Animal myCat = new Cat();
//        myDog.Speak();
//        myCat.Speak();
//    }
//}

/////////////////////////////////////////////////////////////
//*Task 8

//public abstract class Appliance
//{
//    public string Brand { get; set; }
//    public abstract void TurnOn();
//    public abstract void TurnOff();
//}

//public class WashingMachine : Appliance
//{
//    public override void TurnOn()
//    {
//        Console.WriteLine("Washing Machine is now ON.");
//    }
//    public override void TurnOff()
//    {
//        Console.WriteLine("Washing Machine is now OFF.");
//    }
//}

//public class AirConditioner : Appliance
//{
//    public override void TurnOn()
//    {
//        Console.WriteLine("Air Conditioner is now ON.");
//    }
//    public override void TurnOff()
//    {
//        Console.WriteLine("Air Conditioner is now OFF.");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        WashingMachine wm = new WashingMachine { Brand = "LG" };
//        AirConditioner ac = new AirConditioner { Brand = "Samsung" };
//        Console.WriteLine($"Appliance: {wm.Brand}");
//        wm.TurnOn();
//        wm.TurnOff();
//        Console.WriteLine($"Appliance: {ac.Brand}");
//        ac.TurnOn();
//        ac.TurnOff();
//    }
//}

//////////////////////////////////////////////////////
//*Task 9

//public class BankAccount
//{
//    private decimal balance;
//    public void Deposit(decimal amount)
//    {
//        if (amount > 0)
//        {
//            balance += amount;
//        }
//        else
//        {
//            Console.WriteLine("Deposit amount must be positive.");
//        }
//    }
//    public void Withdraw(decimal amount)
//    {
//        if (amount > 0 && amount <= balance)
//        {
//            balance -= amount;
//        }
//        else
//        {
//            Console.WriteLine("Invalid withdrawal amount.");
//        }
//    }
//    public decimal GetBalance()
//    {
//        return balance;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        BankAccount account = new BankAccount();
//        account.Deposit(1000);
//        account.Withdraw(200);
//        Console.WriteLine($"Current Balance: {account.GetBalance()}");
//    }
//}

///////////////////////////////////////////////
//*Task 10

//abstract class Employee
//{
//    public string Name { get; set; }
//    public abstract decimal CalculateSalary();
//}

//class FullTimeEmployee : Employee
//{
//    public decimal MonthlySalary { get; set; }
//    public override decimal CalculateSalary()
//    {
//        return MonthlySalary;
//    }
//}

//class PartTimeEmployee : Employee
//{
//    public decimal HourlyRate { get; set; }
//    public int HoursWorked { get; set; }
//    public override decimal CalculateSalary()
//    {
//        return HourlyRate * HoursWorked;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        FullTimeEmployee fullTimeEmp = new FullTimeEmployee { Name = "Alice", MonthlySalary = 3000 };
//        PartTimeEmployee partTimeEmp = new PartTimeEmployee { Name = "Bob", HourlyRate = 15, HoursWorked = 80 };
//        Console.WriteLine($"{fullTimeEmp.Name}'s Salary: {fullTimeEmp.CalculateSalary()}");
//        Console.WriteLine($"{partTimeEmp.Name}'s Salary: {partTimeEmp.CalculateSalary()}");
//    }
//}