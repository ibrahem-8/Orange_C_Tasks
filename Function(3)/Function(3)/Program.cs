//Task 1

//Console.WriteLine("enter first number");
//int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter seccond number");
//int number2 = Convert.ToInt32(Console.ReadLine());

//static void add(int num1, int num2)
//{
//    int sum = num1 + num2;
//    Console.WriteLine($"the sum of {num1} and {num2} is {sum}");
//}
//add(number, number2);

//////////////////////////////////////////////////////////////////////////
//Task 2

//Console.WriteLine("enter any number you want to returns it without trailing and leading zeros");
//string num = Console.ReadLine();

//static string TrimNumber(string str)
//{
//    str = str.TrimStart('0');
//    if (str == "" || str == ".")
//        return "0";

//    if (str.Contains("."))
//    {
//        int dotIndex = str.IndexOf('.');

//        string intPart = str.Substring(0, dotIndex);
//        string decPart = str.Substring(dotIndex + 1);

//        decPart = decPart.TrimEnd('0');

//        if (decPart == "")
//            return intPart;

//        return intPart + "." + decPart;
//    }
//    return str;
//}
//Console.WriteLine(TrimNumber(num)); ;

//////////////////////////////////////////////////////////////////////////
//Task 3

//int[] numbers = { 10, 40, 30, 20, 50 };

//static int secondLargest(int[] nums)
//{
//    int largest = nums[0];
//    int secondLargest = 0;

//    for (int i = 1; i < nums.Length; i++)
//    {
//        if (nums[i] > largest)
//        {
//            secondLargest = largest;
//            largest = nums[i];
//        }
//        else if (nums[i] > secondLargest && nums[i] != largest)
//        {
//            secondLargest = nums[i];
//        }
//    }
//    return secondLargest;
//}
//Console.WriteLine(secondLargest(numbers));

//////////////////////////////////////////////////////////////////////////
//Task 4

//Console.WriteLine("enter a number to check if it is repdigit or not");
//string num = Console.ReadLine(); 

//static bool isRepdigit(string str)
//{
//    char c = str[0];
//    for (int i = 1; i < str.Length; i++)
//    {
//        if (c != str[i])
//        {
//            return false;
//        }
//    }
//    return true;
//}
//Console.WriteLine(isRepdigit(num));
//////////////////////////////////////////////////////////////////////////
//Task 5

//Console.WriteLine("enter the sentence you want to reverse it");
//string sentence = Console.ReadLine();

//static string reverseSentence(string str)
//{
//    string[] words = str.Split(' ');
//    Array.Reverse(words);
//    return string.Join(" ", words);
//}
//Console.WriteLine(reverseSentence(sentence));

//////////////////////////////////////////////////////////////////////////
//Task 6

//int[] numbers = { 2, 55, 60, 9, 86 };

//static void sevenBoom(int[] nums)
//{
//        foreach (var item in nums)
//        {
//            if (item.ToString().Contains('7'))
//            {
//                Console.WriteLine("Boom!");
//                return;
//            }
//        }
//    Console.WriteLine("there is no 7 in the array");
//}
//sevenBoom(numbers);

//////////////////////////////////////////////////////////////////////////
//Task 7

//Console.WriteLine("enter any sentence to make space between words");
//string sentence = Console.ReadLine();

//static string insertWhitespace(string str)
//{
//    string result = "";
//    for (int i = 0; i < str.Length - 1; i++)
//    {
//        char s = str[i];
//        if (char.IsLower(s) && char.IsUpper(str[i+1]))
//        {
//            result += s + " ";
//        }
//        else
//        {
//            result += s;
//        }
//    }
//    result += str[str.Length - 1];
//    return result;
//}
//Console.WriteLine(insertWhitespace(sentence));

//////////////////////////////////////////////////////////////////////////
//Task 8

//bool[] bools = { true, false, false, true, false };

//static int countTrue(bool[] arr)
//{
//    int count = 0;
//    foreach (var item in arr)
//    {
//        if (item)
//        {
//            count++;
//        }
//    }
//    return count;
//}
//Console.WriteLine(countTrue(bools));

//////////////////////////////////////////////////////////////////////////
//Task 9

//Console.WriteLine("enter any string and i will sort capital letters at begin");
//string str = Console.ReadLine();

//static string sortCapitalLetters(string s)
//{
//    string capitalLetters = "";
//    string otherCharacters = "";
//    foreach (char c in s)
//    {
//        if (char.IsUpper(c))
//        {
//            capitalLetters += c;
//        }
//        else
//        {
//            otherCharacters += c;
//        }
//    }
//    return capitalLetters + otherCharacters;
//}
//Console.WriteLine(sortCapitalLetters(str));

//////////////////////////////////////////////////////////////////////////
//Task 10

//object[] strings = { 8, "thunder", true, "8thundertrue" };

//static bool matchLastItem(object[] strings)
//{
//    string result = "";

//    for (int i = 0; i < strings.Length -1; i++)
//    {
//        result += strings[i].ToString();
//    }
//    if (result.ToLower() == strings[strings.Length-1].ToString().ToLower())//we use tolower beccause when we convert bool to string it will be "True" or "False" and when we convert it to lower it will be "true" or "false" and the same for the string "thunder" when we convert it to lower it will be "thunder" so we can compare them without case sensitivity
//    {
//        return true;
//    }
//    return false;
//}
//Console.WriteLine(matchLastItem(strings));

//////////////////////////////////////////////////////////////////////////
//Task 11

//double[] objs = {1, 2, double.NaN};
//static int findNaN(double[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (double.IsNaN(arr[i]))
//        {
//            return i;
//        }
//    }
//    return -1;
//}
//Console.WriteLine(findNaN(objs));
//////////////////////////////////////////////////////////////////////////
//Task 12

//object[] arr = {"John", "Taylor", "John"};

//static object[] removeDups(object[] items)
//{
//    List<object> result = new List<object>();
//    foreach (var item in items)
//    {
//        if (!result.Contains(item))
//        {
//            result.Add(item);
//        }
//    }
//    return result.ToArray();
//}
//object[] newArr = removeDups(arr);
//foreach (var item in newArr)
//{
//    Console.WriteLine(item);
//}

//////////////////////////////////////////////////////////////////////////
//Task 13

//string dateTime = "07:05:45PM";

//static string convertTime(string time)
//{
//    string period = time.Substring(time.Length - 2);
//    string timePart = time.Substring(0, time.Length - 2);

//    int hour = int.Parse(timePart.Substring(0, 2));

//    if (period == "AM")
//    {
//        if (hour == 12)
//            hour = 0;
//    }
//    else
//    {
//        if (hour != 12)
//            hour += 12;
//    }

//    return hour.ToString("D2") + timePart.Substring(2);
//}
//Console.WriteLine(convertTime(dateTime));
//////////////////////////////////////////////////////////////////////////
//Task 14

//string str = "Those who dare to fail miserably can achieve greatly.";

//static string removeLastVowel(string str)
//{
//    string[] words = str.Split(" ");

//    for (int i = 0; i < words.Length; i++)
//    {
//        string word = words[i];

//        for (int j = word.Length - 1; j >= 0; j--)
//        {
//            char c = word[j];

//            if ("aeiouAEIOU".Contains(c))
//            {
//                word = word.Remove(j, 1);
//                break;
//            }
//        }
//        words[i] = word;
//    }

//    return string.Join(" ", words);
//}
//Console.WriteLine(removeLastVowel(str));

//////////////////////////////////////////////////////////////////////////
//Task 15

//int[] numbers = {3, 4, 5};

//static int sumOfCubes(int[] nums)
//{
//    int sum = 0;
//    foreach (var item in nums)
//    {
//        sum += item * item * item;
//    }
//    return sum;
//}
//Console.WriteLine(sumOfCubes(numbers));