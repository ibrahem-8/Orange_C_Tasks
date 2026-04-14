//*Task 1

//int[] numbers = { 10, 15, 22, 7, 8, 13, 30 };
//int even = 0;
//int odd = 0;
//int sum = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 0)
//    {
//        even++;
//    }
//    else
//    {
//        odd++;
//    }
//    sum += numbers[i];
//}
//Console.WriteLine($"Even count: {even}");
//Console.WriteLine($"Odd count: {odd}");
//Console.WriteLine($"Sum: {sum}");

//double average = (double)sum / numbers.Length;
//int[] greaterThanAvg = new int[numbers.Length];
//int n = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] > average)
//    {
//        greaterThanAvg[n] = numbers[i];
//        n++;
//    }
//}

//Console.WriteLine($"Average: {average}");
//Console.WriteLine("Numbers greater than average:");
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine(greaterThanAvg[i]);
//}
//////////////////////////////////////////////////////////////////
//*Task 2

//int[] numbers = {12, 45, 7, 23, 56, 19};
//int max = numbers[0];
//for (int i = 1; i < numbers.Length; i++)
//{
//    if (numbers[i] > max)
//    {
//        max = numbers[i];
//    }
//}
//Console.WriteLine($"Maximum number: {max}");
//////////////////////////////////////////////////////////////////
//*Task 3

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}
//for (int i = 1; i <= 10; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine($"even numbers is: {i}");
//    }
//}
//////////////////////////////////////////////////////////////////
//*Task 4

//try {
//    Console.WriteLine("Enter your name");
//    string name = Console.ReadLine();
//    Console.WriteLine("Enter your age");
//    int age = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Enter your height");
//    double height = Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine("Are you employed (true/false):");
//    bool isEmployed = Convert.ToBoolean(Console.ReadLine());
//    Console.WriteLine("--- User Profile ---");
//    Console.WriteLine($"Name: {name}");
//    Console.WriteLine($"Age: {age}");
//    Console.WriteLine($"Height: {height}");
//    Console.WriteLine($"Employed: {isEmployed}");
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Input format is incorrect. Please enter the correct data type.");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"An error occurred: {ex.Message}");
//}
//////////////////////////////////////////////////////////////////
//*Task 5

//Console.WriteLine("Enter your name");
//string name = Console.ReadLine();

//Console.WriteLine(name.ToLower());
//Console.WriteLine(name.ToUpper());

//Console.WriteLine("Enter your age");
//int age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Your age is: " + age);
//Console.WriteLine($"your name is {name} and your age is {age}");

//Console.WriteLine(name[0]);
//Console.WriteLine($"Name: {name} \nAge:{age}");

//Console.WriteLine(name[name.Length-1]);
//Console.WriteLine($"Name:\t{name}");
//////////////////////////////////////////////////////////////////
//* Task – Break & Continue

for (int i = 1; i <= 10; i++)
{
    if (i % 3 == 0)
    {
        continue;
    }
    if (i == 8)
    {
        break;
    }
    Console.WriteLine(i);
}