# Задача:

*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.*

## Описание алгоритма решения:

1. Вводим размерность массива с клавиатуры, считываем данные.
2. Реализуем метод ввода пользователем массива с клавиатуры:
- создаем новый массив строк;
- до тех пор, пока порядковый номер элемента массива меньше его размера, мы предлагаем пользователю ввести значение элемента;
- записываем каждое введенное значение;
- возвращаем полученный массив;
- выводим полученный массив на экран.
3. Реализуем метод вывода нового массива, удовлетворяющего условию: длина элементов (строк) массива меньше или равна трем:
- создаем новый массив с таким же размером, как и заданный;
- вводим еще один счетчик j;
- в цикле для i, меньше или равном количеству элементов исходного массива, проверяем условие: размерность элемента меньше или равна 3. Если условие выполняется, то записываем значение элемента на соответсвующую позицию нового массива и увеличиваем счетчик j. Если не выполняется - то ничего не записываем и увеличиваем счетчик i;
- после выхода из цикла производим изменение размерности нового массива с учетом счетчика j, чтобы избежать пустых мест в массиве;
- выводим полученный массив на экран.
 
Графическое представление метода вывода массива, удовлетворяющего заданному условию, находится в файле "Алгоритм".

Реализация алгоритма в файле Program.cs