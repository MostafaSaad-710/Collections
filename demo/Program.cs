namespace Assignment
{
    internal class Program
    {
        static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
        static bool IsBalanced(string s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
        static int[] RemoveDuplicates(int[] arr)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < result.Count; j++)
                {
                    if (arr[i] == result[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    result.Add(arr[i]);
                }
            }

            int[] finalResult = new int[result.Count];
            for (int i = 0; i < result.Count; i++)
            {
                finalResult[i] = result[i];
            }

            return finalResult;
        }
        static void RemoveOddNumbers(List<int> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] % 2 == 1)
                {
                    list.RemoveAt(i);
                }
            }
        }
        static void SearchInStack(Stack<int> stack, int target)
        {
            Stack<int> tStack = new Stack<int>();
            int count = 0;
            bool found = false;

            while (stack.Count > 0)
            {
                int current = stack.Pop();
                tStack.Push(current);
                count++;

                if (current == target)
                {
                    found = true;
                    break;
                }
            }

            while (tStack.Count > 0)
            {
                stack.Push(tStack.Pop());
            }

            if (found)
            {
                Console.WriteLine("Target was found successfully and the count = " + count);
            }
            else
            {
                Console.WriteLine("Target was not found");
            }
        }
        static List<int> FindSublistWithSum(List<int> list, int target)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int sum = 0;
                List<int> sublist = new List<int>();

                for (int j = i; j < list.Count; j++)
                {
                    sum += list[j];
                    sublist.Add(list[j]);

                    if (sum == target)
                    {
                        return sublist;
                    }
                    if (sum > target)
                    {
                        break;
                    }
                }
            }

            return new List<int>();
        }
        static void ReverseFirstK(Queue<int> queue, int k)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            int remaining = queue.Count - k;
            for (int i = 0; i < remaining; i++)
            {
                int temp = queue.Dequeue();
                queue.Enqueue(temp);
            }
        }


        static void Main(string[] args)
        {
            #region Q01
            //string[] input = Console.ReadLine().Split();
            //int n = int.Parse(input[0]);
            //int q = int.Parse(input[1]);

            //string[] arrayInput = Console.ReadLine().Split();
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(arrayInput[i]);
            //}

            //for (int i = 0; i < q; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    int count = 0;

            //    for (int j = 0; j < n; j++)
            //    {
            //        if (arr[j] > x)
            //        {
            //            count++;
            //        }
            //    }

            //    Console.WriteLine(count);
            //} 
            #endregion

            #region Q02
            //int n = int.Parse(Console.ReadLine());
            //string[] input = Console.ReadLine().Split();
            //int[] arr = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(input[i]);
            //}

            //bool isPalindrome = true;

            //for (int i = 0; i < n / 2; i++)
            //{
            //    if (arr[i] != arr[n - 1 - i])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //if (isPalindrome)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //} 
            #endregion

            #region Q03
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //Console.WriteLine("Original Queue:");
            //foreach (int item in queue)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //ReverseQueue(queue);

            //Console.WriteLine("Reversed Queue:");
            //foreach (int item in queue)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine(); 
            #endregion

            #region Q04
            //string input = Console.ReadLine();

            //if (IsBalanced(input))
            //{
            //    Console.WriteLine("Balanced");
            //}
            //else
            //{
            //    Console.WriteLine("Not Balanced");
            //} 
            #endregion

            #region Q05
            //int[] arr = { 1, 2, 3, 2, 4, 1, 5 };
            //int[] noDuplicates = RemoveDuplicates(arr);

            //Console.WriteLine("Array without duplicates:");
            //for (int i = 0; i < noDuplicates.Length; i++)
            //{
            //    Console.Write(noDuplicates[i] + " ");
            //}
            #endregion

            #region Q06
            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("Original list:");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.Write(list[i] + " ");
            //}
            //Console.WriteLine();

            //RemoveOddNumbers(list);
            //Console.WriteLine("After removing odd numbers:");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.Write(list[i] + " ");
            //}
            #endregion

            #region Q07
            //Queue<object> queue = new Queue<object>();

            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //Console.WriteLine("Queue contents:");
            //foreach (object item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\nDequeuing items:");
            //while (queue.Count > 0)
            //{
            //    object item = queue.Dequeue();
            //    Console.WriteLine("Dequeued: " + item);
            //} 
            #endregion

            #region Q08
            //Stack<int> stack = new Stack<int>();

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);
            //stack.Push(50);

            //Console.Write("Enter target number: ");
            //int target = int.Parse(Console.ReadLine());

            //SearchInStack(stack, target); 
            #endregion

            #region Q10
            //List<int> list = new List<int> { 1, 2, 3, 7, 5 };
            //int target = 12;
            //List<int> sublist = FindSublistWithSum(list, target);

            //Console.WriteLine("Sublist with sum " + target + ":");
            //for (int i = 0; i < sublist.Count; i++)
            //{
            //    Console.Write(sublist[i] + " ");
            //} 
            #endregion

            #region Q11
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //int k = 3;

            //Console.WriteLine("Original Queue:");
            //foreach (int item in queue)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //ReverseFirstK(queue, k);

            //Console.WriteLine("After reversing first " + k + " elements:");
            //foreach (int item in queue)
            //{
            //    Console.Write(item + " ");
            //} 
            #endregion

        }
    }
}
