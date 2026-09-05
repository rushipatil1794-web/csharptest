internal class equalityofarray
{
    public static void Main(string[] args)
    {
        int[] numbers1 = new int[5];
        int[] numbers2 = new int[5];
        for(int i = 0; i < numbers1.Length; i++)
        {
            Console.WriteLine($"Enter the number {i + 1} for the first array:");
            numbers1[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i = 0; i < numbers2.Length; i++)
        {
            Console.WriteLine($"Enter the number {i + 1} for the second array:");
            numbers2[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Find the equality of two arrays");
        for(int i = 0; i < numbers1.Length; i++)
        {
            for(int j = 0; j < numbers2.Length; j++)
            {
                if (numbers1[i] == numbers2[j])
                {
                    Console.WriteLine("The number " +number1[i]+" is equal to "+numbers2[j]);
                }
            }
        }
    }
}