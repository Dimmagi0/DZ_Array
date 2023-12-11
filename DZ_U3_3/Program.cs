// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива. 
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

double[] array = new double[num];
Random run = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble(); // нашла только эту функцию, которая генерит число от 0 до 1. Как сгенерировать числа с плавающей точкой в заданном диапазоне (например от 0 до 50)?
    Console.Write($"{array[i]:F2}  ");   
}

double max = array[0];
double min = array[1];

if (max < min)
{
    max = array[1];
    min = array[0];
}

for (int j = 2; j < array.Length; j++)
{
    if (array[j] > max) {max = array[j];}
    if (array[j] < min) {min = array[j];}
}

Console.WriteLine($"{min:F2}, {max:F2}");

double result = max - min;

Console.WriteLine();
Console.WriteLine($"разница между междумаксимальным и минимальным значением {result:F2}");

