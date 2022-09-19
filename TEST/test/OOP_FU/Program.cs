using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FU
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Управление памятью, 
             * С# разработчики пишут управляемый код, CLR берет на себя ответственность за упраление памятью в автоматизированном режиме, и в следствии нам не нужно аллоцировать (выделять),
             * деалоцировать (возвращать) в явном виде, в .NET существует GC (Garbage collector) - удаляет из памяти мусор,трудно достижимые объекты
             * Для определения достижимости объекта CLR строит граф достижимости всех объектов, граф строится от root корневые объекты, когда корневой объект выходит за границы во время
             * исполнения кода и он больше не нужен программе CLR определяя такой объект смотрит зависимые от этого корня объекты, удаляет их целыми графами тем самым чистит память
             * Все объекты делятся на управляемы и неуправляемые
             * Неуправляемые объекты - объекты, которые содержат неуправляемые ресурсы
             * Неуправляемые ресурсы - системные ресурсы, такие как объекты чтения файлов, подключаемых к БазаДанных, сети и т.д. о таких ресурсах GC не знает
             * Управляемые объекты - все объекты не содержащие неуправляемых ресурсов
             * Если неуправляемый ресурс не был очищен явно, то может возникнуть утечка памяти
             * В С# предусмотрено 2 способа очищения неуправляемого мусора
             * 1) неявный вызываемый GC
             * System.Object определяет метод:
             * protected virtual void Finalize();
             * Объекты переопределяющие Finalize() называются финализируемыми
             * Момент финализации не детерминирован, неизвестно когда будет вызван
             * Когда CLR финализирует объект, он становится в очередь на освобождение памяти из под него. Память будет очищена (изъята) только при следующей сборке мусора
             * 
             * 2) явный
             * System.IDisposable определяет метод:
             * void Dispose();
             * Интерфейс который можно использовать на неуправляемых ресурсах и явно убирать его.
             * Типы, реализующие IDisposable могут быть обёрнуты в using:
             * using (SqlConnection conn = new SqlConnection()) {}
             * будет скомпилировано как:
             * SqlConnection conn = new SqlConnection());
             * try {
             * } finally {
             *      conn.Dispose();
             * }
             * 
             * Часто достаточно просто реализовать IDisposable
            */
        }
        static void StackAdvanced()
        {
            MyStack<int> ms = new MyStack<int>();
            ms.Push(1);
            ms.Push(2);
            ms.Push(3);

            foreach (var item in ms) // подписан на контракт IEnurable
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            while (ms.Count != 0)
            {
                Console.WriteLine(ms.Peek());
                ms.Pop();
            }
            Console.WriteLine(ms.Peek());

            ms.Pop();

            Console.WriteLine(ms.Peek());

            ms.Push(3);
            ms.Push(4);
            ms.Push(5);

            Console.WriteLine(ms.Peek());
        }
        static void StackDemoAndGenerics()
        {
            MyStack<int> ms = new MyStack<int>();
            ms.Push(1);
            ms.Push(2);
            ms.Push(3);

            while (ms.Count != 0)
            {
                Console.WriteLine(ms.Peek());
                ms.Pop();
            }
            Console.WriteLine(ms.Peek());

            ms.Pop();

            Console.WriteLine(ms.Peek());

            ms.Push(3);
            ms.Push(4);
            ms.Push(5);

            Console.WriteLine(ms.Peek());
        }
        static void EnumDemo()
        {
            Character c = new Character(Race.Elf);
        }
        static void ProblemOfRepresentatives()
        {
            IShape rect = new Rect() { Height = 2, Wight = 5 };
            IShape square = new Square() { SideLenght = 10 };

            Console.WriteLine($"Rect area = {rect.CalcSquare()}");
            Console.WriteLine($"Square area = {square.CalcSquare()}");


            //Rect rect = new Rect { Height = 2, Wight = 5};
            //int rectArea = AreaCalculator.CalcSquare(rect);
            //Console.WriteLine($"Rect Area = {rectArea}");

            //Rect square = new Square { Height = 2, Wight = 10 }; // problem of represantative
            //AreaCalculator.CalcSquare(square);

            // Square is a Rectangle but can not inheritance from it

            Console.ReadLine();
        }
        static void CallingTroughtInterface()
        {
            List<object> list = new List<object> { 1, 2, 3 };
            IBaseCollection collection = new BaseList(4);
            collection.AddRange(list);
            collection.Add(1);
        }
        static void Polymorphism1()
        {
            //Shape shape = new Shape()
            Shape[] shapes = new Shape[2];
            shapes[0] = new Triangle(10, 20, 30);
            shapes[1] = new Rectangle(5, 10);

            foreach (Shape shape in shapes)
            {
                shape.Draw();
                Console.WriteLine(shape.Perimetr());
            }
        }
        static void Polymorphism2(Shape shape)
        {
            shape.Draw();
        }
        static void BoxingUnboxing1()
        {
            int x = 1;
            object obj = x; // boxing process, значение value type переносится в кучу и переменная obj является ссылкой на область памяти
            int y = (int)obj; // unboxing process

            double pi = 3.14;
            object obj1 = pi;

            int number = (int)(double)obj1; // object may have any types what makes it dificilt to implement
        }
        static void BoxingUnboxingDo(object obj)
        {
            bool isPointRef = obj is PointRef;
            if (isPointRef)
            {
                PointRef pr = (PointRef)obj;
                Console.WriteLine(pr.X);
            }
            else
            {
                //do smth.
            }

            PointRef pr1 = obj as PointRef; // если не PointRef то null
            if (pr1 != null)
            {
                Console.WriteLine(pr1.X);
            }
        }
        static void NullableValueType()
        {
            PointVal? pv = null; // Nullable-struct
            if (pv.HasValue)
            {
                PointVal pv2 = pv.Value;
                Console.WriteLine(pv.Value.X);
                Console.WriteLine(pv2.X);
            }
            else
            {
                //
            }
            PointVal pv3 = pv.GetValueOrDefault();

            PointRef c; // == PointRef c = null
            //Console.WriteLine(c.X); // NullReferenceException
        }
        static void PassByReference()
        {
            int a = 1;
            int b = 2;

            SwapRef(ref a, ref b); // передача ссылочных типов значений как аргументов
            Console.WriteLine($"a = {a}, b = {b}");

            Console.ReadLine();



            var list = new List<int>();
            AddNumbers(list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void SwapRef(ref int a,ref int b)
        {
            Console.WriteLine($"Original a = {a}, b = {b}");

            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine($"Swapped a = {a}, b = {b}");
        }
        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }
        static void ValueAndReferenceDataTypes()
        {

            /* Все объекты ( экземляры и структур и классов) располагаются в оперативной памяти, в ней имеются области называемые стек и куча(управляемая куча для .NET)
             * Обычно типы-значения (структуры) располагаются на стеке, а ссылочные типы (классы) располагаются в куче
             *  PointRef c = new PointRef();
             *  PointRef d = c; копия ссылки на адрес памяти, d и c указывают на один и тот же объект в памяти
            */
            PointVal a; //PointVal a; = new PointVal();
            a.X = 3;
            a.Y = 5;

            PointVal b = a; // выделяется новая память
            b.X = 7;
            b.Y = 10;

            a.LogValues();
            b.LogValues();

            Console.WriteLine("After structs");

            PointRef c = new PointRef();
            c.X = 3;
            c.Y = 5;

            PointRef d = c; // не выделяется новая память, ссылается на уже выделенную
            d.X = 7;
            d.Y = 10;

            c.LogValues();
            d.LogValues();

            //СТРУКТУРЫ СОДЕРЖАЩИЕ ССЫЛОЧНЫЕ ТИПЫ ДАННЫХ
            EvilStruct es1 = new EvilStruct();
            //es1.PointRef = new PointRef() { X = 1, Y = 2 }; //{ X = 1, Y = 2} object initializer syntax
            //es1.PointRef.X = 1;
            //es1.PointRef.Y = 2;
            EvilStruct es2 = es1;

            Console.WriteLine($"es1.PointRef.x = {es1.PointRef.X}, es1.PointRef.Y = {es1.PointRef.Y}");
            Console.WriteLine($"es1.PointRef.x = {es2.PointRef.X}, es1.PointRef.Y = {es2.PointRef.Y}");

            es2.PointRef.X = 42;
            es2.PointRef.Y = 45;

            Console.WriteLine($"es1.PointRef.x = {es1.PointRef.X}, es1.PointRef.Y = {es1.PointRef.Y}");
            Console.WriteLine($"es1.PointRef.x = {es2.PointRef.X}, es1.PointRef.Y = {es2.PointRef.Y}");

            Console.ReadLine();
        }
        static void CalcChar()
        {
            double result = Calculator.Average2(1, 2, 3);  // работать с классами статически значит не создавая экземляров

            Character c1 = new Character();
            Character c2 = new Character();

            Console.WriteLine($"c1.Speed = {c1.PrintSpeed}. c2.Speed = {c2.PrintSpeed}");

            c1.IncreaseSpeed();

            Console.WriteLine($"c1.Speed = {c1.PrintSpeed}. c2.Speed = {c2.PrintSpeed}");
        }
        static void OutParams()
        {
            Calculator calc = new Calculator();
            if (calc.TryDivide(10, 2, out double result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Failed to divide");
            }
            Console.ReadLine();

            Console.WriteLine("Enter a number, please");

            string line = Console.ReadLine();
            bool WasParsed = int.TryParse(line, out int number);
            if (WasParsed)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Failed to parse");
            }
        }
    }
}

