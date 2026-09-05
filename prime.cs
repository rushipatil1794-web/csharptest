internal class prime
{
    public static void Main(string[] args)
    {
         int num;
         int count=0;
           Console.WriteLine("Enter A Number :");
           num=int.Parse(Console.ReadLine());
          for(int i=1;i<=num;i++)
            {
               if( num / 2==0)
                 { 
                   count++;
                 }
            }
          if(count==2)
            {
                Console.WriteLine(num+" is prime number ");
            }
           else
             {
                Console.WriteLine(num+" is not prime number ");

             }
    }
}