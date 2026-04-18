//*Task 1

//int[] nums = {  1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
//int sum = 0;
//double average = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    sum += nums[i];
//}
//average = (double)sum / nums.Length;
//Console.WriteLine($"The sum of the numbers is: {sum}");
//Console.WriteLine($"The average of the numbers is: {average}");


///////////////////////////////////////////////////////////////////////
//*Task 2

//Console.WriteLine("enter number of terms to cube the numbers");
//int n = int.Parse(Console.ReadLine());

//for (int i = 1; i <= n; i++)
//{
//    int cube = i * i * i;
//    Console.WriteLine($"The cube of {i} is: {cube}");
//}

///////////////////////////////////////////////////////////////////////
//*Task 3

//int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020};

//static int getYears(int[] years)
//{
//    int count = 0;
//    for (int i = 0; i < years.Length; i++)
//    {
//        if (years[i] > 1950)
//        {
//            count++;
//        }
//    }
//    return count;
//}
//Console.WriteLine(getYears(years));

///////////////////////////////////////////////////////////////////////
//*Task 4

//Console.WriteLine("enter your age");
//int age = int.Parse(Console.ReadLine());

//Console.WriteLine("your age in days is: " + age * 365);

///////////////////////////////////////////////////////////////////////
//*Task 5

//Console.WriteLine("tell me how many chickens do you have");
//int chickens = int.Parse(Console.ReadLine());
//Console.WriteLine("tell me how many cows do you have");
//int cows = int.Parse(Console.ReadLine());
//Console.WriteLine("tell me how many pigs do you have");
//int pigs = int.Parse(Console.ReadLine());

//static int getLegs(int chickens, int cows, int pigs)
//{
//    int legs = (chickens * 2) + (cows * 4) + (pigs * 4);
//    return legs;
//}
//Console.WriteLine("the total number of legs is: " + getLegs(chickens, cows, pigs));

///////////////////////////////////////////////////////////////////////
//*Task 6

//string[] users = { "Ibrahem:Ibrahem@8", "Abood:Abood@12", "Saeed:Saeed@5"};

//Console.WriteLine("enter your username");
//string username = Console.ReadLine();
//Console.WriteLine("enter your password");
//string password = Console.ReadLine();

//static bool login(string[] users, string username, string password)
//{
//    for (int i = 0; i < users.Length; i++)
//    {
//        string[] userInfo = users[i].Split(':');
//        if (userInfo[0] == username && userInfo[1] == password)
//        {
//            return true;
//        }
//    }
//    return false;
//}
//if (login(users, username, password))
//{
//    Console.WriteLine("Login successful!");
//}
//else
//{
//    Console.WriteLine("Invalid username or password.");
//}

///////////////////////////////////////////////////////////////////////
//*Task 7

//Console.WriteLine("enter a number");
//int number = int.Parse(Console.ReadLine());
//Console.WriteLine("enter the power");
//int power = int.Parse(Console.ReadLine());

//static int powerOfNumber(int number, int power)
//{
//    int result = 1;
//    for (int i = 0; i < power; i++)
//    {
//        result *= number;
//    }
//    return result;
//}
//Console.WriteLine($"{number} raised to the power of {power} is: {powerOfNumber(number, power)}");

///////////////////////////////////////////////////////////////////////
//*Task 8

//Console.WriteLine("enter a year between 1900-2024");
//int year = int.Parse(Console.ReadLine());

//static void isLeapYear(int year)
//{
//    if (year >= 1900 && year <= 2024)
//    {
//        if (DateTime.IsLeapYear(year))
//        {
//            Console.WriteLine("Leep year");
//        }
//        else
//        {
//            Console.WriteLine("Not a leap year");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid year. Please enter a year between 1900 and 2024.");
//    }
//}
//isLeapYear(year);

///////////////////////////////////////////////////////////////////////
//*Task 9

//Console.WriteLine("enter a number");
//int number = int.Parse(Console.ReadLine());

//static void primeNumber(int number)
//{
//    if (number <= 1)
//    {
//        Console.WriteLine("Not a prime number");
//        return;
//    }
//    for (int i = 2; i <= Math.Sqrt(number); i++)
//    {
//        if (number % i == 0)
//        {
//            Console.WriteLine("Not a prime number");
//            return;
//        }
//    }
//    Console.WriteLine("Prime number");
//}
//primeNumber(number);

//* Another solution for Task 9:

//Console.WriteLine("enter a number");
//int number = int.Parse(Console.ReadLine());

//static void primeNumber(int number)
//{
//    int count = 0;
//    if (number <= 1)
//    {
//        Console.WriteLine("Not a prime number");
//        return;
//    }
//    for (int i = 1; i <= number; i++)
//    {
//        if (number % i == 0)
//        {
//            count++;
//        }
//    }
//    if (count == 2)
//    {
//        Console.WriteLine("Prime number");
//    }
//    else
//    {
//        Console.WriteLine("Not a prime number");
//    }
//}
//primeNumber(number);

///////////////////////////////////////////////////////////////////////
//*Task 10

//Console.WriteLine("enter any sentence");
//string sentence = Console.ReadLine();

//static void numberOfWords(string sentence)
//{
//    string[] words = sentence.Split(' ');
//    Console.WriteLine($"The number of words in the sentence is: {words.Length}");
//}
//numberOfWords(sentence);