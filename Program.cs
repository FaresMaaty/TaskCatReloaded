namespace Project.TaskOfDelegate
{
    delegate int Calculator(int number1, int number2);
    delegate int Summition(int[] arr);
    internal class Program
    {
        static void Main(string[] args)
        {
            //(1)
            Calculator addition = (int number1, int number2) => number1 + number2;
            Calculator subtraction = (int number1, int number2) => number1 - number2;
            Calculator multiplication = (int number1, int number2) => number1 * number2;

            Console.WriteLine(addition(2, 3));
            Console.WriteLine(subtraction(2, 3));
            Console.WriteLine(multiplication(2, 3));




            //(3)
            Summition sum = delegate (int[] arr)
            {
                int sum = 0;
                foreach (var number in arr)
                {
                    sum += number;
                }
                return sum;
            };
            Console.WriteLine(sum(new int[] { 2, 5, 3, 3, 7 }));
        }
    }
}
