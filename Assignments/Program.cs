namespace Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList
            LinkedList<int>linkedList = new LinkedList<int>();
            LinkedListNode<int>FirstNode= linkedList.AddLast(1);
            LinkedListNode<int>SecondNode= linkedList.AddLast(2);
            LinkedListNode<int>ThirdNode= linkedList.AddLast(3);
            LinkedListNode<int>FourthNode= linkedList.AddLast(4);
            LinkedListNode<int> FifthNode = linkedList.AddFirst(5);
            Console.WriteLine($"FirstNode: {FirstNode.Value}");
            Console.WriteLine($"FirstNode.Pervious.Value : {FirstNode.Previous?.Value??0}");
            Console.WriteLine($"FirstNode.Next.Value : {FirstNode.Next?.Value ?? 0}");
            Console.WriteLine("-- ----------------------");

            Console.WriteLine($"SecondeNode: {SecondNode.Value}");
            Console.WriteLine($"ThirdNode: {ThirdNode.Value}");
            Console.WriteLine("-- ----------------------");
            Console.WriteLine($"FourthNode: {FourthNode.Value}");
            Console.WriteLine($"FourthNode.Pervious.Value : {FourthNode.Previous?.Value ?? 0}");
            Console.WriteLine($"FourthNode.Next.Value : {FourthNode.Next?.Value ?? 0}");

            Console.WriteLine($"FifthNode : {FifthNode.Value}");
            #endregion


        }
    }
}
