namespace Assignments
{
    internal class Program
    {
        public static void ReverseElementsUsingStack<T>(Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();
            while (queue.Count>0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
        static void Main(string[] args)
        {
            #region 1 Given a Queue, implement a function to reverse the elements of a queue using a stack.
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            foreach (var item in queue)
                Console.WriteLine(item);
            Console.WriteLine("----------- AFTER Reverse --------------");
            ReverseElementsUsingStack<int>(queue);
            foreach (var item in queue)
                Console.WriteLine(item); 
            #endregion

        }
    }
}
