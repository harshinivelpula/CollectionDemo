namespace CollectionsDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            doListDemo();
            doStackDemo();
            doQueueDemo();
            doSetDemo();
            doDictionaryDemo();
        }
        public static void doDictionaryDemo()
        {
            Console.WriteLine("in doDictionryDemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "amit");
            dictionary.Add(200, "rahul");
            dictionary.Add(300, "vijay");

            Console.WriteLine("access value using key(key=300)" + dictionary[300]);
            foreach (var element in dictionary)
            {
                Console.WriteLine("key:" + element.Key + "value:"+element.Value);
            }

        }
        public static void doSetDemo()
        {
            Console.WriteLine("in doSetDemo");
            HashSet<string> set = new HashSet<string>();
            set.Add("amit");
            set.Add("rahul");
            set.Add("vijay");

            foreach (var element in set)
            {
                Console.WriteLine(element);
            }

        }
        public static void doListDemo()
        {
            Console.WriteLine("in doListDemo");
            List<string> list = new List<string>();
            list.Add("amit");
            list.Add("rahul");
            list.Add("vijay");

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

        }
        public static void doStackDemo()
        {
            Console.WriteLine("in doStackDemo");

            Stack<string> stack = new Stack<string>();
            stack.Push("ayush");
            stack.Push("garvit");
            stack.Push("amit");
            stack.Push("ashish");
            string pop = stack.Pop();


            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("poped element is:" + pop);

        }
        public static void doQueueDemo()
        {
            Console.WriteLine("in doQueueDemo");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("amit");
            queue.Enqueue("vijay raj");
            queue.Enqueue("jay");
            queue.Enqueue("raj");
            Console.WriteLine("peek element is:" + queue.Peek());


            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("after dequeue elements are");
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }

        }
    }
}