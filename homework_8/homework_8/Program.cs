namespace homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2;
            returnNum(ref num1, out num2);
            Console.WriteLine("----");
            Console.WriteLine(num1 + 1);
            Console.WriteLine("----");
            Console.WriteLine(num2 + 1);

        }
        static int returnNum(ref int num1, out int num2)
        {
            Console.WriteLine("enter first number : ");
            bool isnumber = int.TryParse(Console.ReadLine(), out num1);
            while (!isnumber)
            {
                Console.WriteLine("error : ");
                Console.WriteLine("enter first number : ");
                isnumber = int.TryParse(Console.ReadLine(), out num1);
            }
            Console.WriteLine("enter second num : ");
            bool isnumber2 = int.TryParse(Console.ReadLine(), out num2);
            while (!isnumber2)
            {
                Console.WriteLine("error : ");
                Console.WriteLine("enter second number : ");
                isnumber2 = int.TryParse(Console.ReadLine(), out num2);
            }
            return num1;
        }
    }
}