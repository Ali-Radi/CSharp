namespace C_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  1- asks the user to enter a number, then prints it
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine(x);
            #endregion

            #region 2- Convert a string containing non - numeric characters to an integer
            //string str = "abc";
            //int x = int.Parse(str);
            // throw an exeption 
            #endregion

            #region 3- Perform a simple arithmetic operation using floating-point numbers
            //float x= 5, y= 10;
            //Console.WriteLine(x+y);
            #endregion

            #region 4- Extract a substring from a given string
            //string str = "Ali Radi";
            //string sub = str.Substring(0, 3);
            //Console.WriteLine(sub);  //print=> Ali
            #endregion

            #region 5
            //int x = 5;
            //int y = x;
            //x++;
            //Console.WriteLine(y); //print 5 no changing
            #endregion

            #region 6
            //int[] x = { 1, 2, 3 };
            //var y = x;
            //x[1] = 5;
            //Console.WriteLine(y[1]);   //print 5 because they are the same refernce
            #endregion

            #region 7
            //string str1 = "Hello";
            //string str2 = "World";
            //Console.WriteLine($"{str1} {str2}");
            #endregion

            #region 8- Calculate simple interest
            //double principal = 1000, rate = 5, time = 2;
            //double interest = (principal * rate * time) / 100;
            //Console.WriteLine(interest); //print 100
            #endregion

            #region 9- Calculate BMI
            //double weight = 75, height = 1.75;
            //double bmi = weight / (height * height);
            //Console.WriteLine(bmi);
            #endregion

            #region 10- Ternary operator to classify temperature
            //int temp = 25;
            //string status = temp < 10 ? "Just Cold" : temp > 30 ? "Just Hot" : "Just Good";
            //Console.WriteLine(status); //print Just Good
            #endregion

            #region 11- Read a date and display it in formats
            //Console.Write("Day: ");
            //int day = int.Parse(Console.ReadLine());
            //Console.Write("Month: ");
            //int month = int.Parse(Console.ReadLine());
            //Console.Write("Year: ");
            //int year = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Today's date : {day} , {month} , {year}");
            //Console.WriteLine($"Today's date : {day} / {month} / {year}");
            //Console.WriteLine($"Today's date : {day} - {month} - {year}");
            #endregion

            #region 12- Divisible by both 3 and 4
            //int num = int.Parse(Console.ReadLine());
            //if (num % 3 == 0 && num % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            #endregion

            #region 13- Negative or Positive
            //int num = int.Parse(Console.ReadLine());
            //if (num < 0)
            //    Console.WriteLine("Negative");
            //else
            //    Console.WriteLine("Positive");
            #endregion

            #region 14- Max and Min of three integers
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //int max = Math.Max(a, Math.Max(b, c));
            //int min = Math.Min(a, Math.Min(b, c));
            //Console.WriteLine($"Max element = {max}");
            //Console.WriteLine($"Min element = {min}");
            #endregion

            #region 15- Even or Odd
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
            #endregion

            #region 16- Vowel or Consonant
            //char ch = char.ToLower(char.Parse(Console.ReadLine()));
            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //    Console.WriteLine("Vowel");
            //else
            //    Console.WriteLine("Consonant");
            #endregion

            #region 17- Number of days in a month
            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 4: case 6: case 9: case 11:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 2:
            //        Console.WriteLine("Days in Month: 28");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Month");
            //        break;
            //}
            #endregion

            #region 18- Print all numbers from 1 to n
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion

            #region 19- Multiplication table up to 12
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(num * i + " ");
            //}
            #endregion

            #region 20- Even numbers between 1 and n
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= n; i += 2)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion

            #region 21- Calculate power using loop
            //int Num = int.Parse(Console.ReadLine());
            //int exp = int.Parse(Console.ReadLine());
            //int result = 1;
            //for (int i = 0; i < exp; i++)
            //{
            //    result *= Num;
            //}
            //Console.WriteLine(result);
            #endregion

            #region 22- Marks of five subjects
            //int total = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    total += int.Parse(Console.ReadLine());
            //}
            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100;
            //Console.WriteLine($"Total marks = {total}");
            //Console.WriteLine($"Average Marks = {average}");
            //Console.WriteLine($"Percentage = {percentage}");
            #endregion

            #region 23- Print string in reverse order
            //string str = Console.ReadLine();
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(str[i]);
            //}
            #endregion

            #region 24- Print integer digits in reverse order
            //int num = int.Parse(Console.ReadLine());
            //int reversed = 0;
            //while (num != 0)
            //{
            //    reversed = reversed * 10 + (num % 10);
            //    num /= 10;
            //}
            //Console.WriteLine(reversed);
            #endregion

            #region 25- Prime numbers within a range
            //int start = int.Parse(Console.ReadLine());
            //int end = int.Parse(Console.ReadLine());
            //var isPrime = (int n) => {
            //    if (n <= 1) return false;
            //    if (n==2||n==3)
            //    {
            //        return true;
            //    }
            //    for (int i = 2; i* i  <= n; i++)
            //    {
            //        if (n%i==0)
            //        {
            //            return false;
            //        }
            //    }
            //    return true;
            //};
            //for (int i = start; i <= end; i++)
            //{
            //    if (isPrime(i)) Console.Write(i + " ");
            //}
            #endregion

            #region 26- Convert decimal to binary without array
            //int num = int.Parse(Console.ReadLine());
            //string binary = "";
            //while (num > 0)
            //{
            //    binary = (num % 2) + binary;
            //    num /= 2;
            //}
            //Console.WriteLine(binary);
            #endregion

            #region 27- Three points on one straight line
            //double x1 = double.Parse(Console.ReadLine()), y1 = double.Parse(Console.ReadLine());
            //double x2 = double.Parse(Console.ReadLine()), y2 = double.Parse(Console.ReadLine());
            //double x3 = double.Parse(Console.ReadLine()), y3 = double.Parse(Console.ReadLine());

            //// Cross-multiplication avoids division by zero
            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //    Console.WriteLine("Points lie on a single straight line.");
            //else
            //    Console.WriteLine("Points do NOT lie on a straight line.");
            #endregion

            #region 28- n x n identity matrix
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(i == j ? "1 " : "0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 29- Sum of all elements in an array
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int sum = 0;
            //foreach (var item in arr) sum += item;
            //Console.WriteLine(sum);
            #endregion

            #region 30- Merge two arrays of same size in ascending order
            //int[] arr1 = { 1, 5, 3 };
            //int[] arr2 = { 4, 2, 6 };
            //var merged = new List<int>();

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    merged.Add(arr1[i]);
            //}
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    merged.Add(arr2[i]);
            //}
            //merged.Sort();

            #endregion

            #region 31- Frequency of each distinct element
            //int[] arr = { 1, 2, 2, 3, 1, 4, 2 };
            //var counts = new Dictionary<int, int>();

            //foreach (var num in arr)
            //{
            //    if (counts.ContainsKey(num))
            //    {
            //        counts[num]++;
            //    }
            //    else
            //    {
            //        counts[num] = 1;
            //    }
            //}

            //foreach (var item in counts)
            //{
            //    Console.WriteLine($"{item.Key} occurs {item.Value} times");
            //}
            #endregion

            #region 32- Maximum and minimum elements in an array
            //int[] arr = { 12, 45, 2, 67, 34 };
            //int max = arr[0], min = arr[0];
            //foreach (int item in arr)
            //{
            //    if (item > max) max = item;
            //    if (item < min) min = item;
            //}
            //Console.WriteLine($"Max = {max}, Min = {min}");
            #endregion

            #region 33- Second-largest element in an array
            //int[] arr = { 12, 35, 1, 10, 34, 1 };
            //int first = int.MinValue, second = int.MinValue;
            //foreach (int item in arr)
            //{
            //    if (item > first)
            //    {
            //        second = first;
            //        first = item;
            //    }
            //    else if (item > second && item != first)
            //    {
            //        second = item;
            //    }
            //}
            //Console.WriteLine($"Second largest = {second}");
            #endregion

            #region 34- Longest distance between two equal values
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());

            //int maxDist = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = arr.Length - 1; j > i; j--)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int dist = j - i - 1;
            //            maxDist = Math.Max(maxDist, dist);
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine($"Longest distance = {maxDist}");
            #endregion

            #region 35- Reverse order of space-separated words
            //string sentence = Console.ReadLine();
            //string[] words = sentence.Split(' ');
            //Array.Reverse(words);
            //Console.WriteLine(string.Join(" ", words));
            #endregion

            #region 36- Copy 2D array into another and print
            //int rows = int.Parse(Console.ReadLine());
            //int cols = int.Parse(Console.ReadLine());
            //int[,] arr1 = new int[rows, cols];
            //int[,] arr2 = new int[rows, cols];

            //for (int i = 0; i < rows; i++)
            //    for (int j = 0; j < cols; j++)
            //        arr1[i, j] = int.Parse(Console.ReadLine());

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        arr2[i, j] = arr1[i, j];
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 37- Print 1D array in reverse order
            //int[] arr = { 10, 20, 30, 40, 50 };
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            #endregion

            #region 38- Value type: By Value vs By Reference
            //// By Value: passes a copy; original variable is unaffected.
            //// By Reference (ref): passes memory address; changes affect original variable.
            //int val = 10;
            //PassByVal(val);
            //Console.WriteLine(val); // print 10
            //PassByRef(ref val);
            //Console.WriteLine(val); // print 20
            #endregion

            #region 39- Reference type: By Value vs By Reference
            //// By Value: passes copy of reference (modifying elements changes original, reassigning new array does not).
            //// By Reference (ref): passes actual reference (both modifying elements and reassigning new array affect original).
            //int[] nums = { 1, 2, 3 };
            //RefTypeByVal(nums);
            //Console.WriteLine(nums[0]); // print 99 (still original array, not {7,8,9})
            //RefTypeByRef(ref nums);
            //Console.WriteLine(nums[0]); // print 7 (reassigned to new array)
            #endregion

            #region 40- Sum of first pair and difference of second pair
            //var res = SumAndDiff(10, 20, 50, 15);
            //Console.WriteLine($"Sum = {res.sum}, Diff = {res.diff}");
            #endregion

            #region 41- Sum of digits of an integer
            //Console.WriteLine($"The sum of the digits of the number 25 is: {SumOfDigits(25)}");
            #endregion

            #region 42- IsPrime function
            //Console.WriteLine(IsPrime(7)); // print True
            #endregion

            #region 43- MinMaxArray using reference parameters
            //int[] arr = { 5, 1, 9, 3 };
            //int min = 0, max = 0;
            //MinMaxArray(arr, ref min, ref max);
            //Console.WriteLine($"Min = {min}, Max = {max}");
            #endregion

            #region 44-  factorial 
            //Console.WriteLine(Factorial(5)); // print 120
            #endregion

            #region 45- ChangeChar function
            //Console.WriteLine(ChangeChar("Hello", 1, 'a')); // print Hallo
            #endregion
        }

        #region  Functions (38 - 45)
        static void PassByVal(int x) { x = 20; }
        static void PassByRef(ref int x) { x = 20; }

        static void RefTypeByVal(int[] arr)
        {
            arr[0] = 99;
            arr = new int[] { 7, 8, 9 };
        }
        static void RefTypeByRef(ref int[] arr)
        {
            arr = new int[] { 7, 8, 9 };
        }

        static (int sum, int diff) SumAndDiff(int a, int b, int c, int d)
        {
            return (a + b, c - d);
        }

        static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i*i <=number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static void MinMaxArray(int[] arr, ref int min, ref int max)
        {
            min = arr[0];
            max = arr[0];
            foreach (int item in arr)
            {
                if (item < min) min = item;
                if (item > max) max = item;
            }
        }

        static long Factorial(int n)
        {
            long fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        static string ChangeChar(string text, int index, char newChar)
        {
            char[] chars = text.ToCharArray();
            chars[index] = newChar;
            return new string(chars);
        }
        #endregion
    }
}