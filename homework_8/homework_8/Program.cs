namespace homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int num = inputNum();
            findOutNum(num);
  
        }
        static int inputNum()
        {           
            Console.Write( " enter a number :" );
            bool isNumber = int.TryParse( Console.ReadLine(), out int num );
            while(!isNumber)
            {
                Console.WriteLine(" error !");
                Console.Write(" enter a number :");
                isNumber = int.TryParse(Console.ReadLine(), out num);              
            }
            return num;
        } 
        static void findOutNum(int num)
        {
            if(num > 0)
            {
                Console.WriteLine($"{num } musbat son ");
            }else if(num < 0 )
            {
                Console.WriteLine($"{num} manfiy son ");
            }else
            {
                Console.WriteLine($"{num} manfiy ham musbat ham emas ");
            }
        }
    }
}