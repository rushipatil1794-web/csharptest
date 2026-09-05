internal class patter2
{
    public static void Main(string[] args)
    {
         
      for (int r = 1; r <= 3; r++)
        {
            for (int c = 1; c <= r; c++)
            {
                if (r == 1 || r == 3)
                {
                    Console.Write(" @ ");
                }
                else
                {
                    Console.Write(" 0 ");
                }
            }
            Console.WriteLine();
        }
 
        for (int row = 1; row <= 2; row++)
        {
            for (int col = 1; col <= 2; col++)
            {
                if (row == 1)
                {
                    Console.Write(" 0 ");
                }
                else
                {
                    Console.Write(" @ ");
                }
            }
            Console.WriteLine();
        }
    }
}