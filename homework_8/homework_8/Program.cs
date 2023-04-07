namespace homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" enter x : ");
            int numx = Convert.ToInt32(Console.ReadLine());
            Console.Write(" enter y : ");
            int numy = Convert.ToInt32(Console.ReadLine());
            minAndMax(ref numx, ref numy);  
        }
        static void minAndMax(ref int numx , ref int numy)
        {
            int x = numx, y = numy;
            numx = Math.Max(x, y);
            numy = Math.Min(x, y);
            Console.WriteLine($" Max X : {numx} ");
            Console.WriteLine($" Min Y : {numy} ");
        }
        
    }
}