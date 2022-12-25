using System;

namespace BubbleSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 7, 6, 9, 4, 3 };
            int temp;
            Console.Write("Given Array : \n ");
            foreach (int a in arr)
                Console.Write(a + " ");
            for (int i = 0; i < arr.Length-1 ; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            Console.WriteLine("\n");
            Console.Write(" Sorted array : \n");
            foreach (int a in arr)
                Console.Write(a + " ");
           // Console.ReadKey();

        }
    }
}