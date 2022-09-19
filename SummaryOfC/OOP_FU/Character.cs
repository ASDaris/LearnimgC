using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FU
{
    class Point2D
    {
        private int x;
        private int y;

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Character
    {
        private static int Speed = 10; // static значение к каждому экземляру память выделяется единожды значение шарится на каждый экземляр
        public int Health { get; private set; } = 100; //autoproperty


        //public int GetHealth()
        //{
        //    return health;
        //}
        //private void SetHealth(int value)
        //{
        //    health = value;
        //}

        public void Hit(int damage)
        {
            if (Health == 0)
                throw new InvalidOperationException("Can't hit a dead character.");

            if (damage > Health)
                damage = Health;

            //health -= damage;
            Health -= damage;
            
        }
        public Race Race { get; private set; }

        private const int speed = 10; // постоянной обязательно присваивается значение которое ниоткуда не меняется
        private readonly int speed1; // можно инициализировать в конструктуре

        public int Armor { get; private set; }
        public string Name { get; private set; }

        public Character()
        {

        }
        public Character(string name, int armor)
        {
              if(name == null)
                throw new ArgumentNullException("Name arg can't be null");

            if (armor < 0 || armor > 100)
                throw new ArgumentException("armor cat't be less than 0 and greater then 100");

            Name = name;
            Armor = armor;

        }
        public Character(Race race)
        {
            Race = race;
            switch (race)
            {
                case Race.Elf:
                    Armor = 30;
                    break;
                case Race.Ork:
                    Armor = 40;
                    break;
                case Race.Terrain:
                    Armor = 20;
                    break;
                default:
                    throw new ArgumentException("Unknown race");
            }

            if (race == Race.Terrain)
            {
                Armor = 20;
            }
            else if (race == Race.Ork)
            {
                Armor = 40;
            }
            else if (race == Race.Elf)
            {
                Armor = 30;
            }
            else
            {
                throw new ArgumentException("Unknown race");
            }
        }
        //public Character(string race, int armor)
        //{
        //    Race = race;
        //    Armor = armor;
        //}
        //public Character(string race, int armor, int speed)
        //{
        //    Race = race;
        //    Armor= armor;
        //    this.speed1 = speed;
        //}

        public int PrintSpeed()
        {
            return Speed;
        }
        public void IncreaseSpeed()
        {
            Speed += 10;
        }
    }
}
