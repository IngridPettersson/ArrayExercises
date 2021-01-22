// Skriv en metod med namnet PushRight som tar en array-parameter och en int-parametrar. PushRight ska
// flytta elementen i array-parametern ett visst antal steg till höger i array:en. Antalet steg anges av
// int-parametern. Exempel: PushRight(arr, 2). Före: [1][2][3][4][5]. Efter: [1][2][1][2][3].
//arr = new int[5] { 1, 2, 3, 4, 5 };
//PushRight(arr, 2);

using System;

namespace ArrayExercise3
{
    class Program3
    {
        static int[] arr = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
        static int[] pushedArr = new int[7];
        static void Main(string[] args)
        {

            PushRight(arr, 2);
        }

        static void PushRight(int[] arr, int pushes)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (i < pushes)
                {
                    pushedArr[i] = arr[i];

                }
                else
                {
                    pushedArr[i] = arr[i - pushes];
                }

            }
            foreach (int item in pushedArr)
            {
                Console.WriteLine(item);
            }
        }

    }
}

