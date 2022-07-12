// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write($"Введите количество чисел(М): ");
int m = Convert.ToInt32(Console.ReadLine());

int[] NumArray = new int[m];

void NumbersIp(int m)
{
    for (int i = 0; i < m; i++)
    {
    Console.Write($"Введи {i+1} число: ");
    NumArray[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int NumComp (int[] NumArray)
{
    int count = 0;
    for (int i = 0; i < NumArray.Length; i++)
  {
    if(NumArray[i] > 0 ) count += 1; 
  }
  return count;
}

NumbersIp(m);

int count = NumComp (NumArray);
Console.WriteLine($"Чисел больше  0 -> {count} ");
