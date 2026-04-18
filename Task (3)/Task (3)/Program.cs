//Task 1

//Q:
//1-	Correct the syntax error:
//•	string [ ] ARR= [ 1,7  9  45, ]
//•	int arr2=["Str" "alex","moh"
//•	string arr3= 'the','fox' 'over' lazy, 'dog',  ]

//solution:

//int[] ARR = { 1, 7, 9, 45 };
//string[] arr2 = { "Str", "alex", "moh" };
//string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

//////////////////////////////////////////////////////////////////
//Task 2

//Q:
//2 - What the index of "Banana","Tomato"?
//String [ ] fruits = ["Tomato", "Banana", "Watermelon"]

//solution:

//1 / 0 is the endex if these words in the array

//////////////////////////////////////////////////////////////////
//Task 3

//Q:
//3 - Create an multiple arrays that represents your:
//•	Favorite Food(5 item)
//•	Favorite Sport(3 item)
//•	Favorite Movie(4 item)
//Then, print each array using foreach, and Loop Through an Array

//solution:

//string[] favoriteFood = { "Pizza", "Burger", "Pasta", "Sushi", "Ice Cream" };
//string[] favoriteSport = { "Football", "Basketball", "Tennis" };
//string[] favoriteMovie = { "Inception", "The Dark Knight", "Interstellar", "The Matrix" };

//Console.WriteLine("Favorite Food:");
//foreach (string food in favoriteFood)
//{
//    Console.WriteLine(food);
//}
//Console.WriteLine("Favorite Sport:");
//foreach (string sport in favoriteSport)
//{
//    Console.WriteLine(sport);
//}
//Console.WriteLine("Favorite Movie:");
//foreach (string movie in favoriteMovie)
//{
//    Console.WriteLine(movie);
//}

//////////////////////////////////////////////////////////////////
//Task 4

//Console.WriteLine("enter three numbers separated by a comma to sum it");
//string input = Console.ReadLine();
//string[] numbers = input.Split(',');
//int sum = 0;
//foreach (string number in numbers)
//{
//    sum += int.Parse(number.Trim());
//}
//Console.WriteLine("The sum of the numbers is: " + sum);

//////////////////////////////////////////////////////////////////
//Task 5

//int sum = 0;
//for (int i = 1; i <= 100; i++)
//{
//    if (i % 2 != 0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine("The sum of odd numbers from 1 to 100 is: " + sum);

//////////////////////////////////////////////////////////////////
//Task 6

//int rows = 3;

//for (int i = 1; i <= rows; i++)
//{
//    for (int j = i; j < rows; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*" + " ");
//    }
//    Console.WriteLine();
//}

//////////////////////////////////////////////////////////////////
//Task 7

//int rows = 4;
//int num = 1;

//for (int i = 1; i <= rows; i++)
//{
//    for (int j = i; j < rows; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(num + " ");
//        num++;
//    }
//    Console.WriteLine();
//}