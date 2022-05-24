// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

// Пользователь в данной программе определяет
// размер массива. Размер массива ограничен
// множеством натуральных чисел, то есть от 1
// до бесконечности.

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
    Console.Write("Введите размер массива случайных трехзначных чисел: ");
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
    // случайными трехзначными значениями.
    int[] rndArray = new int[size];
    Random rndNum = new Random();
    for(int i = 0; i < size; i++)
        rndArray[i] = rndNum.Next(100,999);
    return rndArray;
}

void ShowRandomArray(int[] rndArr)
{
    // Метод форматированного вывода массива rndArr.
    Console.Write("[");
    for (int i = 0; i < rndArr.Length - 1; i++)
        Console.Write($"{rndArr[i]}, ");
    Console.WriteLine($"{rndArr[rndArr.Length - 1]}]");
}

int CountEvenNumbers(int[] arrNums)
{
    // Метод подсчета в массиве arrNums элементов
    // имеющих четное значение.
    int result = 0;
    for (int i = 0; i < arrNums.Length; i++)
        if (arrNums[i] % 2 == 0) result++;
    return result;
}

void ShowResult(int evenNumbers)
{
    Console.WriteLine($"В массиве {evenNumbers} четных значений.");
}

int[] arrayOfNumbers = CreateRandomArray(UserInput());
ShowRandomArray(arrayOfNumbers);
ShowResult(CountEvenNumbers(arrayOfNumbers));