internal class pattern2
{
    public static void Main(string[] args)
    {
        int no = 65; // ASCII for 'A'
 
        for (int r = 1; r <= 4; r++)
        {
            for (int s = 0; s < (4 - r); s++)
            {
                Console.Write(" ");
            }
 
            for (int c = 1; c <= r; c++)
            {
                Console.Write(" " + Convert.ToChar(no) + " ");
            }
            Console.WriteLine();
        }
    }
}