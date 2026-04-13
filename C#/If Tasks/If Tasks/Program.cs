//*Task 1

//Console.WriteLine("enter your name");
//string name = Console.ReadLine();
//Console.WriteLine("enter your age");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"My name is {name} and I am {age} years old");
//////////////////////////////////////////////////////////////////////////
//*Task 2

//Console.WriteLine("enter a num to check");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num % 2 == 0)
//{
//    Console.WriteLine($"{num} is even");
//}
//else
//{
//    Console.WriteLine($"{num} is odd");
//}
//////////////////////////////////////////////////////////////////////////
//*Task 3

//Console.WriteLine("enter the string to reapeat it");
//string str = Console.ReadLine();
//Console.WriteLine($"you write {str}");
//////////////////////////////////////////////////////////////////////////
//*Task 4

//Console.WriteLine("enter the number");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num > 0)
//{
//    Console.WriteLine($"{num} is positive");
//}
//else if (num < 0)
//{
//    Console.WriteLine($"{num} is negative");
//}
//else
//{
//    Console.WriteLine($"{num} is zero");
//}
//////////////////////////////////////////////////////////////////////////
//*Task 5

//Console.WriteLine("enter the year");
//int year = Convert.ToInt32(Console.ReadLine());
//if (DateTime.IsLeapYear(year))
//{
//    Console.WriteLine($"{year} is a leap year");
//}
//else
//{
//    Console.WriteLine($"{year} is not a leap year");
//}
//////////////////////////////////////////////////////////////////////////
//*Task 6

//Console.WriteLine("enter your grade between 0-100");
//int grade = Convert.ToInt32(Console.ReadLine());
//if (grade >= 50)
//{
//    Console.WriteLine("you passed");
//}
//else
//{
//    Console.WriteLine("you failed");
//}
//////////////////////////////////////////////////////////////////////////
//*Task 7

//Console.WriteLine("enter the first number");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter the second number");
//int num2 = Convert.ToInt32(Console.ReadLine());
//if (num1 > num2)
//{
//    Console.WriteLine($"{num1} is greater than {num2}");
//}
//else if (num1 < num2)
//{
//    Console.WriteLine($"{num2} is greater than {num1}");
//}
//else
//{
//    Console.WriteLine($"{num1} and {num2} are equal");
//}
//////////////////////////////////////////////////////////////////////////
//*Task 8

//Console.WriteLine("enter the number");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num % 3 == 0 && num % 5 == 0)
//{
//    Console.WriteLine($"{num} is divisible by both 3 and 5");
//}
//else if (num % 3 == 0)
//{
//    Console.WriteLine($"{num} is divisible by 3");
//}
//else if (num % 5 == 0)
//{
//    Console.WriteLine($"{num} is divisible by 5");
//}
//else
//{
//    Console.WriteLine($"{num} is not divisible by either 3 or 5");
//}
//////////////////////////////////////////////////////////////////////////
//*Task 9

//Console.Write("Enter a character: ");
//char ch = Convert.ToChar(Console.ReadLine().ToLower());

//if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
//{
//    Console.WriteLine("Vowel");
//}
//else
//{
//    Console.WriteLine("Consonant");
//}
//////////////////////////////////////////////////////////////////////////
//*Task 10

//Console.WriteLine("enter your age");
//int age = Convert.ToInt32(Console.ReadLine());
//if (age <= 12)
//{
//    Console.WriteLine("child");
//}
//else if (age <= 19)
//{
//    Console.WriteLine("teenager");
//}
//else if(age >= 20)
//{
//    Console.WriteLine("adult");
//}
//else
//{
//    Console.WriteLine("invalid age");
//}
//////////////////////////////////////////////////////////////////////////
//*Task 11

//Console.WriteLine("enter the number of day in the week");
//int day = Convert.ToInt32(Console.ReadLine());
//switch (day)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//    default:
//        Console.WriteLine("invalid day number");
//        break;
//}
//////////////////////////////////////////////////////////////////////////
//*Task 12

//Console.WriteLine("enter the number of month");
//int month = Convert.ToInt32(Console.ReadLine());
//switch (month)
//{
//    case 1:
//        Console.WriteLine("January");
//        break;
//    case 2:
//        Console.WriteLine("February");
//        break;
//    case 3:
//        Console.WriteLine("March");
//        break;
//    case 4:
//        Console.WriteLine("April");
//        break;
//    case 5:
//        Console.WriteLine("May");
//        break;
//    case 6:
//        Console.WriteLine("June");
//        break;
//    case 7:
//        Console.WriteLine("July");
//        break;
//    case 8:
//        Console.WriteLine("August");
//        break;
//    case 9:
//        Console.WriteLine("September");
//        break;
//    case 10:
//        Console.WriteLine("October");
//        break;
//    case 11:
//        Console.WriteLine("November");
//        break;
//    case 12:
//        Console.WriteLine("December");
//        break;
//    default:
//        Console.WriteLine("invalid month number");
//        break;
//}
//////////////////////////////////////////////////////////////////////////
//*Task 13

//Console.WriteLine("enter first number");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter second number");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter the operator (+, -, *, /)");
//char op = Convert.ToChar(Console.ReadLine());
//switch (op)
//{
//    case '+':
//        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
//        break;
//    case '-':
//        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
//        break;
//    case '*':
//        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
//        break;
//    case '/':
//        if (num2 != 0)
//        {
//            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
//        }
//        else
//        {
//            Console.WriteLine("Cannot divide by zero");
//        }
//        break;
//    default:
//        Console.WriteLine("invalid operator");
//        break;
//}
//////////////////////////////////////////////////////////////////////////
//*Task 14

//Console.WriteLine("enter your grade");
//int grade = Convert.ToInt32(Console.ReadLine());
//switch (grade)
//{
//    case (>= 90):
//        Console.WriteLine("A");
//        break;
//    case (>= 80):
//        Console.WriteLine("B");
//        break;
//    case (>= 65):
//        Console.WriteLine("C");
//        break;
//    case (>= 50):
//        Console.WriteLine("D");
//        break;
//    default:
//        Console.WriteLine("F");
//        break;
//}
//////////////////////////////////////////////////////////////////////////
//*Task 15

//Console.WriteLine("enter 1 or 2 or 3");
//int choice = Convert.ToInt32(Console.ReadLine());
//switch (choice)
//{
//    case 1:
//        Console.WriteLine("you chose option 1");
//        break;
//    case 2:
//        Console.WriteLine("you chose option 2");
//        break;
//    case 3:
//        Console.WriteLine("you chose option 3");
//        break;
//    default:
//        Console.WriteLine("invalid choice");
//        break;
//}
//////////////////////////////////////////////////////////////////////////
//*Task 16

//Console.WriteLine("enter a num");
//int num = Convert.ToInt32(Console.ReadLine());
//switch (num % 2)
//{
//    case 0:
//        Console.WriteLine($"{num} is even");
//        break;
//    case 1:
//        Console.WriteLine($"{num} is odd");
//        break;
//    default:
//        Console.WriteLine("invalid number");
//        break;
//}
//////////////////////////////////////////////////////////////////////////
//*Task 17

//Console.WriteLine("what is your role (Admin, User, Guest)");
//string role = Console.ReadLine().ToLower();
//switch (role)
//{
//    case "admin":
//        Console.WriteLine("you have full access");
//        break;
//    case "user":
//        Console.WriteLine("you have limited access");
//        break;
//    case "guest":
//        Console.WriteLine("you have no access");
//        break;
//    default:
//        Console.WriteLine("invalid role");
//        break;
//}
//////////////////////////////////////////////////////////////////////////
//*Task 18

//Console.WriteLine("=== Restaurant Menu ===");
//Console.WriteLine("1. Burger");
//Console.WriteLine("2. Pizza");
//Console.WriteLine("3. Shawarma");
//Console.WriteLine("4. Exit");

//Console.Write("Choose your meal: ");
//int choice = Convert.ToInt32(Console.ReadLine());

//switch (choice)
//{
//    case 1:
//        Console.WriteLine("You choose Burger - Price: 5 JD");
//        break;

//    case 2:
//        Console.WriteLine("You choose Pizza - Price: 7 JD");
//        break;

//    case 3:
//        Console.WriteLine("You choose Shawarma - Price: 3 JD");
//        break;

//    case 4:
//        Console.WriteLine("Thank you!");
//        break;

//    default:
//        Console.WriteLine("Invalid choice");
//        break;
//}
//////////////////////////////////////////////////////////////////////////
///If Statements – Advanced  Questions
/////////////////////////////////////////////////////////////////////////
//*Task 1

//Console.WriteLine("enter your salary");
//double salary = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("enter your degree");
//int deg = Convert.ToInt32(Console.ReadLine());
//double bounes;
//if (deg >= 90)
//{
//    Console.WriteLine("Excellent");
//    bounes = salary * 0.2;
//    Console.WriteLine(salary + bounes);
//}
//else if (deg >= 75 && deg <= 89)
//{
//    Console.WriteLine("Very Good");
//    bounes = salary * 0.15;
//    Console.WriteLine(salary + bounes);
//}
//else if (deg >= 60 && deg <= 74)
//{
//    Console.WriteLine("Good");
//    bounes = salary * 0.1;
//    Console.WriteLine(salary + bounes);
//}
//else if (deg < 60)
//{
//    Console.WriteLine("Needs Improvement");
//    Console.WriteLine(salary);
//}
//else
//{
//    Console.WriteLine("invalid input");
//}
//////////////////////////////////////////////////////////////
//*Task 2 
//Console.WriteLine("Enter your GPA in 100");
//double gpa = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("DO you pass the english exam(yes/no)");
//string english = Console.ReadLine().ToLower();
//Console.WriteLine("DO you have special recommendation(yes/no)");
//string recommendation = Console.ReadLine().ToLower();

//if ((gpa >= 85 && english == "yes") || recommendation == "yes")
//{
//    Console.WriteLine("you are accepted");
//}
//else
//{
//    Console.WriteLine("you are rejected");
//}
//////////////////////////////////////////////////////////////
//*Task 3

//Console.WriteLine("enter the Weight of the product");
//double weight = Convert.ToDouble(Console.ReadLine());

//if (weight <= 1)
//{
//    Console.WriteLine("the cost of shipping is 5$");
//}
//else if (weight > 1 && weight <= 5)
//{
//    Console.WriteLine("the cost of shipping is 10$");
//}
//else if (weight > 5 && weight <= 10)
//{
//    Console.WriteLine("the cost of shipping is 20$");
//}
//else if (weight > 10)
//{
//    Console.WriteLine("the cost of shipping is 50$ and this is Heavy package");
//}
//else
//{
//    Console.WriteLine("invalid weight");
//}
//////////////////////////////////////////////////////////////
//*Task 4

//string correctUsername = "admin";
//string correctPassword = "1234";
//int attempts = 0;

//while (true)
//{
//    Console.Write("Enter username: ");
//    string username = Console.ReadLine();

//    Console.Write("Enter password: ");
//    string password = Console.ReadLine();

//    if (attempts >= 3)
//    {
//        Console.WriteLine("Account locked");
//        break;
//    }

//    if (username == correctUsername && password == correctPassword)
//    {
//        Console.WriteLine("Login successful");
//        break;
//    }
//    else
//    {
//        attempts++;
//        Console.WriteLine("Invalid credentials");
//    }
//}
//////////////////////////////////////////////////////////////////////////
///Switch Statements – Advanced  Questions
/////////////////////////////////////////////////////////////////////////
//*Task 1

//Console.WriteLine("=== Restaurant Menu ===");
//Console.WriteLine("1. Burger");
//Console.WriteLine("2. Pizza");
//Console.WriteLine("3. Pasta");
//Console.WriteLine("4. Salad ");

//Console.Write("Choose your meal: ");
//int choice = Convert.ToInt32(Console.ReadLine());

//switch (choice)
//{
//    case 1:
//        Console.WriteLine("You choose Burger - Price: 5$");
//        break;

//    case 2:
//        Console.WriteLine("You choose Pizza - Price: 8$");
//        break;

//    case 3:
//        Console.WriteLine("You choose Pasta - Price: 7$");
//        break;

//    case 4:
//        Console.WriteLine("You choose Salad - Price: 4$");
//        break;

//    default:
//        Console.WriteLine("Invalid choice");
//        break;
//}
/////////////////////////////////////////////////////////////////////////
//*Task 2

//Console.WriteLine("enter your grade");
//string grade = Console.ReadLine().ToUpper();

//switch (grade)
//{
//    case "A":
//        Console.WriteLine("Excellent");
//        break;
//    case "B":
//        Console.WriteLine("Very Good");
//        break;
//    case "C":
//        Console.WriteLine("Good");
//        break;
//    case "D":
//        Console.WriteLine("Pass");
//        break;
//    case "F":
//        Console.WriteLine("Fail");
//        break;
//    default:
//        Console.WriteLine("Invalid grade");
//        break;
//}
/////////////////////////////////////////////////////////////////////////
//*Task 3

//Console.WriteLine("=== ATM System ===");
//Console.WriteLine("1. Check Balance");
//Console.WriteLine("2. Deposit Money");
//Console.WriteLine("3. Withdraw Money");
//Console.WriteLine("4. Exit");

//Console.Write("what you want to do ");
//int choice = Convert.ToInt32(Console.ReadLine());

//switch (choice)
//{
//    case 1:
//        Console.WriteLine("your balance is 1000$");
//        break;
//    case 2:
//        Console.WriteLine("you deposit 500$");
//        Console.WriteLine("your new balance is 1500$");
//        break;
//    case 3:
//        Console.WriteLine("you withdraw 200$");
//        Console.WriteLine("your new balance is 800$");
//        break;
//    case 4:
//        Console.WriteLine("Thank you for using our ATM!");
//        break;
//    default:
//        Console.WriteLine("Invalid choice");
//        break;
//}
/////////////////////////////////////////////////////////////////////////
//*Task 4

//Console.WriteLine("enter first num");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter second num");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter the operator (+, -, *, /)");
//char op = Convert.ToChar(Console.ReadLine());

//switch (op)
//{
//    case '+':
//        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
//        break;
//    case '-':
//        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
//        break;
//    case '*':
//        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
//        break;
//    case '/':
//        if (num2 != 0)
//        {
//            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
//        }
//        else
//        {
//            Console.WriteLine("Cannot divide by zero");
//        }
//        break;
//    default:
//        Console.WriteLine("invalid operator");
//        break;
//}
Console.WriteLine("Hi All");