using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FU
{
    public struct EvilStruct
    {
        public int X;
        public int Y;

        public readonly PointRef PointRef;

        public EvilStruct(int x, int y) // в структуре явный конструктор запрещен, должны принять аргументы и проиниципизировать все поля
        {
            X = x;
            Y = y;

            PointRef = new PointRef();
        }

        public void Do()
        {
            //PointRef = new PointRef();  в методах не может быть создано или изменено
        }
    }
    public struct PointVal  // структуры это типы значений value
    {
        public int X;
        public int Y;

        public void LogValues()
        {
            Console.WriteLine($"X = {X}. Y = {Y}");
        }
    }
    public class PointRef // классы это ссылочные типы reference
    {
        public int X;
        public int Y;

        public void LogValues()
        {
            Console.WriteLine($"X = {X}. Y = {Y}");
        }
    }
}
