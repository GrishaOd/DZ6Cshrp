/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Write("Введите количество чисел, которые вы хотите ввести: ");
int M = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 1; i <= M; i++)
{
    Console.Write($"{i}).Введите число: ");
    int x = int.Parse(Console.ReadLine());
    if (x > 0)
    {
        count++;
    }
}
System.Console.WriteLine("Количество чисел больше нуля равно " + count);