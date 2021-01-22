/*
 Skriv en metod med namnet PushLeft som tar en array-parameter och en int-parameter. PushLeft() ska flytta elementen i array-
parametern ett visst antal steg till vänster i array:en. Antalet steg anges av int-parametern. Ex. PushLeft(arr, 2). 
Före: [1][2][3][4][5] Efter: [3][4][5][4][5]. arr = new int[6] {1,2,3,4,5,6}. PushLeft(arr, 2);
 */

using System;

namespace ArrayExercise2
{
    class Program2
    {
        static int[] arr = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        static int[] pushedArr = new int[11];
        static void Main(string[] args)
        {
            PushLeft(arr, 2);
        }

        private static void PushLeft(int[] arr, int pushes)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length - pushes)
                {
                    pushedArr[i] = arr[i +  pushes];
                }
                else
                {
                    pushedArr[i] = arr[i];
                }

            }
            foreach (int item in pushedArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
