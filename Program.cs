// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();
int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }

    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

void GenerateArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}

void ShowArray(double[] arr)
{
    foreach (double item in arr)
    {
        System.Console.Write($"{item} ");
    }
}

void GetMinAndMaxNums(double[] arr)
{
    double min = 0;
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        min = arr[i];
    }
    System.Console.WriteLine(max - min);
}

int userNum = ReadInt("Введите число");
double[] arr = new double[userNum];
GenerateArray(arr);
ShowArray(arr);
System.Console.WriteLine();
GetMinAndMaxNums(arr);
