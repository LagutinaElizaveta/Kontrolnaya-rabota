// Написать программу, которая из имеющегося массива строк сформирует
// массив из строк, длина которых меньше либо равна 3 символа
// Пример: ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
// Метод ввода пользователем массива строк с клавиатуры
string[] array(int size)
{
    string[] str = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива: ");
        str[i] = Console.ReadLine();
    }
    return str;
}
string[] str = array(size);
Console.Write($"Введенный Вами массив [{String.Join("; ", str)}]");

// Метод вывода нового массива из отобранных по заданным требованиям элементов
void ArrayIf(string[] array)
{
    string[] result = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }
    Array.Resize(ref result, j);
    Console.WriteLine();
    Console.WriteLine($"Массив по заданному условию [{String.Join("; ", result)}]");
}
ArrayIf(str);