using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Assignments
{
    internal class Program
    {
        class MovieEqualityComparer : IEqualityComparer<Movie>
        {
            public bool Equals(Movie? x, Movie? y)
            {
                return x?.Price == y?.Price;
            }

            public int GetHashCode([DisallowNull] Movie obj)
            {
                return obj.Price.GetHashCode();
            }
        }
        class Movie : IEquatable<Movie>
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public decimal Price { get; set; }

            public Movie(int Id,string Title,decimal Price)
            {
                this.Id = Id;
                this.Title = Title;
                this.Price = Price;
            }
            public override string ToString()
            {
                return $"Id : {Id} , Title : {Title} , Price : {Price} ";
            }
            //public override bool Equals(object? obj)
            //{
            //    Movie? other = obj as Movie;
            //    return this.Id.Equals(other?.Id ?? 0) && this.Title.Equals(other?.Title ??"")&&this.Price.Equals(other?.Price??0);
            //}
            public override int GetHashCode()
            {
                return HashCode.Combine(Id, Title, Price);
            }

            public bool Equals(Movie? other)
            {
                return this.Id.Equals(other?.Id ?? 0) && this.Title.Equals(other?.Title ?? "") && this.Price.Equals(other?.Price ?? 0); ;
            }
        }
        
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
        class GenericStringEqualityComparer : IEqualityComparer<string>
        {
           

            public bool Equals(string? X, string? Y)
            {
                return X?.ToLower().Equals(Y?.ToLower()) ?? Y is null ? true : false;
            }
            public int GetHashCode([DisallowNull] string obj)
            {
                return obj?.ToLower().GetHashCode() ?? 0;
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
            //Hashtable Note = new Hashtable(new StringEqualityComparer());
            //Note.Add("Mohmmad", 123);
            //Note.Add("Refat", 456);
            //Note.Add("Salah", 789);
            ////Note.Add("salah", 456);// key is duplicated
            //Console.WriteLine(Note["Mohmmad"]);
            //Console.WriteLine(Note["Ahmed"] ?? "Not Found");

            //foreach (DictionaryEntry i in Note)
            //    Console.WriteLine($"Key : {i.Key} , Value : {i.Value}");
            #endregion

            #region Dictionary
            ////Dictionary : Pairs of Keys & Values
            ////KEys Must be unique
            #region Example01
            //Dictionary<string, int> Note = new Dictionary<string, int>()
            //{
            //    {"Mohmmad",123 },
            //    {"Refat",456 },
            //    {"Salah",789 }
            //};

            //Note.Add("Ahmed", 159);
            ////Note.Add("Ahmed", 7530); // throw exception (dublicated keys)
            //Note.TryAdd("Mohmmad", 10);
            //if (!Note.ContainsKey("Mohmmad"))
            //    Note.Add("Mohmmad", 110);
            //else Console.WriteLine("this key is already existed");

            //foreach (KeyValuePair<string, int> /* var */ item in Note)
            //    Console.WriteLine($"item.Key : {item.Key} ,item.Value : {item.Value}");

            ////foreach(var item in Note.Keys)
            ////    Console.WriteLine(item);
            ////Console.WriteLine("-----------------------------");
            ////foreach (var item in Note.Values)
            ////    Console.WriteLine(item);

            //Console.WriteLine(Note["Mohmmad"]);
            ////Console.WriteLine(Note["Omar"]);  //Not Found
            //bool result = Note.TryGetValue("Omar", out int value);
            //Console.WriteLine($"Try Result : {result} , Retrevied Value : {value}");

            #endregion
            #region Example02

            //KeyValuePair<string, int>[] KeyValuePairs = new KeyValuePair<string, int>[]
            //{
            //    new KeyValuePair<string, int>("Mohmmad",123),
            //     new KeyValuePair<string, int>("Refat",124),
            //      new KeyValuePair<string, int>("Salah",125),
            //       new KeyValuePair<string, int>("Ahmed",126),
            //        new KeyValuePair<string, int>("ahmed",127)

            //};
            //Dictionary<string, int> Note = new Dictionary<string, int>(KeyValuePairs); // No throw Exception
            //                                                                           //Dictionary<string, int> Note = new Dictionary<string, int>(KeyValuePairs,new GenericStringEqualityComparer()); // Throw Exception

            //foreach (var item in Note)
            //{
            //    Console.WriteLine($"item.Key : {item.Key} , item.Value : {item.Value}");
            //}
            #endregion

            #endregion

            #region HashSet
            //HashSet<int>numbers = new HashSet<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(4);
            //numbers.Add(4); // no throw exception

            //foreach (var item in numbers)
            //    Console.WriteLine(item);

            HashSet<Movie> movies = new HashSet<Movie>(new MovieEqualityComparer())
            {
                new Movie(1,"Moviex",2520),
                new Movie(2,"Moviey",220),
                new Movie(3,"Moviez",220),
            };
            movies.Add(new Movie(3, "Moviez", 320));
            foreach (var item in movies)
                Console.WriteLine(item); 
            #endregion



        }
    }
}
