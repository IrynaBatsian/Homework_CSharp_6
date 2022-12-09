// Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.


void InputArray(int[] array) //заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int ReleaseArray(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    count++;
  }
  return count;

}
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m]; //Создание массива с количеством элементов, которое задал пользователь.
InputArray(array);
Console.WriteLine($"Ваш массив: [{string.Join(", ", array)}]");
Console.WriteLine($"В данном массиве положительных чисел: {ReleaseArray(array)}");