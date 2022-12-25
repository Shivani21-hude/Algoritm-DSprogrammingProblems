using System;

namespace InsertionSort
{

    public class Program
    {
        public static void Main(string[] args)
        {
         
            int[] arr = { 4, 7, 1, 9, 6 };
            int i, j, n, temp;
            Console.WriteLine("Enter array :\n");
            foreach(int a in arr)
            {
                Console.Write(a+" ");
            }
            for (i = 1; i < arr.Length; i++)
            {
                temp=arr[i];
                j=i-1;
                while(j>=0&& temp > arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Sorted array is :\n");
            foreach(int a in arr)
            {
                Console.Write(a+" ");
            }
        }
    }
}