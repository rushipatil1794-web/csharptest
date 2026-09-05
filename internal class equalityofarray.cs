internal class equalityofarray
{
    public static void Main(string[] args)
    {
       int number=789;
       int rev=0;
       int temp=0;
        while(number>0)
         {
              rev=number%10;
              temp=temp*10+rev;
              number=number/10;
          }
              
         if(nember==temp)
          {
              Console.WriteLine("This is Palindrome Number");
          }
         else
           {
              Console.WriteLine("This is Not Palindrome Number");
            }
    }
}