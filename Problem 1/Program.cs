// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void UserArray(int[] array)
{
    for(int i=0; i< array.Length; i++)
    {
        System.Console.WriteLine($"Введите {i+1} число:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    System.Console.WriteLine("Ваш массив:");
    for(int i=0; i< array.Length; i++)
    {
        System.Console.Write(array[i]+" ");
    }
    System.Console.WriteLine();
}
Console.WriteLine("Сколько чисел в вашем массиве?");
int size = Convert.ToInt32(Console.ReadLine());
int[] Numbers = new int[size];
UserArray(Numbers);
int CountPositive = 0; 
for(int i=0; i<Numbers.Length; i++)
{
    if (Numbers[i]>0)
    CountPositive++;
}
System.Console.WriteLine($"В вашем массиве {CountPositive} положительных чисел");