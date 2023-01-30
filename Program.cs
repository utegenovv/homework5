/*
void CrateRandomArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Введите длину массива:  ");
int s = Convert.ToInt32(Console.ReadLine());

int [] numbers  = new int [s];
CrateRandomArray(numbers);
Console.WriteLine();
Console.WriteLine("Массив  :");
PrintArray(numbers);
Console.WriteLine();
int count = 0;
for (int num = 0; num < numbers.Length; num++)
if (numbers[num] % 2 == 0) count++;


Console.WriteLine($"Чисел в массиве {numbers.Length}. {count} Количество четных чисел");
*/

/*
void CrateRandomArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,10);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Введите длину массива:  ");
int s = Convert.ToInt32(Console.ReadLine());

int [] numbers  = new int [s];
CrateRandomArray(numbers);
Console.WriteLine();
Console.WriteLine("Массив  :");
PrintArray(numbers);
Console.WriteLine();
int sum = 0;

for(int num = 0; num < numbers.Length; num += 2) sum += numbers[num];

Console.WriteLine($"всего чисел в массиве {numbers.Length} в а сумма не четных позициях {sum}" );
*/
/*
void CrateArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,10);
    }
}

void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Введите длину массива:  ");
int s = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[s];
CrateArray(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int num = 0; num < numbers.Length; num++)
{
    if (numbers[num] > max) max = numbers[num];
    if (numbers[num] < min) min = numbers[num];   
}

Console.WriteLine($"Всего {numbers.Length} числа в массиве. Максимальное значение равно {max}, минимальное значение равно {min}.");
Console.WriteLine($"{max} - {min} = {max - min}.");

*/