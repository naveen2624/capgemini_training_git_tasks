using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the operation to be done:\n1.Add\n2.Subtract\n");
        int choice=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter Number 1: ");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter Number 2: ");
        int b = Convert.ToInt16(Console.ReadLine());
        switch (choice)
        {
            case 1: Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                break;
            case 2: Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                break;
            default: Console.WriteLine("Invalid Choice");
                break;
        }


    }
}