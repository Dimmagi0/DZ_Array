// Задача 4*(не обязательно): Дано натуральное число
// в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.

// 425 => [4 2 5]
// 8741 => [8 7 4 1]
// 4 => [4]

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int copyNum= num;
int count=0;

while(num>0)
{
    num= num/10;
    count++;
}

int[] array = new int[count];

for (int i = array.Length-1; i >= 0; i--)  // 456     1
{
    array[i]= copyNum%10;
    copyNum = copyNum/10;
}

// for (int i = 0; i <array.Length; i++)  // 456     1
// {
//     System.Console.Write(array[i]);
// }