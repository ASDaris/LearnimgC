// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

/*
 * 1
Напишите программу, которая запрашивает до 10
целых чисел от пользователя. 
Проверку на целочисленность делать не надо.
Если пользователь вводит 0, ввод заканчивается и программа
высчитывает среднее арифметическое положительных чисел кратных 3.  
*/
//    Console.WriteLine("Input 10 numbers, or iput some numbers and type 0 for average multiplies of 3");
//    int[] num = new int [10];
//    int counter = 0;

//    while (counter < 10)
//    {
//        int number = int.Parse(Console.ReadLine());
//        num[counter] = number;

//        counter++;
//        if (number == 0)
//            break;
//    }
//    int coun = 0;
//    int sum = 0;
//    foreach (int n in num)
//    {
//        if (n > 0 && n % 3 == 0)
//        {
//            sum += n;
//            coun++;
//        }
//    }
//    double avarege = (double)sum / coun;
//    Console.WriteLine($"avarege %3 = {avarege}");
//    Console.ReadLine();

/*
----------2
*ДЗ "Числа Фибоначчи"
*Числа фибоначчи описываются следующей последовательностью: 1, 1, 2, 3, 5, 8, 13, 21...
*Первые два числа - единицы. Все последующие числа вычисляются как сумма двух предыдущих.
*Задание: запросить у пользователя кол-во чисел Фибоначчи, которое он хотел бы сгенерировать (вычислить), и, 
*собственно, произвести генерацию (вычисление). В процессе генерации записывать числа в массив. После генерации вывести вычисленные числа.
*/
//Console.WriteLine("Type what quantity numbers fibonachi you want to generate");
//int n = int.Parse(Console.ReadLine());
//if (n < 0)
//{
//    throw new ArgumentException("Invalid number please no negative numbers");
//}
//int[] fibnum = new int[n];
//int a1 = 0;
//int a2 = 1;


//fibnum[0] = a1;
//fibnum[1] = a2;
//for(int i = 2; i < n; i++)
//{
//    int a = a1 + a2;
//    fibnum[i] = a;

//    a1 = a2;
//    a2 = a;
//}

//foreach(int cur in fibnum)
//{
//    Console.WriteLine(cur);
//}


/*
*---------4
*ДЗ "Вычисление факториала"
*Факториалом числа является произведение этого числа на все предшествующие этому числу числа (кроме 0). 
*Факториал в математике записывается через восклицательный знак. Например 5! = 5*4*3*2*1 = 120. Особые случаи: 0! = 1. 1! = 1.
*Задача: запросить у пользователя число, факториал которого необходимо вычислить и произвести вычисление. Затем вывести результат вычисления. 
*Восклицательный знак запрашивать не надо, кроме того, в C# такой операции нет. Для вычисления факториала надо производить перемножение.
*/
//Console.WriteLine("Write factorial to calculate");
//int n = int.Parse(Console.ReadLine());
//long factorial = 1;
//for (int i = 1; i <= n; i++ )
//{
//    factorial *= i;
//}
//Console.WriteLine(factorial);
/*
*---------5
*ДЗ "3 попытки на аутентификацию"
*Предположим, что логин\пароль для входа в систему: johnsilver\qwerty.
*Запросить у пользователя логин и пароль. Дать пользователю только три попытки для ввода корректной пары логин\пароль. 
*Если пользователь произвёл корректный ввод, вывести на консоль: "Enter the System" и прекратить запрос логина\пароля. 
*Если пользователь ошибся трижды - вывести "The number of available tries have been exceeded" и прекратить запрос пары логин\пароль.
*/

string log = "johnsilver";
string par = "qwerty";
int numb = 0;
while (numb != 3)
{
    Console.WriteLine("Enter Login and Parole");
    string login = Console.ReadLine();
    string parin = Console.ReadLine();
    if (login == log && parin == par)
    {
        Console.WriteLine("Enter the system....");
        break;
    }
    numb++;
}
    if (numb == 3)
{
    Console.WriteLine("Fuck you");
}

static void DemoDebugging()
{
    //f9, f10, f11, f5, ctrl+f5

    Console.WriteLine("Let's calculate the square of a triangle.");
    Console.WriteLine("Enter the length of side AB:");
    double ab = GetDouble();

    Console.WriteLine("Enter the length of side BC:");
    double bc = GetDouble();

    Console.WriteLine("Enter the length of side AC:");
    double ac = GetDouble();

    double p = (ab + bc + ac) / 2;

    //demo exception
    //double p = (ab + bc + ac) / 0;

    double square = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
    Console.WriteLine($"Square of the triangle equals {square}");
}
static double GetDouble()
{
    return double.Parse(Console.ReadLine());
}
static void SwitchCase()
{
    int month = int.Parse(Console.ReadLine());
    string season = string.Empty;
    switch (month)
    {
        case 1:
        case 2:
        case 12:
            season = "Winter";
            break;
        case 3:
        case 4:
        case 5:
            season = "Spring";
            break;
        case 6:
        case 7:
        case 8:
            season = "Summer";
            break;
        case 9:
        case 10:
        case 11:
            season = "Autunumn";
            break;
        default:
            throw new ArgumentException("this dont work because i cant give shit about it");
    }
    Console.WriteLine(season);
    Console.ReadLine();

    Console.WriteLine("Сколько лет вы женаты?");
    int weddingYears = int.Parse(Console.ReadLine());

    string name = string.Empty;

    switch (weddingYears)
    {
        case 5:
            name = "Деревянная свадьба";
            break;
        case 10:
            name = "Оловяенная свадьба";
            break;
        case 15:
            name = "Хрустальная свадьба";
            break;
        case 20:
            name = "Фарфоровая свадьба";
            break;
        case 25:
            name = "Серебрянная свадьба";
            break;
        case 30:
            name = "Жемчужная свадьба";
            break;
        default:
            name = "NO DATA";
            break;
    }
    Console.WriteLine(name);
}
static void BreakAndContinue ()
{
    int[] numbers3 = { 0, 3, 2, 1, 5, 4, 6, 7, 8, 9 };
    foreach (int n in numbers3)
    {
        if (n % 2 != 0)
            continue;

        Console.WriteLine(n);
    }
    Console.ReadLine();
    int[] numbers2 = { 0, 3, 2, 1, 5, 4, 6, 7, 8, 9 };
    char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

    for (int i = 0; i < numbers2.Length; i++)
    {
        Console.WriteLine($"Number = {numbers2[i]}");

        for (int j = 0; j < numbers2.Length; j++)
        {
            if (numbers2[i] == j)
                break;
            Console.Write($"{letters[j]} ");
        }
        Console.WriteLine();
    }
    Console.ReadLine();
    int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };
    int counter = 0;
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        if (counter == 3)
            break;
        for (int j = i + 1; j < numbers.Length; j++)
        {

            int atI = numbers[i];
            int atJ = numbers[j];

            if (atI + atJ == 0)
            {
                Console.WriteLine($"Pair ({atI} ; {atJ}). Indexes ({i} ; {j})");
                counter++;
            }
            if (counter == 3)
                break;

        }
    }
}
static void WhileDoWhile ()
{
    int age = 30;
    while (age < 18)
    {
        Console.WriteLine("fIRST WHILE LOOP");
        Console.WriteLine("Whats is your age ");
        age = int.Parse(Console.ReadLine());
    }
    do
    {
        Console.WriteLine("Dowhile");
        Console.WriteLine("Whats is your age ");
        age = int.Parse(Console.ReadLine());
    }
    while (age < 18);
    Console.WriteLine("Good!");

    int[] numbers = { 1, 2, 3, 4, 5, 6, };
    int i = 0;
    while (i < numbers.Length)
    {
        Console.WriteLine(numbers[i] + " ");
        i++;
    }
}
static void ForInFor()
{
    int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            int atI = numbers[i];
            int atJ = numbers[j];

            if (atI + atJ == 0)
            {
                Console.WriteLine($"Pair ({atI} ; {atJ}). Indexes ({i} ; {j})");
            }
        }
    }
    Console.WriteLine();
    for (int i = 0; i < numbers.Length - 2; i++)
    {
        for (int j = i + 1; j < numbers.Length - 1; j++)
        {
            for (int k = j + 1; k < numbers.Length; k++)
            {
                int atI = numbers[i];
                int atJ = numbers[j];
                int atK = numbers[k];

                if (atI + atJ + atK == 0)
                {
                    Console.WriteLine($"Triplets ({atI} ; {atJ} ; {atK}). Indexes ({i} ; {j} ; {k})");
                }
            }

        }
    }
}
static void ForForeach ()
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i] + " ");
    }
    Console.WriteLine();
    for (int i = numbers.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(numbers[i] + " ");
    }
    Console.WriteLine();
    for (int j = 0; j < numbers.Length; j++)
    {
        if (numbers[j] % 2 == 0)
        {
            Console.WriteLine(numbers[j] + " ");
        }

    }
    foreach (int val in numbers) // без доступа к индексу для итераций
    {
        Console.WriteLine(val + " ");
    }
}
static void Homework1 ()
{
    /*ДЗ "Нахождение максимума"

Запросить у пользователя два целочисленных значения и найти максимальное.*/
    Console.WriteLine("Give me two numbers");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    bool am = a > b;
    if (am)
    {
        Console.WriteLine($"{a} is greater than {b}");
    }
    else
        Console.WriteLine($"{b} is greater than {a}");
    /* 2nd
     * int a = int.Parse(Console.ReadLine());
       int b = int.Parse(Console.ReadLine());
       int max = a;
       if(b > a)
       max = b;

       3rd
       int max;
       if (a > b)
       max = a;
       else
       max = b;

       4rd
       int max = a > b ? a : b;
       Console.Writeline($"Max = {max}"); */
}
static void ContrlolFlowBeginning()
{
    Console.WriteLine("Enter your age");
    int age = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter your weight kg");
    double w = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter your height in metres please");
    double h = double.Parse(Console.ReadLine());
    double bmi = w / (h * h);
    bool isTooLow = bmi <= 18.5;
    bool isNormal = bmi > 18.5 && bmi < 25;
    bool isAboveNormal = bmi >= 25 && bmi <= 30;
    bool isTooFat = bmi > 30;

    bool isFat = isAboveNormal || isTooFat;

    if (isFat)
    {
        Console.WriteLine("Fucking PIG");
    }
    else
    {
        Console.WriteLine("You good for now");
    }
    //if(isFat == false)
    if (!isFat)
    {
        Console.WriteLine("You`re not fat!");
    }

    if (isTooLow)
    {
        Console.WriteLine("Not enough weight");
    }
    else if (isNormal)
    {
        Console.WriteLine("You`re ok");
    }
    else if (isAboveNormal)
    {
        Console.WriteLine("Be careful");
    }
    else
    {
        Console.WriteLine("You need to lose some weight");
    }
    if (isFat || isTooFat)
    {
        Console.WriteLine("Anyway it`s time to get on diet");
    }
    // ternary operation
    string description = age > 18 ? "You can drink alcohol" : "You should get a bit older"; // тернальное выражение если возраст больше 18 то присвоить строчке первое значение в противном случае вторую
    Console.WriteLine($"{description}");
    string profile =
        $"Your profile: {Environment.NewLine}"
        + $"Age: {age}{Environment.NewLine}"
        + $"Weight: {w}{Environment.NewLine}"
        + $"Height: {h}{Environment.NewLine}"
        + $"Body Mass Index: {bmi}";
    Console.WriteLine(profile);
}