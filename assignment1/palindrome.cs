using System;

namespace MyPalindrome{

public class palindrome
{


    public static void Main(string[] args)
    {

        string str = Console.ReadLine().ToLower();
        int flag = 1;
        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - 1 - i])
            {
                flag = 0;
            }
            else
            {
                flag = 1;
            }
        }
        if (flag == 1)
        {
            Console.WriteLine("It is palindrome");
        }
        else if (flag == 0)
        {
            Console.WriteLine("It is not palindrome");
        }
    }
}

}