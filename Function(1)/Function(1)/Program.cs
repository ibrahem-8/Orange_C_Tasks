//*Task 1

//static void minToSec(int min)
//{
//    int sec = min * 60;
//    Console.WriteLine($"{min} minutes is equal to {sec} seconds.");
//}
//minToSec(5);

//*Task 2

//static int increment(int num)
//{
//    return num + 1;
//}
//int result = increment(5);
//Console.WriteLine($"The incremented value is: {result}");

//*Task 3

//static void firstEle(int[] arr)
//{
//    Console.WriteLine(arr[0]);
//}
//int[] myArray = { 10, 20, 30, 40, 50 };
//firstEle(myArray);

//*Task 4

//Console.WriteLine("Enter the base of triangle");
//double baseOfTriangle = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter the height of triangle");
//double heightOfTriangle = Convert.ToDouble(Console.ReadLine());

//static double areaOfTriangle(double baseOfTriangle, double heightOfTriangle)
//{
//    return 0.5 * baseOfTriangle * heightOfTriangle;
//}
//double area = areaOfTriangle(baseOfTriangle, heightOfTriangle);
//Console.WriteLine($"The area of the triangle is: {area}");

//*Task 5

//int[] nums = { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 };
//static void evenNumberEvenIndex(int[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if ((i%2 == 0) && (arr[i]%2 == 0))
//        {
//            Console.WriteLine(arr[i]);
//        }
//    }
//}
//evenNumberEvenIndex(nums);

//*Task 6

//string[] names = { "alex", "mercer", "madrasa", "rashed2", "emad", "hala" };
//static void evenIndexOddLength(string[] name)
//{
//    for (int i = 0; i < name.Length; i++)
//    {
//        if (i % 2 == 0 && name[i].Length % 2 != 0)
//        {
//            Console.WriteLine(name[i]);
//        }
//    }
//}
//evenIndexOddLength(names);

//*Task 7

//int[] nums = { 44, 5, 4, 3, 2, 10 };
//static void powerElementIndex(int[] numbers)
//{
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        double result = Math.Pow(numbers[i],i);
//        Console.WriteLine(result);
//    }
//}
//powerElementIndex(nums);

//*Task 8

//Console.WriteLine("enter first number");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter second number");
//int num2 = Convert.ToInt32(Console.ReadLine());

//static void multiplication2(int number1, int number2)
//{
//    int result = 0;
//    for (int i = 0; i < number2; i++)
//    {
//        result += number1;
//    }
//    Console.WriteLine(result);
//}
//multiplication2(num1, num2);

//*Task 9

//Console.WriteLine("enter first number");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter second number");
//int num2 = Convert.ToInt32(Console.ReadLine());

//static void muti2(int number1, int number2)
//{
//    int result = 1;
//    for (int i = number1; i <= number2; i++)
//    {
//        result *= i;
//    }
//    Console.WriteLine(result);
//}
//muti2(num1, num2);

//*Task 10

//int[] nums = { 1, 2, 3, 8, 9, 77 };
//static void aveArray(int[] numbers)
//{
//    double result = 0;
//    int count = 0;
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        result += numbers[i];
//        count++;
//    }
//    double average = result / count;
//    Console.WriteLine($"The average of the array is: {average}");
//}
//aveArray(nums);