namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(1)
            Swap(10, 20);
            Swap("fares", "maaty");
            //(2)
            Dictionary<string, int> student = new Dictionary<string, int>();
            student.Add("Mohamed", 90);
            student.Add("fares"  , 85);
            student.Add("Ali"    , 75);
            student.Add("Omar"   , 65);
            student.Add("Mohanad", 50);
            DisplayGrade(student);
            //(3)
            Queue<string> customerService = new Queue<string>();
            customerService.Enqueue("Mohamed");
            customerService.Enqueue("fares"  );
            customerService.Enqueue("Ali"    );
            customerService.Enqueue("Omar"   );
            customerService.Enqueue("Mohanad");
            Console.WriteLine("CustomerNames:");
            while (customerService.Count > 0)
            {
                Console.WriteLine(customerService.Dequeue());
            }

        }
        static void Swap<T>(T variable1,T variable2)
        {
            Console.WriteLine($"Result Before Swap:variable1={variable1} - variable2={variable2}");
            T swap = variable1;
            variable1 = variable2;
            variable2 = swap;
            Console.WriteLine($"Result After Swap:variable1={variable1} - variable2={variable2}");
        }

        static void DisplayGrade(Dictionary<string,int> dic)
        {
            for(int i = 0; i < dic.Count; i++)
            {
                Console.WriteLine($"StudentName:{dic.Keys.ElementAt(i)} => Grade:{dic.Values.ElementAt(i)}");
            }
        }
    }
}
