// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

// Пользователь в данной программе определяет
// размер массива. Размер массива ограничен
// множеством натуральных чисел, то есть от 1
// до бесконечности. 
// Условия задачи требуют создания массива вещественных
// чисел, к которым также относятся и те, что представлены
// типами float и double, но для возможности на глаз
// прикинуть правильность работы программы, ограничимся
// целыми числами от 0 до 99.

bool IsNaturalNumber(int number)
{
    //Метод проверки натуральности числа.
    if (number >= 1)
        return true;
    else
        return false;
}

int UserInput()
{
    // Метод пользовательского ввода.
    Console.Write("Введите размер массива случайных чисел: ");
    int result = int.Parse(Console.ReadLine());
    while (!IsNaturalNumber(result))
    {
        Console.Write("Размер массива должен быть больше 0, попробуйте снова: ");
        result = int.Parse(Console.ReadLine());
    }
    return result;
}

int[] CreateRandomArray(int size)
{
    // Метод заполнения массива размером size 
    // случайными значениями в диапазоне от 0 до 99.
    int[] rndArray = new int[size];
    Random rndNum = new Random();
    for(int i = 0; i < size; i++)
        rndArray[i] = rndNum.Next(0,99);
    return rndArray;
}

void ShowArray(int[] rndArr)
{
    // Метод форматированного вывода массива rndArr.
    Console.Write("[");
    for (int i = 0; i < rndArr.Length - 1; i++)
        Console.Write($"{rndArr[i]}, ");
    Console.WriteLine($"{rndArr[rndArr.Length - 1]}]");
}

int DiffBetwMinAndMaxOfArray(int[] someArr)
{
    // Метод возвращающий разницу между максимальным
    // и минимальным значениями массива someArr.
    int minNum = someArr[0];
    int maxNum = someArr[0];
    for(int i = 0; i < someArr.Length; i++)
    {
        if(someArr[i] > maxNum) maxNum = someArr[i];
        if(someArr[i] < minNum) minNum = someArr[i];
    }
    return maxNum - minNum;
}

void ShowResult(int someNumber)
{
    Console.WriteLine($"Разница между максимальным и минимальным значениями массива равна {someNumber}.");
}

int[] arrayOfNums = CreateRandomArray(UserInput());
ShowArray(arrayOfNums);
ShowResult(DiffBetwMinAndMaxOfArray(arrayOfNums));