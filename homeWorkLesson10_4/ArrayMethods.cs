using System;

namespace homeWorkLesson10_4
{
    public enum ArraySortType
    {
        Ascending,
        Descending
    }

    static class ArrayMethods
    { 
        public static int[] CreateRandomArray(int arrayLength, int randomMinValue, int randomMaxValue)
        {
            int[] variableArray = new int [arrayLength];

            variableArray.FillRandom(randomMinValue, randomMaxValue);

            return variableArray;
        }

        public static void FillRandom(this int[] variableArray, int randomMinValue, int randomMaxValue)
        {
            Random random = new Random();

            for (int i = 0; i < variableArray.Length; i++)
            {
                variableArray[i] = random.Next(randomMinValue, randomMaxValue);
            }
        }

        public static int[] Sort(this int[] variableArray, ArraySortType type)
        {
            int temp;

            for (int i = 0; i < variableArray.Length - 1; i++)
            {
                for (int j = i + 1; j < variableArray.Length; j++)
                {
                    switch (type)
                    {
                        case ArraySortType.Ascending:
                            if (variableArray[i] > variableArray[j])
                            {
                                temp = variableArray[i];
                                variableArray[i] = variableArray[j];
                                variableArray[j] = temp;
                            }
                            break;
                        case ArraySortType.Descending:
                            if (variableArray[i] < variableArray[j])
                            {
                                temp = variableArray[i];
                                variableArray[i] = variableArray[j];
                                variableArray[j] = temp;
                            }
                            break;
                    }
                }
            }

            return variableArray;
        }

        public static void Print(this int[] variableArray)
        {
            foreach (var item in variableArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
