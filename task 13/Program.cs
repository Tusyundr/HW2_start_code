// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int  num, count, digit;

int NumberDigit(int number)
{
    count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
digit = NumberDigit(num);
    
    if (digit <= 2)
        {
           Console.WriteLine("Третьей цифры нет");
        }
            else
            {
                if (digit > 3)
                {
                    num = num / Convert.ToInt32(Math.Pow(10, digit - 3)); 
                }
                num = num % 10;
                Console.WriteLine($"Третья цифра заданного числа: {num}");
            }