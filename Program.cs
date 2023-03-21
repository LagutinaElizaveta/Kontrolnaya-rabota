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
// Метод вывода массива
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < size - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    for (int i = size - 1; i < size; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
string[] str = array(size);
Console.Write("Введенный Вами массив ");
PrintArray(str);