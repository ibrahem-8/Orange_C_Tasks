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

//List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
//List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

//var commonNumbers = list1.Intersect(list2);

//Console.WriteLine("Common numbers:");
//foreach (var num in commonNumbers)
//{
//    Console.WriteLine(num);
//}

///////////////////////////////////////////////////////////////////////////
//*Task 22 + 23

//List<int> list1 = new List<int> { 1, 2, 3 };
//List<int> list2 = new List<int> { 3, 4, 5 };

//var mergedList = list1.Concat(list2).Distinct();

//Console.WriteLine("Merged List: ");
//foreach (var num in mergedList)
//{
//    Console.WriteLine(num);
//}

//////////////////////////////////////////////////////////////////////////////
//*Task 24

//Dictionary<int, string> dict = new Dictionary<int, string>
//        {
//            {1, "Apple"},
//            {2, "Banana"},
//            {3, "Orange"}
//        };

//List<string> valuesList = dict.Values.ToList();

//Console.WriteLine("Values in List:");
//foreach (var value in valuesList)
//{
//    Console.WriteLine(value);
//}

////////////////////////////////////////////////////////////////////////////
//*Task 25

//Dictionary<string, int> dict = new Dictionary<string, int>
//        {
//            {"A", 50},
//            {"B", 120},
//            {"C", 200},
//            {"D", 80}
//        };

//var filteredDict = dict.Where(x => x.Value > 100).ToDictionary(x => x.Key, x => x.Value);

//foreach (var item in filteredDict)
//{
//    Console.WriteLine($"{item.Key} : {item.Value}");
//}

////////////////////////////////////////////////////////////////////////////
//*Task 26

//List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
//int target = 30;

//bool found = false;

//foreach (var num in numbers)
//{
//    if (num == target)
//    {
//        found = true;
//        break;
//    }
//}

//if (found)
//    Console.WriteLine("Number found");
//else
//    Console.WriteLine("Number not found");

/////////////////////////////////////////////////////////////////////////
//*Task 27

//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

//int countEven = 0;

//foreach (var num in numbers)
//{
//    if (num % 2 == 0)
//    {
//        countEven++;
//    }
//}

//Console.WriteLine("Even numbers count: " + countEven);

//////////////////////////////////////////////////////////////////////////
//*Task 29

//List<int> numbers = new List<int> { 10, 5, 20, 8, 15 };

//int max = numbers[0];
//int secondMax = numbers[0];

//foreach (var num in numbers)
//{
//    if (num > max)
//    {
//        secondMax = max;
//        max = num;
//    }
//    else if (num > secondMax && num != max)
//    {
//        secondMax = num;
//    }
//}

//Console.WriteLine("Second Largest: " + secondMax);

//////////////////////////////////////////////////////////////////////
//*Task 1

//int[] numbers = { 1, 3, 2, 3, 4, 3, 2, 1, 3 };

//int maxCount = 0;
//int mostFrequent = numbers[0];

//for (int i = 0; i < numbers.Length; i++)
//{
//    int count = 0;

//    for (int j = 0; j < numbers.Length; j++)
//    {
//        if (numbers[i] == numbers[j])
//        {
//            count++;
//        }
//    }

//    if (count > maxCount)
//    {
//        maxCount = count;
//        mostFrequent = numbers[i];
//    }
//}

//Console.WriteLine("Most frequent number: " + mostFrequent);
//Console.WriteLine("Count: " + maxCount);

//////////////////////////////////////////////////////////////////////
//*Task 3

//int[] arr = { 1, 2, 3, 2, 1 };

//bool isMirror = true;

//for (int i = 0; i < arr.Length / 2; i++)
//{
//    if (arr[i] != arr[arr.Length - 1 - i])
//    {
//        isMirror = false;
//        break;
//    }
//}

//Console.WriteLine(isMirror ? "True" : "False");

///////////////////////////////////////////////////////////////////////
//*Task 4

//int[] arr = { 1, 2, 4, 5 };

//int missing = -1;

//for (int i = 1; i <= arr.Length + 1; i++)
//{
//    bool found = false;

//    for (int j = 0; j < arr.Length; j++)
//    {
//        if (arr[j] == i)
//        {
//            found = true;
//            break;
//        }
//    }

//    if (!found)
//    {
//        missing = i;
//        break;
//    }
//}

//Console.WriteLine("Missing Number: " + missing);

/////////////////////////////////////////////////////////////////////////
//*Task 8

//int[] arr = { 3, 1, 2, 4, 7, 6, 5 };

//List<int> evens = new List<int>();
//List<int> odds = new List<int>();

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//        evens.Add(arr[i]);
//    else
//        odds.Add(arr[i]);
//}

//List<int> result = new List<int>();
//result.AddRange(evens);
//result.AddRange(odds);

//Console.WriteLine(string.Join(", ", result));

/////////////////////////////////////////////////////////////////////////////
//*Task 11

//int[] arr = { 0, 1, 0, 3, 12 };

//int insertPos = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] != 0)
//    {
//        arr[insertPos] = arr[i];
//        insertPos++;
//    }
//}

//for (int i = insertPos; i < arr.Length; i++)
//{
//    arr[i] = 0;
//}

//Console.WriteLine(string.Join(", ", arr));