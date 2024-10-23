using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод исходного массива строк
        string[] array = { "Hello", "2", "world", ":-)" };

        // Вызов метода для фильтрации строк
        string[] result = FilterStrings(array);

        // Форматированный вывод исходного и отфильтрованного массива
        Console.WriteLine("[" + string.Join(", ", array) + "] → [" + string.Join(", ", result) + "]");
    }

    // Метод для фильтрации строк по длине
    static string[] FilterStrings(string[] inputArray)
    {
        string[] tempArray = new string[inputArray.Length];
        int count = 0;

        // Цикл по массиву строк
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                tempArray[count] = inputArray[i];
                count++;
            }
        }

        // Создание нового массива нужного размера
        string[] resultArray = new string[count];
        Array.Copy(tempArray, resultArray, count);

        return resultArray;
    }
}
