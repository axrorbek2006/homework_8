namespace homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = inputNum();
            int num2 = inputNum();
            Console.WriteLine("Max num : " + findMaxNum(num1, num2));
        }
        static int findMaxNum(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else if (num2 > num1)
            {
                return num2;
            }
            else
            {
                return num1;
            }
        }
        static int inputNum()
        {
            Console.Write("enter num :");
            bool isNumber = int.TryParse(Console.ReadLine(), out int num1);
            while (!isNumber)
            {
                Console.Write("eror : ");
                Console.Write("enter num : ");
                isNumber = int.TryParse(Console.ReadLine(), out num1);
            }

            return num1;
        }
    }
}