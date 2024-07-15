using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            int num = Convert.ToInt32(arr[i]);
            if (num <= 10)
            {
                Console.WriteLine("A[" + i + "] = " + num);
            }
        }
    }
}