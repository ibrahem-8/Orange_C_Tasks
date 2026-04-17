//*Task 1

//Console.WriteLine("enter first num");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter second num");
//int num2 = Convert.ToInt32(Console.ReadLine());

//if (num1 < num2)
//{
//    Console.WriteLine("the smaller number is " + num1);
//}
//else
//{
//    Console.WriteLine("the smaller number is " + num2);

//}//////////////////////////////////////////////////////////////////////////
//Task 2

//Console.WriteLine("enter the number and i will tell you the sign of this number");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num > 0)
//{
//    Console.WriteLine("the sign of this number is +");
//}
//else if (num < 0)
//{
//    Console.WriteLine("the sign of this number is -");
//}
//else
//{
//    Console.WriteLine("the sign of this number is 0");
//}

//////////////////////////////////////////////////////////////////////////
//Task 3

//Console.WriteLine("enter first number");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter second number");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter third number");
//int c = Convert.ToInt32(Console.ReadLine());

//int first, second, third;

//if (a <= b && a <= c)
//{
//    first = a;
//    if (b <= c)
//    {
//        second = b;
//        third = c;
//    }
//    else
//    {
//        second = c;
//        third = b;
//    }
//}
//else if (b <= a && b <= c)
//{
//    first = b;
//    if (a <= c)
//    {
//        second = a;
//        third = c;
//    }
//    else
//    {
//        second = c;
//        third = a;
//    }
//}
//else
//{
//    first = c;
//    if (a <= b)
//    {
//        second = a;
//        third = b;
//    }
//    else
//    {
//        second = b;
//        third = a;
//    }
//}

//Console.WriteLine(first + ", " + second + ", " + third);

//////////////////////////////////////////////////////////////////////////
//Task 4

//int a = -5;
//int b = -2;
//int c = -6;
//int d = 0;
//int e = -1;

//int max = a;

//if (b > max)
//    max = b;

//if (c > max)
//    max = c;

//if (d > max)
//    max = d;

//if (e > max)
//    max = e;

//Console.WriteLine(max);

//////////////////////////////////////////////////////////////////////////
//Task 5

//Console.WriteLine("Input kilometers per hour: ");
//double kmh = Convert.ToDouble(Console.ReadLine());

//double mph = kmh * 0.621371;

//Console.WriteLine(mph + " miles per hour");

//////////////////////////////////////////////////////////////////////////
//Task 6

//Console.WriteLine("enter the number of hours");
//int hours = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter the number of minutes");
//int minutes = Convert.ToInt32(Console.ReadLine());

//int totalMinutes = (hours * 60) + minutes;
//Console.WriteLine("the total number of minutes is " + totalMinutes);

//////////////////////////////////////////////////////////////////////////
//Task 7

//Console.WriteLine("enter the number of minutes");
//int totalMinutes = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"the number of hours is {totalMinutes / 60} and the number of minutes is {totalMinutes % 60}");

//////////////////////////////////////////////////////////////////////////
//Task 8

//string[] sentences = {"Hello", "Hi", "This is a long sentence", "Short", "Another one"};

//int length = 7;

//for (int i = 0; i < sentences.Length; i++)
//{
//    if (sentences[i].Length < length)
//    {
//        Console.WriteLine(sentences[i]);
//    }
//    else
//    {
//        Console.WriteLine(sentences[i].Substring(0, length + 1)); 
//    }
//}