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
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //foreach (var item in queue)
            //    Console.WriteLine(item);
            //Console.WriteLine("----------- AFTER Reverse --------------");
            //ReverseElementsUsingStack<int>(queue);
            //foreach (var item in queue)
            //    Console.WriteLine(item);
            #endregion

            #region 2- Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            string s = Console.ReadLine()!;

            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {

                if (stack.Count > 0 && ((stack.Peek() == '(' && c == ')') || (stack.Peek() == '{' && c == '}') || (stack.Peek() == '[' && c == ']')))
                    stack.Pop();
                else
                    stack.Push(c);

            }
            if (stack.Count > 0)
                Console.WriteLine("Not Balanced");
            else
                Console.WriteLine("Balanced"); 
            #endregion






        }
    }
}
