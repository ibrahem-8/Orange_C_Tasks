//Task 1 (with)

//static int GetDays(DateTime date1, DateTime date2)
//{
//    return Math.Abs((date2 - date1).Days);
//}

//Console.WriteLine(GetDays(
//    new DateTime(2019, 6, 14),
//    new DateTime(2019, 6, 20)
//)); 

//Console.WriteLine(GetDays(
//    new DateTime(2018, 12, 29),
//    new DateTime(2019, 1, 1)
//));
//////////////////////////////////////////////////////////
//Task 2

//string[] strings = { "1a", "a", "2b", "b" };

//static void stringWithNums(string[] names)
//{
//    List<string> result = new List<string>();
//    foreach (string item in names)
//    {
//        foreach (char item1 in item)
//        {
//            if (char.IsDigit(item1))
//            {
//                result.Add(item);
//                break;
//            }
//        }
//    }
//    result.ToArray();
//    foreach (var item in result)
//    {
//        Console.WriteLine(item);
//    }
//}
//stringWithNums(strings);

// Another solution (with)

//static string[] stringWithNums(string[] arr)
//{
//    return arr.Where(s => s.Any(char.IsDigit)).ToArray();
//}

//var result1 = stringWithNums(strings);
//Console.WriteLine(string.Join(", ", result1));

///////////////////////////////////////////////////////////////
//Task 3

//Console.WriteLine("enter any word");
//string anyWord = Console.ReadLine();

//static void reverseOdd(string word)
//{
//    if (word.Length % 2 != 0)
//    {
//Console.WriteLine(word.Reverse().ToArray());

//The better way to print is 
//        string reversed = new string(word.Reverse().ToArray());// we need to convert the reversed char array to string
//        Console.WriteLine(reversed);
//    }
//    else
//    {
//        Console.WriteLine(word);
//    }
//}

//reverseOdd(anyWord);
///////////////////////////////////////////////////////////////
//Task 4

//static bool IsPandigital(long num)
//{
//    string numStr = num.ToString();
//    for (char digit = '0'; digit <= '9'; digit++)
//    {
//        if (!numStr.Contains(digit))
//        {
//            Console.WriteLine($"{digit} is missing");
//            return false;
//        }
//    }
//    return true;
//}

//Console.WriteLine(IsPandigital(8140756810));