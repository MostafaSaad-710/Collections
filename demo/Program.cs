using System;
using System.Collections;

namespace demo
{
    internal class Program
    {
        public static void PrintArrayList(ArrayList list)
        {
            Console.WriteLine( );
            foreach( int i in list)
            {
                Console.Write( $"{i} ");
            }
            Console.WriteLine( );
        }

        public static void PrintList<T>(List<T> list)
        {
            Console.WriteLine();
            foreach (T i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static void PrintLinkedList(LinkedList<int> list)
        {
            Console.Write("null");
            foreach (int i in list)
            {
                Console.Write($" <- {i} -> ");
            }
            Console.Write("null");
        }
        public static int SumList(List<int> list)
        {
            int Sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Sum += list[i];
                }
            }
            return Sum;
        }
        static void Main(string[] args)
        {
            #region What is Collections

            // Collections : Built-in DS in C#
            // Array: Container

            // Collections in C#
            // Lists
            // Hashtables

            // Generic - Non-Generic
            // Lists:
            // Non-Generics Lists: ArrayList - Stack - Queue
            // Generics Lists    : List, LinkedList, Stack, Queue

            // Hashtables:
            // Non-Generics HashTables : HashTable
            // Generics HashTables     : Dictionary - SortedDictionary

            #endregion

            #region Non-Generic Lists : ArrayList

            //Lists
            //Non-Generic Lists : ArrayList

            // ArrayList Like Array
            // Array Based
            // Index

            // Array     Indexed Collection : Fixed Size
            // ArrayList Indexed Collection : Dynamic Size

            // Index  : 0 1 2 3 4 5
            // items  : 4 5 6 7 8 1
            // Size   : 6

            // Arr[1] ----> 5

            //int[] Numbers = { 9, 8, 7, 6, 1, 2, 3, 4, 5 };

            //Console.WriteLine(Numbers[1]);
            //Numbers[1] = 12;
            //Console.WriteLine(Numbers[1]);

            //ArrayList list = new ArrayList(); //defoulte capasity 4
            // ArrayList list = new ArrayList(new int[] {1,2,3,4,5,6}); //modify capasity
            //ArrayList list = new ArrayList(6); //modify capasity

            //Console.WriteLine($"Count: {list.Count} , Capasity: {list.Capacity}");

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            //list.Add(6);
            //list.Add(7);
            //list.Add(7);
            //Console.WriteLine($"Count: {list.Count} , Capasity: {list.Capacity}");

            //Console.WriteLine(list.IsFixedSize);
            //Console.WriteLine(list.IsReadOnly);
            //Console.WriteLine(list[1]);
            //list[1] = 12;
            //Console.WriteLine(list[1]);

            //list.AddRange(new[] {10,11,12});
            //PrintArrayList(list);

            //int Index = list.BinarySearch(2);
            //Console.WriteLine(Index);

            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000, Age = 29 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Salary = 13000, Age = 30 };
            //Employee E03 = new Employee() { Id = 3, Name = "Omar", Salary = 15000, Age = 35 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Salary = 14000, Age = 32 };

            //ArrayList list02 = new ArrayList();
            //list02.AddRange(new Employee[] { E01, E02, E03, E04 });

            ////int Index = list.BinarySearch(new Employee() { Name = "Ali"}, new EmployeeCompareName());
            ////Console.WriteLine($"Index: {Index}");

            //int index = list02.BinarySearch(  0,   2, new Employee() { Name = "Ali" }, new EmployeeCompareName());
            //Console.WriteLine(index);

            //Console.WriteLine("=====================");
            //foreach (Employee item in list02)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            //list.Add(5);
            //list.Add(6);
            //list.Add(7);
            //list.Add(8);
            //Console.WriteLine($"Count: {list.Count} , Capasity: {list.Capacity}");
            //list.Clear();
            //Console.WriteLine($"Count: {list.Count} , Capasity: {list.Capacity}");


            // bool Flag = list.Contains(20);
            //Console.WriteLine(Flag);

            //int[] Arr = new int[10];

            //list.CopyTo(2, Arr, 3, 1);

            //foreach (int item in Arr)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList arrayList = list.GetRange( 0, 2);

            //foreach (int item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //int i = list.IndexOf(5);
            //int i = list.IndexOf(5 , 4);
            //int i = list.IndexOf(5 , 4 , 5);
            //Console.WriteLine(i);


            //list.Insert(0, 100);
            //PrintArrayList(list);

            //list.InsertRange(0, new int[] { 10, 20, 30, 40 });

            //PrintArrayList(list);

            //int i = list.LastIndexOf(5);
            //Console.WriteLine(i);

            //list.Remove(5);
            //list.RemoveAt(0);
            //list.RemoveRange(0,3);
            //list.SetRange(0, new int[] { 10, 20, 30 });
            //list.Sort();

            //Console.WriteLine("Count: list.Count, Capacity: list.Capacity");

            //list.TrimToSize(); // Delete | Release

            //Console.WriteLine("Count: {list.Count}, Capacity: {list.Capacity}");

            //PrintArrayList(list); 
            #endregion

            #region Generic Lists: List
            // Generic Lists: List
            // List: Version Generic Of ArrayList
            // List Like ArrayList Like Array: Generic - Dynamic Size

            //List<int> list = new List<int>(new int[] { 1,2,3,4});
            //List<int> list = new List<int>();

            //list.Add(item: 1);
            //list.Add(item: 2);
            //list.Add(item: 3);
            //list.Add(item: 4);
            //list.Add(item: 4);
            //list.Add("Hello World"); // Compiler

            //PrintList(list);
            //int Sum = SumList(list);
            //Console.WriteLine(Sum);

            //list.AddRange(new List<int>() { 10, 20, 30, 40, 50 });
            //PrintList(list);

            //int i = list.BinarySearch(100);
            //Console.WriteLine(i);

            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000, Age = 29 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Salary = 13000, Age = 30 };
            //Employee E03 = new Employee() { Id = 3, Name = "Omar", Salary = 15000, Age = 35 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Salary = 14000, Age = 32 };

            //List<Employee> emp = new List<Employee>() { E01, E02, E03, E04 };

            //int i = emp.BinarySearch(E01);
            //Console.WriteLine(i);

            //Console.WriteLine($"Count: {list.Count} , Capasity: {list.Capacity}");

            //list.EnsureCapacity(10);

            //Console.WriteLine($"Count: {list.Count} , Capasity: {list.Capacity}");

            //List<int> result = list.GetRange(0, 2);
            //PrintList(result);

            //list.Sort();

            //Console.WriteLine($"Count: {list.Count} , Capasity: {list.Capacity}");
            //list.TrimExcess();

            //Console.WriteLine($"Count: {list.Count} , Capasity: {list.Capacity}"); 
            #endregion

            #region Generic Lists : LinkedList

            ///Generic Lists : LinkedList

            //LinkedList<>

            //LinkedList<int> list = new LinkedList<int>();

            ////list.AddFirst(1);
            ////list.AddFirst(2);

            //list.AddLast(1);
            //list.AddLast(2);

            //LinkedListNode<int> node = new LinkedListNode<int>(3);
            //list.AddLast(node);

            //list.AddAfter(node , 4);

            //LinkedListNode<int> result = list.Find(1);
            //list.AddBefore(result, 5);

            //Console.WriteLine(list.First.Value);
            //Console.WriteLine(list.Last.Value);
            //list.Clear();

            //Console.WriteLine( list.First.Next.Value);

            //list.Remove(list.First);
            //list.Remove(2);
            //list.RemoveLast();

            //PrintLinkedList(list); 
            #endregion




        }
    }
}
