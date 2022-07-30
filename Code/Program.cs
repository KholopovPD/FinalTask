string[] arr1 = new string[5];
Console.WriteLine("Введите массив :");
for (int i = 0; i < arr1.Length; i++)
{
    arr1[i] = Convert.ToString(Console.ReadLine());
}
void task(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
int count = 0; // Решена проблема с длинной нового массива
for (int i = 0; i < arr1.Length; i++)
{
    {
        if (arr1[i].Length <= 3)
        {
            count++;
        }
    }
}
string[] arr2 = new string[count];
void Print(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}
task(arr1, arr2);
Console.WriteLine("Получившийся массив строк с элементами, длина которых меньше либо равна 3 :");
Print(arr2);