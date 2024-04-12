using Arrays;

//использование методов 
double[] scores = new double[10] { 1, 0.2, 3, 2.3, 1.5, 0.7, 3.1, 2.7, 1.1, 0.5};
double maxScore = ArrayMethods.GetMaxScore(scores);
Console.WriteLine($"Максимальный рейтинг - {maxScore}");

double[] prices = new double[10] { 25.5, 30, 12.2, 60, 47, 167, 150.8, 85, 134, 90.8};
double[] pricesWithMarkup = ArrayMethods.CalculatePricesWithMarkup(prices, 18);
Console.WriteLine("Обновленные цены:");
for (int i = 0; i < pricesWithMarkup.Length; i++)
{
    Console.Write($"{pricesWithMarkup[i]:0.00} ");
}
Console.WriteLine();

double[] results = new double[7] {1234, 2345, 3245, 2456, 1576, 1000, 2200};
int numberOfUnderachievingClerks = ArrayMethods.CountnUnderachievingClerks(results, 2000);
Console.WriteLine($"Количество сотрудников, не выполнивших план - {numberOfUnderachievingClerks}");

int[] numberOfOrders = GenerateRandomIntArray(10, 0, 50);
numberOfOrders = ArrayMethods.SelectionSort(numberOfOrders);
ArrayMethods.Print(numberOfOrders);

int[,] films = new int[4, 3] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
ArrayMethods.Print(films);  
int[] sum = ArrayMethods.CalculateFilmViewsPerMonth(films);
ArrayMethods.Print(sum);

int[] GenerateRandomIntArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}