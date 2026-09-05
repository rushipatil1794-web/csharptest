internal class sumoravg
{
    public static void Main(string[] args)
    {
         int [] num=new int[5];
         int sum=0;
         int avg=0;
        Console.WriteLine("Enter Array Element :");
        for(int i = 0; i < num.Length; i++)
        {
            Console.WriteLine("Enter the number " +(i + 1) + "for the first array:");
            numbers1[i] = Convert.ToInt32(Console.ReadLine());
        }
          
          for( int b=0;b<num.Length;b++)
           {
              sum=sum+num[b];
           }
           int temp=num.Length;
           avg=sum/temp;
          Console.WriteLine("Sum of array is :"+sum);
          Console.WriteLine(:Average of array is :"+avg);
    }
}