//*Task 1

//class person
//{
//    public string name { get; set;}
//    private int age { get; set; }
//    public person(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }
//    public void display()
//    {
//        Console.WriteLine("Name: " + name);
//        Console.WriteLine("Age: " + age);
//    }
//    ~person()
//    {
//        Console.WriteLine("Destructor called for " + name);
//    }
//}

//class student : person
//{
//    public student(string name, int age) : base(name, age)
//    {
//    }
//    public void study()
//    {
//        Console.WriteLine(name + " is studying.");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        student s1 = new student("Alice", 20);
//        s1.display();
//        s1.study();
//        student s2 = new student("Bob", 22);
//        s2.display();
//        s2.study();
//    }
//}

//////////////////////////////////////////////////////////////////////////////
//*Task 2

//using System.Diagnostics;
//using System.Drawing;
//using System.Reflection;

//class car
//{
//    public string make { get; set; }
//    public int year { get; set; }
//    public string type { get; set; }
//    public double price { get; set; }
//    public string model { get; set; }
//    public string palletNo { get; set; }
//    public string color { get; set; }
//    public bool isEngineRunning;

//    public car(string make, int year, string type, double price,
//               string model, string palletNo, string color)
//    {
//        this.make = make;
//        this.year = year;
//        this.type = type;
//        this.price = price;
//        this.model = model;
//        this.palletNo = palletNo;
//        this.color = color;
//        isEngineRunning = false;
//    }

//    public void StartEngine()
//    {
//        isEngineRunning = true;
//        Console.WriteLine("Engine started.");
//    }

//    public void StopEngine()
//    {
//        isEngineRunning = false;
//        Console.WriteLine("Engine stopped.");
//    }

//    public void DisplayInfo()
//    {
//        Console.WriteLine("Make: " + make);
//        Console.WriteLine("Year: " + year);
//        Console.WriteLine("Type: " + type);
//        Console.WriteLine("Price: " + price);
//        Console.WriteLine("Model: " + model);
//        Console.WriteLine("Pallet No: " + palletNo);
//        Console.WriteLine("Color: " + color);
//    }

//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        car c1 = new car("Toyota", 2020, "Sedan", 20000, "Camry", "ABC123", "Red");
//        c1.DisplayInfo();
//        c1.StartEngine();
//        c1.StopEngine();
//    }
//}