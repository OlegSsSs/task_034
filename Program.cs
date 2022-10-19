// Задайте массив заполненный случайными положительными числами. Напишите программу, которая покажет количество 
// четных чисел в массиве.
// [345, 897, 568, 234] → 2

Console.Write("Введите размер массива: ");
int arr = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[arr];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"Количество четных чисел в массиве -> {count} ");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(345,897);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i]);
        if (i < (numbers.Length-1)) Console.Write($", ");
    }
    Console.Write("]");
    Console.WriteLine();
}