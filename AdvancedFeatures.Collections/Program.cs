namespace AdvancedFeatures.Collections
{
    internal class Program
    {
        private static void Main (string[] args)
        {
            Console.WriteLine("Dictionary: ");

            var dictionary = new Dictionary<string, int>();

            dictionary.Add("Cat", 2);
            dictionary.Add("Dog", 1);
            dictionary.Add("Bird", 0);

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0}, {1}", item.Key, item.Value);
            }

            Console.WriteLine("Dictionary: ");

            var list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(5);
            list.Add(7);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Queue: ");

            var queue = new Queue<string>();
            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");
            queue.Enqueue("Four");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
                // queue.Dequeue();
            }

            Console.WriteLine("stack: ");

            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(10);
            stack.Push(100);
            stack.Push(1000);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
                // stack.Pop();
            }
        }
    }
}