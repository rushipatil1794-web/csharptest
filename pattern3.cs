internal class patter3
{
    public static void Main(string[] args)
    {
         
       for (int r = 1; r <= 3; r++)
        {
            for (int c = 1; c <= r; c++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
 
        for (int row = 1; row <= 2; row++)
        {
            for (int col = 1; col <= 2; col++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
    }
}