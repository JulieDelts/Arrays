using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class ArrayMethods
    {
        //20.Введение в массивы
        public static double GetMaxScore(double[] scores)
        {
            double maxScore = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > maxScore) maxScore = scores[i];
            }
            return maxScore;
        }

        public static double[] CalculatePricesWithMarkup(double[] prices, double markup)
        {
            double[] pricesWithMarkup = new double[prices.Length];
            for (int i = 0; i < prices.Length; i++)
            {
                pricesWithMarkup[i] = prices[i] + prices[i] * markup/100; 
            }
            return pricesWithMarkup;
        }

        public static int CountnUnderachievingClerks(double[] results, double requiredSum)
        {
            int count = 0;
            for(int i = 0; i < results.Length; i++) 
            {
                if (results[i] < requiredSum) count++;
            }
            return count;
        }

        //21.Сортировка массива
        public static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int indexOfMaxElement = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] > array[indexOfMaxElement])
                    { 
                        indexOfMaxElement = j;
                    }
                }
                if (indexOfMaxElement != i)
                {
                    int tmp = array[indexOfMaxElement];
                    array[indexOfMaxElement] = array[i];
                    array[i] = tmp;
                }
            }
            return array;
        }
        //22.Многомерные массивы
        public static int[] CalculateFilmViewsPerMonth(int[,] array)
        { 
            int numberOfMovies = array.GetLength(1);
            int numberOfDays = array.GetLength(0);
            int [] result = new int[numberOfMovies];
            for (int i = 0; i < numberOfMovies; i++)
            {
                for (int j = 0; j < numberOfDays; j++)
                {
                    result[i] += array[j,i];
                }
            }
            return result;
        }

        public static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        public static void Print(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        public static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine();
            }
        }
  

    }
}
