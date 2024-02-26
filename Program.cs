
void Main()
{
    //Task1();
    //Task2();
    //Task3();
    //Task4();

}

void Task1()
{
    //Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
    char[,] chars =
    {
        {'q','w','e'},
        {'r','t','y'}
    };
    string stringOfChars = "";
    foreach (var item in chars)
    {
        stringOfChars += item;
    }
    System.Console.WriteLine(stringOfChars);
}

void Task2()
{
    //Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.
    string str = "QWERTYUIOPqwertyu";
    str = str.ToLower();
    System.Console.WriteLine(str);
}

void Task3()
{
    //Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
    string? inputString = Console.ReadLine();
    bool checkString = true;
    for (int i = 0; i < inputString!.Length / 2; i++)
    {
        if (inputString[i] != inputString[inputString.Length - 1]) checkString = false;
    }
    System.Console.WriteLine(checkString);
}

void Task4()
{
    //Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. 
    //В полученной строке слова должны быть также разделены пробелами.

    string stringAcrossSpace = "Hello wolrd my friends!";
    string[] worlds = stringAcrossSpace.Split();
    string endString = string.Join(" ", worlds.Reverse());
    System.Console.WriteLine(endString);
}

Main();