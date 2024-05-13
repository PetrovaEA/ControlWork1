
//функция добавляет элемент в конец массива
string[] AddItem(string[] array, string item)
{
    //считаем размер нового массива
    int size = array.Length + 1;
    //объявляем массив
    string[] result = new string[size];
    //записываем элементы из старого массива в новый
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    //записываем новый элемент в конец массива
    result[size - 1] = item;
    //возвращаем новый массив
    return result;
}

//функция выбирает из массива строки с длинной меньше илбо равно заданной
string[] SelectItems(string[] array, int max_length)
{
    //объявляем массив
    string[] result = new string[0];
    //записываем подходящие элементы в новый массив
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= max_length)
        {
            result = AddItem(result, array[i]);
        }
    }
    //возвращаем новый массив
    return result;
}

//функция выводит массив на экран
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ",");
        }

    }
    Console.WriteLine("]");
}


// Инициализация массива
System.Console.WriteLine("Введите элементы массива через запятую");
string input = Console.ReadLine();
//Проверяем введённое
while (input == "")
{
    System.Console.WriteLine("Введённое значение некорректно. Введите элементы массива через запятую.");
    input = System.Console.ReadLine();
}
//Если ввод корректен  - идём дальше
string[] array = input.Split(',');
string[] selected_items = SelectItems(array, 3);

System.Console.WriteLine("Исходный массив: ");
PrintArray(array);
System.Console.WriteLine("Новый массив: ");
PrintArray(selected_items);