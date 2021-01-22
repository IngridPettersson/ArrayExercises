using System;

namespace ArrayExercise01
{
    class Program1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5};
            ReverseArray(arr);
        }

        private static void ReverseArray(int[] arr)
        {
            int[] revArr = new int[5];
            int j = arr.Length - 1;
            int k = j / 2 - (arr.Length % 2);

            for (int i = 0; i < arr.Length; i++)
            {

                if (i <= (arr.Length - 1) / 2)
                {
                    revArr[i] = arr[j];
                    j--;

                }
                else
                {
                    revArr[i] = arr[k];
                    k--;

                }
                Console.WriteLine(revArr[i]);
            }
        }
    }
}
