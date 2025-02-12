using System.Collections;

namespace Assignments
{
    internal class Program
    {
   
        public static void ReverseArrayList(ArrayList reversedArray)
        {
            for (int i = (reversedArray.Count - 1) / 2; i >= 0; i--)
            {
                var temp = reversedArray[reversedArray.Count - i - 1];
                reversedArray[reversedArray.Count - i - 1] = reversedArray[i];
                reversedArray[i] = temp;
            }
        }

        public static List<int> EvenNumbers(List<int> numbers)
        {
            List<int> result = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                    result.Add(number);
            }
            return result;
        }

        class FixedSizeList<T>
        {
            public int Count { get; set; }
            public int Capasity { get; set; }

            private List<T> list;
            public FixedSizeList(int capasity)
            {
                Count = 0;
                Capasity = capasity;
                list = new List<T>(Capasity);
            }

            public void Add(T value)
            {
                if (list.Count >= Capasity)
                    throw new InvalidOperationException("The list is already full.");

                list.Add(value);
                Count++;

            }

            public T Get(int index)
            {
                if (index < 0 && index > list.Count)
                    throw new InvalidOperationException("Out Of Bound.");
                else
                    return list[index];


            }


        }

        public static int UpperBound(List<int> list, int target)
        {
            int l = 0, r = list.Count, mid;
            while (l < r)
            {
                mid = l + (r - l) / 2;
                if (target >= list[mid])
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid;
                }
            }

            //if (l < list.Count && target < list[list.Count - 1])
            //    l++;

            return l;
        }

        public static bool IsPalindrome(List<int> list)
        {
            for (int i = 0; i < list.Count / 2; i++)
            {
                if (list[i] != list[list.Count - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static int[] RemoveDupicatedElements(int[] arr)
        {
            List<int> result = new List<int>(arr.Length);
            int j = 0;
            foreach (int i in arr)
            {
                if (!result.Contains(i))
                {
                    result.Add(i);

                }
            }
            return result.ToArray();
        }

        public static ArrayList RemoveOddNumbers(ArrayList numbers)
        {
            ArrayList result = new ArrayList();
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {


       
        #region Example01
        //ArrayList numbers = new ArrayList();
        //Console.WriteLine($"Count: {numbers.Count}, Capacity: {numbers.Capacity}");
        //numbers.Add(1);
        //Console.WriteLine($"Count: {numbers.Count}, Capacity: {numbers.Capacity}");
        //numbers[0] = 1;
        //numbers.Add(2);
        //numbers.Add(3);
        //numbers.Add(4);
        //numbers.Add(5);
        //foreach (int i in numbers) Console.WriteLine(i);
        //Console.WriteLine("--------After REverse---------");
        //ReverseArrayList(numbers);
        //foreach (int i in numbers) Console.WriteLine(i);
        #endregion

        #region Example02
        //List<int> numbers = new List<int>(7);
        ////Console.WriteLine($"Count: {numbers.Count}, Capasity: {numbers.Capacity}");
        //numbers.Add(1);
        //numbers.Add(2);
        //numbers.Add(3);
        //numbers.AddRange(new int[] { 4, 5, 6 });
        //foreach (int i in numbers) Console.WriteLine(i);
        //Console.WriteLine("--------------");

        //List<int> evennumbers = EvenNumbers(numbers);
        //foreach (int i in evennumbers) Console.WriteLine(i);
        #endregion

        #region Example03
        //FixedSizeList<int> Numbers = new FixedSizeList<int>(5);
        //Numbers.Add(1);
        //Numbers.Add(2);
        //Numbers.Add(3);
        //Numbers.Add(4);
        //Numbers.Add(5);
        ////Numbers.Add(6);// Throw Exception
        //for (int i = 0; i < Numbers.Count; i++)
        //{
        //    Console.WriteLine(Numbers.Get(i));
        //}
        ////Console.WriteLine(Numbers.Get(10));//Throw Exception
        #endregion

        #region Example04
        //Dictionary<char, int> Freq = new Dictionary<char, int>();
        //string Str = Console.ReadLine()!;
        //foreach (char item in Str)
        //{
        //    if (!Freq.ContainsKey(item))
        //        Freq.Add(item, 1);
        //    else
        //        Freq[item]++;
        //}
        //Console.WriteLine("UnRepeated characters");
        //bool ok = false;
        //foreach (var item in Freq)
        //{
        //    if (item.Value == 1)
        //    {
        //        ok = true;
        //        Console.WriteLine(item.Key);
        //    }
        //    //Console.WriteLine($"Key : {item.Key} , Value : {item.Value}");

        //}
        //if (!ok)
        //    Console.WriteLine(-1);
        #endregion

        #region Example05
        //Console.WriteLine("Enter the Size and Number of Queries");
        //int x = int.Parse(Console.ReadLine()!);
        //int y = int.Parse(Console.ReadLine()!);
        //int z;
        //List<int> list = new List<int>(x);
        //Console.WriteLine("Enter the List");
        //for (int i = 0; i < x; i++)
        //{
        //    z = int.Parse(Console.ReadLine()!);
        //    list.Add(z);
        //}
        //list.Sort();
        //int ind = 0;
        //Console.WriteLine("Enter the Queries");
        //while (y-- > 0)
        //{
        //    z = int.Parse(Console.ReadLine()!);
        //    ind = UpperBound(list, z);
        //    Console.WriteLine($"this number is Less than : {list.Count - ind} number");
        //} 
        #endregion

        #region Example06
        //List<int> list = new List<int>();
        //int size = int.Parse(Console.ReadLine()!);

        //int x = 0;
        //for (int i = 0; i < size; i++)
        //{
        //    x = int.Parse(Console.ReadLine()!);
        //    list.Add(x);
        //}
        //if (IsPalindrome(list))
        //{
        //    Console.WriteLine("It is Palindrome");
        //}
        //else
        //{
        //    Console.WriteLine("Not Palindrome");
        //}
        #endregion

        #region Example07
        // Console.WriteLine("Enter the size of the array");
        // int size = int.Parse(Console.ReadLine()!);
        // Console.WriteLine("Enter the Elements of the Array");

        // int[] numbers = new int[size];
        // for (int i = 0; i < size; i++)
        // {
        //     numbers[i] = int.Parse(Console.ReadLine()!);// 1 1 1 2  3 3 4 

        // }
        //numbers= RemoveDupicatedElements(numbers);
        // foreach(int i in numbers) Console.WriteLine(i);


        #endregion

        #region Exmple08
        Console.WriteLine("Enter the size of the ArrayList");
            int size = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter the Elements of the ArrayList");

            ArrayList numbers = new ArrayList();

            for (int i = 0; i<size; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()!));
            }

    numbers = RemoveOddNumbers(numbers);
            foreach (int i in numbers)
                Console.WriteLine(i); 
            #endregion


        }
    }
}
