// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 



int[] CreateArray(int size, int[] array = null, int currentIndex = 0) 
{
    if (array == null) 
    {
       array = new int [size]; 
    }
    if (currentIndex < size)
    {
        Random rnd = new Random();
        array[currentIndex] = rnd.Next(1000); // range of numbers in array
        return CreateArray(size, array, currentIndex + 1);

    }
    else
    {
        return array;
    }
}
int[] ReverseArray(int[] array)
{
    array = array.Reverse().ToArray();
    return array;
}
Console.Write("Введите размер массива: ");

int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
string ArrayAsString = string.Join(", ", array);
Console.WriteLine($"Созданный массив: {ArrayAsString}");
Console.WriteLine($"Перевернутый массив: {string.Join(", ", ReverseArray(array))}");