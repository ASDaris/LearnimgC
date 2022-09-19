// See https:/ /aka.ms/new-console-template for more information
using System;
using System.Text;
//----------------------------Basic C#------------------------------------//
static void HomeworkBasicOfC()
{
    /* ДЗ 1-3

1. Запросить имя пользователя. Вывести Hello, [имя пользователя].

2. Запросить у пользователя два целых числа и сохранить в двух переменных. Вывести значения.
Обменять значения переменных: например, если в переменной x было записано число 3, а в y число 5, сделать так, чтобы в y стало 3, а в x стало 5. Вывести значения после обмена.

3. Запросить у пользователя целое число. Вывести количество цифр числа. Например, в числе 156 - 3 цифры.
   */
    Console.WriteLine("Type your name");
    string name = Console.ReadLine();
    Console.WriteLine($"Hello {name}"); // First task complete
    Console.WriteLine("Give me two numbers");
    string input1 = Console.ReadLine();
    string input2 = Console.ReadLine();
    int a = int.Parse(input1);
    int b = int.Parse(input2);
    Console.WriteLine($"{name} you wrote those numbers {a}, {b}. Such awful sequance of numbers. I rearange them"); // Second task complete
    // rearange numbers for answer
    a = int.Parse(input2);
    b = int.Parse(input1);
    Console.WriteLine($"{a}, {b} . Now its perfect. Give me one last number and I count numerals in it");
    //counting numerals in input for answer
    string input3 = Console.ReadLine();
    int count = int.Parse(input3);
    count = input3.Count();
    Console.WriteLine($"{input3} has {count} numerals. Goodbye"); // Third task complete

    // another variants for second and third tasks

    Console.WriteLine("Enter two integers");
    int a1 = int.Parse(Console.ReadLine());
    int b1 = int.Parse(Console.ReadLine());
    Console.WriteLine($"a = {a1}, b = {b1}");
    int c = a1;
    a1 = b1;
    b1 = c;
    Console.WriteLine($"a = {a1}, b = {b1}");
    Console.WriteLine("Enter a integer");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine($"The number of digits: {number.ToString().Length}");

    /*ДЗ "Формула Герона"

Запросить у пользователя длины трёх сторон треугольника. Длины могут быть представлены дробными значениями.

После получения длин сторон - использовать формулу Герона для вычисления площади треугольника.

Чтобы жизнь не казалась мёдом найдите формулу самостоятельно.

После вычисления площади - вывести результат на консоль.
    */

    Console.WriteLine();
    Console.WriteLine("Enter for me lengths for three sides of triangle, and I calculate area of this figure");
    int at = int.Parse(Console.ReadLine());
    int bt = int.Parse(Console.ReadLine());
    int ct = int.Parse(Console.ReadLine());
    double p = (at + bt + ct) / 2;
    double AreaTriangle = Math.Sqrt((p * (at + p) * (bt + p) * (ct + p)));
    Console.WriteLine($"Area of this thriangle is {AreaTriangle}");

    /*ДЗ "Профиль пользователя"

Запросить у пользователя: фамилию, имя, возраст, вес, рост.

Высчитать ИМТ (индекс массы тела) по формуле ИМТ = вес (кг) / (рост (м) * рост (м))

Сформировать единую строку, в следующем формате:

Your profile:
Full Name: фамилия, имя
Age: возраст
Weight: вес
Height: рост
Body Mass Index: ИМТ

    Вывести сформированную строку на консоль.*/
    Console.WriteLine("Now enter your first name");
    name = Console.ReadLine();
    Console.WriteLine("Enter your last name");
    string surname = Console.ReadLine();
    Console.WriteLine("Enter your age");
    int age = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter your weight kg");
    double w = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter your height in metres please");
    double h = double.Parse(Console.ReadLine());
    double bmi = w / (h * h);
    string profile =
        $"Your profile: {Environment.NewLine}"
        + $"Full name: {surname} {name}{Environment.NewLine}"
        + $"Age: {age}{Environment.NewLine}"
        + $"Weight: {w}{Environment.NewLine}"
        + $"Height: {h}{Environment.NewLine}"
        + $"Body Mass Index: {bmi}";
    Console.Clear();
    Console.WriteLine(profile);
}
static void DateAndTime()
{
    DateTime now = DateTime.Now;
    Console.WriteLine(now.ToString());

    Console.WriteLine($"Its {now.Date}, {now.Hour}:{now.Minute}:{now.Second}");
    DateTime dt = new DateTime(2016, 2, 28);
    DateTime newDt = dt.AddDays(1);
    Console.WriteLine(newDt);

    TimeSpan ts = now - dt;
    //ts = now.Subtract(dt);
    Console.WriteLine(ts.Days);
}
static void IntroToArrays()
{
    int[] a1;
    a1 = new int[10];

    int[] a2 = new int[5];

    int[] a3 = new int[5] { 1, 2, 3, 5, 23 };
    int[] a4 = { 1, 43, 23, 42, 54, 2 };

    Console.WriteLine(a4[0]);

    int number = a4[4];
    Console.WriteLine(number);
    a4[4] = 6;
    Console.WriteLine(a4[4]);
    Console.WriteLine(a4.Length);
    Console.WriteLine(a4[a4.Length - 1]);

    string s1 = "abcdefgh";
    char first = s1[0];
    char last = s1[s1.Length - 1];
    Console.WriteLine($"First; {first}. Last: {last}");

    //s1[0] = 'z'; impossible
}
static void MathDemo()
{
    Console.WriteLine(Math.Pow(2, 3));
    Console.WriteLine(Math.Sqrt(9));
    Console.WriteLine(Math.Sqrt(8));

    Console.WriteLine(Math.Round(1.7));
    Console.WriteLine(Math.Round(1.5));
    Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
    Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));
}
static void Comments()
{
    // a single-line comment

    /*
     * multy line
     * we can write 
     * everywher
     */

//describe hows and whys! not whats!

int a = 1;

    //increment a by 1 - bad comment, this code is self-evident
}
static void ParseAndParsings()
{
    byte b = 3; // 0000 00011
    int i = b; // 0000 0000 0000 0000 0000 0000 0000 0011
    long l = i; // 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

    float f = i; // 3.0
    b = (byte)i; // явное приведение инта к байту (cast)

    i = (int)f;

    f = 3.1f;

    i = (int)f; // 3 потеря точности

    string str = "1";
    i = int.Parse(str); // converting

    int x = 5;
    int result = x / 2; // 2

    double result2 = (double)x / 2; //2.5

}
static void ConsoleBasics()
{
    Console.WriteLine("Hi, please tell me your name");
    string name = Console.ReadLine();
    string sentence = $"Nice to meet you,{name}, please tell me your age";
    Console.WriteLine(sentence);
    string input = Console.ReadLine();
    int age = int.Parse(input); // trans string in int
    string sentence2 = $"You are a {age} years old {name}";
    Console.WriteLine(sentence2);

    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("New style "); // Не переводит на новую строку
    Console.Write("New style \n"); //WriteLine
}
static void StringComparsion()
{
   
    string str1 = "abcde";
    string str2 = "abcde";

    bool areEqual = str1 == str2;
    Console.WriteLine(areEqual);

    areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
    Console.WriteLine(areEqual);

    str1 = "Strasse";
    str2 = "Straße";

    areEqual = string.Equals(str1, str2, StringComparison.Ordinal); //default
    Console.WriteLine(areEqual);

    areEqual = string.Equals(str1, str2, StringComparison.InvariantCulture);
    Console.WriteLine(areEqual);

    areEqual = string.Equals(str1, str2, StringComparison.CurrentCulture);
    Console.WriteLine(areEqual);
}
static void StringFormat()
{
    string name = "John";
    int age = 30;
    string str1 = string.Format("My name is {0} and I`m {1}", name, age);
    string str2 = $"My name is {name} and I`m {age}"; // $ - интерполирование строк
                                                      //string str2 = "My name is" + name + "and I`m " + age;
    Console.WriteLine(str1);
    Console.WriteLine(str2);

    string str3 = "My name is \nJohn"; //windows; \t \r n\ is escape sequance
    Console.WriteLine(str3);

    string str4 = "I`m \t30";
    Console.WriteLine(str4);

    str3 = $"My name is {Environment.NewLine} John"; //croosplatformer
    Console.WriteLine(str3);

    string str5 = "I`m John and I`m a \"good\" progammer";
    Console.WriteLine(str5);

    string str6 = "C:\\tmp\\test_file.txt";
    Console.WriteLine(str6);

    str6 = @"C:\tmp\test_file.txt";
    Console.WriteLine(str6);

    int answer = 42;
    string result = string.Format("{0:d}", answer); // d int
    string result2 = string.Format("{0:d4}", answer); // 0042
    Console.WriteLine(result);
    Console.WriteLine(result2);

    result = string.Format("{0:f}", answer); //f float 42,00
    result2 = string.Format("{0:f4}", answer); // 42,0000
    Console.WriteLine(result);
    Console.WriteLine(result2);

    Console.OutputEncoding = Encoding.UTF8;

    double money = 12.8;
    result = string.Format("{0:C}", money);  //C SystemOutputMoney
    result2 = string.Format("{0:C2}", money);
    Console.WriteLine(result);
    Console.WriteLine(result2);

    Console.WriteLine(money.ToString("C2"));

    result = $"{money:C2}";
    Console.WriteLine(result);
    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");
    Console.WriteLine(result);
}
static void stringBuilder()
{
    StringBuilder sb = new StringBuilder();
    sb.Append("My ");
    sb.Append("name ");
    sb.Append("is ");
    sb.Append("John");
    sb.AppendLine("!");
    sb.AppendLine("Hello!");

    string str = sb.ToString();
    Console.WriteLine(str);
}
static void StringModifications()
{
    string nameConcat = string.Concat("My", "name ", "is ", "John");
    Console.WriteLine(nameConcat);

    nameConcat = string.Join(" ", "My", "name", "is", "John");
    Console.WriteLine(nameConcat);

    nameConcat = "My " + "name " + "John";

    //string newName
    nameConcat = nameConcat.Insert(0, "By the way, ");
    Console.WriteLine(nameConcat);

    nameConcat = nameConcat.Remove(0, 1);
    Console.WriteLine(nameConcat);

    string replaced = nameConcat.Replace('n', 'z');
    Console.WriteLine(nameConcat);

    string data = "12;28;34;25;64";
    string[] spliData = data.Split(';');
    string first = spliData[0];
    Console.WriteLine(first);

    char[] chars = nameConcat.ToCharArray();
    Console.WriteLine(chars[0]);

    Console.WriteLine(nameConcat[0]); //same

    string lower = nameConcat.ToLower();
    Console.WriteLine(lower);

    string upper = nameConcat.ToUpper();
    Console.WriteLine(upper);

    string john = " My name is John ";
    Console.WriteLine(john.Trim());
}
static void NullAndWhitspaces()
{
    string str = string.Empty; // == "" in empty
    string empty = "";
    string whiteSpaced = " ";
    string notEmpty = " b";
    string nullstring = null;

    Console.WriteLine("IsNullorEmpty");
    bool isNullOrEmpty = string.IsNullOrEmpty(nullstring);
    Console.WriteLine(isNullOrEmpty);

    isNullOrEmpty = string.IsNullOrEmpty(empty);
    Console.WriteLine(isNullOrEmpty);

    isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
    Console.WriteLine(isNullOrEmpty);

    isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
    Console.WriteLine(isNullOrEmpty);

    Console.WriteLine();
    Console.WriteLine("IsNullOrWhiteSpace");

    bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullstring);
    Console.WriteLine(isNullOrWhiteSpace);

    isNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
    Console.WriteLine(isNullOrWhiteSpace);

    isNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
    Console.WriteLine(isNullOrWhiteSpace);

    isNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
    Console.WriteLine(isNullOrWhiteSpace);

}
static void BasicOfAPI()
{
    string name = "abracadabra";
    bool containsA = name.Contains('a');
    bool containsE = name.Contains('E');

    Console.WriteLine(containsA);
    Console.WriteLine(containsE);

    bool endsWithAbra = name.EndsWith("abra");
    Console.WriteLine(endsWithAbra);

    bool startsWithAbra = name.StartsWith("abra");
    Console.WriteLine(startsWithAbra);

    int indexOfA = name.IndexOf('a', 1);
    Console.WriteLine(indexOfA);

    int lastIndexOfR = name.LastIndexOf('r');
    Console.WriteLine(lastIndexOfR);

    Console.WriteLine(name.Length);

    string substrFrom5 = name.Substring(5);
    string substrFromTo = name.Substring(0, 3);

    Console.WriteLine(substrFrom5);
    Console.WriteLine(substrFromTo);

}
static void StaticAndInstanceMember()
{
    string name = "abracadabra";
    bool containsA = name.Contains('a'); // член уровня экземпляра name.Contains
    bool containsE = name.Contains('E');

    Console.WriteLine(containsA);  // статический член Console.WriteLine
    Console.WriteLine(containsE);

    string abs = string.Concat("a", "b", "c");  // статический член string.Concat
    Console.WriteLine(abs);

    Console.WriteLine(int.MinValue);

    int x = 1;
    string xStr = x.ToString();
    Console.WriteLine(xStr);
    Console.WriteLine(x);
}
static void Comparsion()
{
    int x = 1;
    int y = 2;

    bool areEqual = x == y;
    Console.WriteLine(areEqual);

    bool result = x > y;
    Console.WriteLine(result);

    result = x >= y;
    Console.WriteLine(result);

    result = x < y;
    Console.WriteLine(result);

    result = x <= y;
    Console.WriteLine(result);

    result = x != y;
    Console.WriteLine(result);
}
static void MathOperations() 
{
    int x = 1;
    int y = 2;

    int z = x + y;
    int k = x - y;
    int a = z + k - y;

    Console.WriteLine(z);
    Console.WriteLine(k);
    Console.WriteLine(a);

    int b = z * 2;
    int c = k / 2;

    Console.WriteLine(b);
    Console.WriteLine(c); // result is double 0.5 c = 0

    a = 4 % 2; //0
    b = 5 % 2; //1

    Console.WriteLine(a);
    Console.WriteLine(b);

    a = 3;
    a = a * a;
    Console.WriteLine(a);

    a *= 2;
    Console.WriteLine(a);

    a /= 2;
    Console.WriteLine(a);



}
static void IncrementDecrement() 
{
    int x = 1;
    x = x + 1;

    Console.WriteLine(x); //2

    x++;
    Console.WriteLine(x); //3

    ++x;
    Console.WriteLine(x); //4

    x = x - 1;            //3
    x--;                  //2
    --x;                  //1

    Console.WriteLine(x);

    Console.WriteLine("Learn about increments");
    Console.WriteLine($"Last x state is {x}");

    int j = x++;
    Console.WriteLine(j); // "j" is 1, "x" is 2
    Console.WriteLine(x);

    j = ++x;
    Console.WriteLine(j); // "j" and "x" are equal 3
    Console.WriteLine(x);

    x += 2;
    // x = x + 2
    Console.WriteLine(x);

    j -= 2;
    //j = j - 2
    Console.WriteLine(j);
}
static void Overflow()
{
    checked
    {
        uint x = uint.MaxValue;

        Console.WriteLine(x);

        x = x + 1;

        Console.WriteLine(x);

        x = x - 1;

        Console.WriteLine(x);
    }
    
}
static void Scope()
{
    var a = 1;
    {
        var b = 2;
        {
            var c = 3;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        Console.WriteLine(a);
        Console.WriteLine(b);
        //Console.WriteLine(c);
    }
    Console.WriteLine(a);
    //Console.WriteLine(b);
    //Console.WriteLine(c);
}
static void Literal()
{
    int x = 0b11;
    int y = 0b1001;
    int k = 0b10001001;
    int m = 0b1000_1001;

    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(k);
    Console.WriteLine(m);

    x = 0x1F;
    y = 0xFF0D;
    k = 0x1FAB30EF;
    m = 0x1FAB_30EF;

    Console.WriteLine();

    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(k);
    Console.WriteLine(m);

    Console.WriteLine();

    Console.WriteLine(4.5e2);
    Console.WriteLine(3.1e-1);

    Console.WriteLine();

    Console.WriteLine('\x78');
    Console.WriteLine('\x5A');

    Console.WriteLine('\u0420');
    Console.WriteLine('\u0421');
}
static void Variables()
{
    int x = -1;

    int y;
    y = 2;

    //Int32 x1 = -1;

    //uint z = -1;

    float f = 1.1f;

    double d = 1.1;

    int x2 = 0;
    int x3 = new int();

    var a = 1;
    var b = 1.1;

    //Dictionary<int, string> dict = new Dictionary<int, string>();
    var dict = new Dictionary<int, int>();

    decimal money = 3.0m;

    char character = 'A';

    string name = "John";

    bool candrive = false;
    bool canDraw = true;

    object obj1 = 1;
    object obj2 = "obj2";

    Console.WriteLine(a);
    Console.WriteLine(name);
}