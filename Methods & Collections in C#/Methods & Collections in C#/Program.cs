//* Task 1 – Method
//static double CalculateAverage(int num1, int num2, int num3)
//{
//    double average = (num1 + num2 + num3) / 3;
//    return average;
//}
//Console.WriteLine(CalculateAverage(10, 20, 30));
//////////////////////////////////////////////////////////////////
//* Task 2 – List

//List<string> names = new List<string>();
//names.Add("Alice");
//names.Add("Bob");
//names.Add("Charlie");
//names.Add("Diana");
//names.Add("Eve");

//Console.WriteLine("Names in the list:");
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

//names.Remove("Charlie");
//Console.WriteLine("Names after removing Charlie");
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}
//////////////////////////////////////////////////////////////////
//* Task 3 – Dictionary

//Dictionary<int, string> students = new Dictionary<int, string>();
//students.Add(1, "Alice");
//students.Add(2, "Bob");
//students.Add(3, "Charlie");
//Console.WriteLine("Students in the dictionary:");
//foreach (var item in students)
//{
//    Console.WriteLine(item.Key + "-" + item.Value);
//}
//////////////////////////////////////////////////////////////////
//* Task 4 –  LINQ

int[] numbers = { 5, 10, 15, 20, 25, 30 };
string[] names = { "Ahmad", "Ali", "Sara", "Mona", "Omar" };

//*1️ Filter Numbers

//var result = numbers.Where(n => n > 15);
//Console.WriteLine("Numbers greater than 15:");
//foreach (var number in result)
//{
//    Console.WriteLine(number);
//}

//*2️ Even Numbers

//var evenNumbers = numbers.Where(n => n % 2 == 0);
//Console.WriteLine("Even numbers:");
//foreach (var number in evenNumbers)
//{
//    Console.WriteLine(number);
//}

//*3️ Sorting

//var sortedNumbers = numbers.OrderBy(n => n);
//Console.WriteLine("Sorted numbers  in ascending order:");
//foreach (var number in sortedNumbers)
//{
//    Console.WriteLine(number);
//}
//var sortedNumbersDescending = numbers.OrderByDescending(n => n);
//Console.WriteLine("Sorted numbers  in descending order:");
//foreach (var number in sortedNumbersDescending)
//{
//    Console.WriteLine(number);
//}

//*4️ Names Filtering

//var result = names.Where(x => x.StartsWith("A"));
//foreach (var name in result)
//{
//    Console.WriteLine(name);
//}

//*5️ First Value

//int num = numbers.FirstOrDefault(n => n > 10);
//Console.WriteLine(num);

//* bouns

//var result = numbers.Select(x => x * 2);
//foreach (var num in result)
//{
//    Console.WriteLine(num);
//}
/////////////////////////////////////////////////////////////
//*Task 5

//static void sayHello()
//{
//    Console.WriteLine("Welcome");
//}
//sayHello();

//static void sayHello(string name)
//{
//    Console.WriteLine($"Welcome {name}");
//}
//sayHello("Ibrahem");

//static void Age(int age = 22)
//{
//    Console.WriteLine($"Your age is {age}");
//}
//Age();

//static int sum(int num1, int num2)
//{
//    return num1 + num2;
//}
//Console.WriteLine(sum(5, 4));

//static void PrintNumbers(int[] numbers)
//{
//    Console.WriteLine("Numbers:");
//    foreach (int number in numbers)
//    {
//        Console.WriteLine(number);
//    }
//}
//int[] ints = { 1, 2, 3, 4, 5 };
//PrintNumbers(ints);

