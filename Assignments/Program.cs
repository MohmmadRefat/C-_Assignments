using System.Collections;

namespace Assignments
{
    internal class Program
    {
        class StringEqualityComparer : IEqualityComparer
        {
            public new bool Equals(object? x, object? y)
            {
                string? X = x as string;
                string? Y = y as string;
                return X?.ToLower().Equals(Y?.ToLower())??Y is null?true:false;
            }

            public int GetHashCode(object obj)
            {
                string? s = obj as string;
                return s?.ToLower().GetHashCode() ?? 0;
            }
        }
        static void Main(string[] args)
        {
            #region LinkedList
            //LinkedList<int>linkedList = new LinkedList<int>();
            //LinkedListNode<int>FirstNode= linkedList.AddLast(1);
            //LinkedListNode<int>SecondNode= linkedList.AddLast(2);
            //LinkedListNode<int>ThirdNode= linkedList.AddLast(3);
            //LinkedListNode<int>FourthNode= linkedList.AddLast(4);
            //LinkedListNode<int> FifthNode = linkedList.AddFirst(5);
            //Console.WriteLine($"FirstNode: {FirstNode.Value}");
            //Console.WriteLine($"FirstNode.Pervious.Value : {FirstNode.Previous?.Value??0}");
            //Console.WriteLine($"FirstNode.Next.Value : {FirstNode.Next?.Value ?? 0}");
            //Console.WriteLine("-- ----------------------");

            //Console.WriteLine($"SecondeNode: {SecondNode.Value}");
            //Console.WriteLine($"ThirdNode: {ThirdNode.Value}");
            //Console.WriteLine("-- ----------------------");
            //Console.WriteLine($"FourthNode: {FourthNode.Value}");
            //Console.WriteLine($"FourthNode.Pervious.Value : {FourthNode.Previous?.Value ?? 0}");
            //Console.WriteLine($"FourthNode.Next.Value : {FourthNode.Next?.Value ?? 0}");

            //Console.WriteLine($"FifthNode : {FifthNode.Value}");
            #endregion

            #region Stack & Queue
            //Stack<int>stack=new Stack<int>();
            //stack.Push(1);
            //stack.Push(2); 
            //stack.Push(3);


            //Console.WriteLine($"Stack Peek : {stack.TryPeek(out int result)}");
            //Console.WriteLine(result);


            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine($"Stack Pop : {stack.TryPop(out int result)}");
            //    Console.WriteLine(result);
            //}

            //foreach(var item in stack)
            //    Console.WriteLine(item);

            //--------------------------------------------------------//

            //Queue<int>numbers = new Queue<int>();
            //numbers.Enqueue(1);
            //numbers.Enqueue(2);
            //numbers.Enqueue(3);

            //foreach (var item in numbers)
            //    Console.WriteLine(item);
            //Console.WriteLine("---------------");
            //numbers.Dequeue();
            //numbers.Dequeue();
            //numbers.Dequeue();
            //numbers.TryDequeue(out int result);
            //Console.WriteLine("----------------"); 
            #endregion

            #region HashTable
            Hashtable Note = new Hashtable(new StringEqualityComparer());
            Note.Add("Mohmmad", 123);
            Note.Add("Refat", 456);
            Note.Add("Salah", 789);
            //Note.Add("salah", 456);// key is duplicated
            Console.WriteLine(Note["Mohmmad"]);
            Console.WriteLine(Note["Ahmed"] ?? "Not Found");
            foreach (DictionaryEntry i in Note)
                Console.WriteLine($"Key : {i.Key} , Value : {i.Value}");
            #endregion



        }
    }
}
