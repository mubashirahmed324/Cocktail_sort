using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3rd_semester
{
    class Program
    {
        static void Main(string[] args)
        {
            CocktailSort S = new CocktailSort();   // Object of CocktailSort class
            Console.Write("Enter Size of Array: ");     // Asking the number of elements user want to sort
            int n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();

            int[] array = new int[n];   // Unsorted Array
            array = S.build_array(n);

            int[] array2 = new int[n];  // Sorted Array

            S.print(array);
            Console.WriteLine();
            array2 = S.Sort(array);
            Console.WriteLine();
            S.print(array2);
        }
    }

    public class CocktailSort
    {

        public int[] build_array(int size)      // Array formation of given numbers inserted by user
        {
            int[] arr = new int[size];
            int count = 1;
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter value number {0}: ", count);
                arr[i] = Convert.ToInt16(Console.ReadLine());         // saving elements in an array   
                count++;
            }
            return arr;
        }

        public int[] Sort(int[] arr)            //Sorting process start from here
        {
            int head = 0;
            int tail = arr.Length - 1;
            int check = 1;

            while (check == 1)
            {

                check = 0;

                for (int i = head; i < tail; i++)        // Forward Pass
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];        // Swapping
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;

                        check = 1;
                    }
                }
                tail--;

                for (int j = tail; j > head; j--)       // Backward Pass
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j];         // Swapping
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;

                        check = 1;
                    }
                }

                head++;

            }
            return arr;

        }

        public void print(int[] S_array)            //  Print Function
        {
            Console.WriteLine("Array is: ");
            for (int i = 0; i < S_array.Length; i++)
            {
                Console.Write("{0} , ", S_array[i]);
            }

        }
    }
}

