// Skriv en metod med namnet SwapPairs som tar en array-parameter. SwapPairs ska byta plats på elementen
// par för par.
// Exempel: SwapPairs(arr). Före: [1][2][3][4][5]. Efter: [2][1][4][3][5].
//arr = new int[5] { 1, 2, 3, 4, 5 };
//SwapPairs(arr);


using System;

namespace ArrayExerciseSwapPairs
{
    class ProgramSwapPairs
    {
        static int[] arr = new int[5] { 1, 2, 3, 4, 5 };
        static int[] swappedArr = new int[5];
        static void Main(string[] args)
        {
            SwapPairs(arr);
        }

        static void SwapPairs(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i + 2) % 2 == 0 && i < arr.Length - 1)
                {
                    swappedArr[i + 1] = arr[i];
                }
                else if ((i + 2) % 2 != 0 && i > 0 && i != arr.Length)
                {
                    swappedArr[i - 1] = arr[i];
                }
                else
                {
                    swappedArr[i] = arr[i];
                }
            }

            foreach (int item in swappedArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
