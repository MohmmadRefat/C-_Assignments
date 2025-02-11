namespace Assignments
{
    internal class Program
    {
        public static void Swap<T>(ref T X,ref T Y)
        {
            T temp;
            temp = X;
            X = Y;
            Y = temp;
        }
        public static void BubbleSort<T>(T[] arr,Func<T,T,bool>Compare)
        {
            bool swapped = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (Compare(arr[j], arr[j+1]))
                    {
                        Swap<T>(ref arr[j], ref arr[j + 1]);
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }

        class Range<T> where T : IComparable<T>
        {
            public T MaxValue { get; set; }
            public T MinValue { get; set; }

            public Range(T MinValue,T MaxValue)
            {
                this.MaxValue= MaxValue; this.MinValue = MinValue; 
            }

            public bool IsInRange(T Value) 
            {
                return (Value.CompareTo(MinValue)>=0 )&& (Value.CompareTo(MaxValue)<=0);
            }

            public T Length() 
            {
                return (dynamic)MaxValue - (dynamic)MinValue;
            }
            public override string ToString()
            {
                return $"MinVlaue : {MinValue} , MaxValue : {MaxValue}";
            }
        }
        static void Main(string[] args)
        {
            #region 1 -The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm And implement the code of this optimized bubble sort algorithm

            //we can decrease the time of the Bubble sort algorithm to O(N) By use Boolean Flag to detect if the swap operation is occured or not 
            //if the swap operation occured that's means the Array/List is still not sorted , other wise means it is been sorted
            // this optimazation in Best case only O(N)

            //int[] numbers = { 10, 2, 3, 5, 6, 7, 1, 8, 9, 4 };
            //BubbleSort<int>(numbers, delegate (int X, int Y) { return X > Y; });
            //foreach (int x in numbers)
            //    Console.WriteLine( x);


            #endregion

            #region create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. 
            Range<decimal> obj = new Range<decimal>(3.53M, 10.63M);
            Console.WriteLine(obj);
            if (obj.IsInRange(5))
            {
                Console.WriteLine("it is in Range");
            }
            Console.WriteLine($"The Length Of Ragne : { obj.Length()}");
            #endregion

        }
    }
}
