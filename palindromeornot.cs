internal class palindrome
{
    public static void Main(string[] args)
    {
       int number = 789;
int originalNumber = number;
        
    int reversedNumber = 0;
    while (number > 0)
    {
        int digit = number % 10;
        reversedNumber = (reversedNumber * 10) + digit;
        number /= 10;
    }
    if (originalNumber == reversedNumber)
    {
        Console.WriteLine($"{originalNumber} is a palindrome.");
    }
    else
    {
        Console.WriteLine($"{originalNumber} is not a palindrome.");
    }
    }
}