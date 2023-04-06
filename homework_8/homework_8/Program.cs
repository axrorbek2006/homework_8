namespace homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" {num} soni { findSizeNum(num)} xonali son ");
        }
        static int findSizeNum(int num)
        {
            return num.ToString().Length;          
        }
    }
}