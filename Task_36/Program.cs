// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Пользователь в данной программе определяет
// размер массива. Размер массива ограничен
// множеством натуральных чисел, то есть от 1
// до бесконечности.
// Случайные числа ограничим диапазоном от -10 до 10,
// чтобы было проще проверять результат работы.

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
    // случайными значениями в диапазоне от -10 до 10.
    int[] rndArray = new int[size];
    Random rndNum = new Random();
    for(int i = 0; i < size; i++)
        rndArray[i] = rndNum.Next(-10,10);
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

int SumOfOddPositionNumbers(int[] arrOfNums)
{
    int result = 0;
    for(int i = 1; i < arrOfNums.Length; i += 2)
        result += arrOfNums[i];
    return result;
}

void ShowResult(int someNumber)
{
    Console.WriteLine($"Сумма элементов массива на нечетных позициях равна {someNumber}.");
}

int[] arrayOfNumbers = CreateRandomArray(UserInput());
ShowRandomArray(arrayOfNumbers);
ShowResult(SumOfOddPositionNumbers(arrayOfNumbers));