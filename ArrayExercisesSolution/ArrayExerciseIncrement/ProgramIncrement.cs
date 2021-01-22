// Implementera en metod med namnet InitArray1 som tar en array av typen int som parameter.
// Tilldela var tredje element ett inkrementellt värde av 1 med start från 1.
// Exempel: InitArray1(intArr). Före: [0][0][0][0][0][0][0][0][0]. Efter: [0][0][1][0][0][2][0][0][3].
//int[] intArr = new int[12];
//InitArr1(intArr);

using System;

namespace ArrayExerciseIncrement
{
    class ProgramIncrement
    {
        static int[] arr = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        static void Main(string[] args)
        {
            InitArray(arr);
        }

        private static void InitArray(int[] arr)
        {
            int j = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i - 1) % 3 == 0)
                {
                    arr[i] += j;
                    j++;

                }
            }

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
