// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.Write("Введите количество элементов Вы в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayMassive = new string[size];
int M = 3;
int N = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string sumbols = Convert.ToString(Console.ReadLine());
    if (sumbols.Length <= M)
    {
        arrayMassive[N] = sumbols;
        N++;
    }
}
Console.WriteLine();
PrintArray(arrayMassive);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

