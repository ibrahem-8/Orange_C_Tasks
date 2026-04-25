using System.Linq;
//*Task 1

//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

//List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

//foreach (var num in evenNumbers)
//{
//    Console.WriteLine(num);
//}

/////////////////////////////////////////////////////////////////////////
//*Task 2

//List<int> numbers = new List<int> { 1, 2, 3, 4, 2, 6, 1, 3 };

//numbers = numbers.Distinct().ToList();

//foreach (var num in numbers)
//{
//    Console.WriteLine(num);
//}

/////////////////////////////////////////////////////////////////////////
//*Task 3

//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

//int max = numbers.Max();
//Console.WriteLine($"The maximum number is: {max}");

/////////////////////////////////////////////////////////////////////////
//*Task 4

//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

//var reversed = numbers.Reverse();// *why error?
//numbers.Reverse();
//foreach (var num in numbers)
//{
//    Console.WriteLine(num);
//}

/////////////////////////////////////////////////////////////////////////
//*Task 5

//List<int> numbers = new List<int> { 50, 30, 78, 90, 111 };

//var greater50 = numbers.Where(n => n > 50);

//foreach (var num in greater50)
//{
//    Console.WriteLine(num);
//}

/////////////////////////////////////////////////////////////////////////
//*Task 6

//Dictionary<string, int> nameScore = new Dictionary<string, int>
//{
//    { "Alice", 30 },
//    { "Bob", 88 },
//    { "Charlie", 100 },
//    { "David", 28 }
//};

//var highScorers = nameScore.Where(kv => kv.Value > 80);

//foreach (var kv in highScorers)
//{
//    Console.WriteLine($"{kv.Key}: {kv.Value}");
//}

///////////////////////////////////////////////////////////////////////
//*Task 7 (with)

//Dictionary<string, int> nameScore = new Dictionary<string, int>
//{
//    { "Alice", 30 },
//    { "Bob", 88 },
//    { "Charlie", 100 },
//    { "David", 28 }
//};

//Console.WriteLine("enter the name");
//string name = Console.ReadLine();

//if (nameScore.TryGetValue(name, out int score))
//{
//    Console.WriteLine($"{name}: {score}");
//}
//else
//{
//    Console.WriteLine("Name not found.");
//}

////////////////////////////////////////////////////////////////////////////
//*Task 8

//Dictionary<string, int> nameScore = new Dictionary<string, int>
//{
//    { "Alice", 30 },
//    { "Bob", 88 },
//    { "Charlie", 100 },
//    { "David", 28 }
//};

//int totalScore = nameScore.Values.Sum();
//Console.WriteLine($"Total Score: {totalScore}");

////////////////////////////////////////////////////////////////////////////
//*Task 9

//Dictionary<string, int> nameScore = new Dictionary<string, int>
//{
//    { "Alice", 30 },
//    { "Bob", 88 },
//    { "Charlie", 100 },
//    { "David", 28 }
//};

//foreach (var item in nameScore)
//{
//    if (item.Value < 50)
//    {
//        nameScore.Remove(item.Key);
//    }
//}

//foreach (var item in nameScore)
//{
//    Console.WriteLine($"{item.Key}: {item.Value}");
//}

///////////////////////////////////////////////////////////////////////////
//*Task 10

//Dictionary<string, int> nameScore = new Dictionary<string, int>
//{
//    { "Alice", 30 },
//    { "Bob", 88 },
//    { "Charlie", 100 },
//    { "David", 28 }
//};

//var topStudent = nameScore.OrderByDescending(kv => kv.Value).First();
//Console.WriteLine($"Top Student: {topStudent.Key} with score {topStudent.Value}");

///////////////////////////////////////////////////////////////////////////
//*Task 11 + 12 + 13 + 14 + 15

//LinkedList<string> pages = new LinkedList<string>();

//pages.AddFirst("Page first");
//pages.AddLast("Page second");
//pages.AddLast("Page last");

//pages.Remove("Page second");

//pages.AddAfter(pages.First, "Page after first");
//pages.AddBefore(pages.Last, "Page before last");

//foreach (var page in pages)
//{
//    Console.WriteLine(page);
//}

//Console.WriteLine(pages.First());
//Console.WriteLine(pages.Last());

///////////////////////////////////////////////////////////////////////////
//*Task 16

//List<int> ints = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

//var oddNums = ints.Where(n => n % 2 != 0);

//foreach (var num in oddNums)
//{
//    Console.WriteLine(num);
//}

//////////////////////////////////////////////////////////////////////////////
//*Task 17

//List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//var multiNums = ints.Select(n => n * 2);

//foreach (var num in multiNums)
//{
//    Console.WriteLine(num);
//}

///////////////////////////////////////////////////////////////////////////
//*Task 18

//List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//var sortedDec = ints.OrderByDescending(n => n);

//foreach (var num in sortedDec)
//{
//    Console.WriteLine(num);
//}

///////////////////////////////////////////////////////////////////////////
//*Task 19

//List<int> ints = new List<int>() { 10, 500, -20, 77, 80, 998, 100 };

//int fNumGreaterThan100 = ints.Where(n => n > 100).FirstOrDefault();

//Console.WriteLine(fNumGreaterThan100);

///////////////////////////////////////////////////////////////////////////
//*Task 20

//List<int> ints = new List<int>() { 10, 500, -20, 77, 80, 998, 100 };

//double avg = ints.Average();
//Console.WriteLine($"Average: {avg}");

///////////////////////////////////////////////////////////////////////////
//*Task 21

