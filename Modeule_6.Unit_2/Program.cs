namespace Modeule_6.Unit_2
{
    class Human
    {
        //Поля класса
        public string name;
        public int age;

        //Метод класса
        public void Greetings()
        {
            Console.WriteLine($"Меня зовут {name}, мне {age}");
        }

        //Конструктор 1
        public Human()
        {
            name = "Неизвестно";
            age = 20;
        }
        //Конструктор 2
        public Human(string n)
        {
            name = n;
            age = 20;
        }
        //Конструктор 3
        public Human(string n, int a)
        {
            name = n;
            age = a;
        }
    }
    struct Animal
    {
        //Поля структуры
        public string type;
        public string name;
        public int age;

        //Метод структуры
        public void Info()
        {
            Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
        }
    }
    class Pen
    {
        public string color;
        public int cost;

        //Конструктор без параметров
        public Pen()
        {
            color = "Черный";
            cost = 100;
        }
        //Конструктор с 2 параметрами
        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }
        //Задание 6.2.8
        class Rectangle
        {
            public int a;
            public int b;
            //Конструктор по умолчанию
            public Rectangle() 
            {
                a = 6;
                b = 4;
            }
            //Конструктор a != b
            public Rectangle(int _a, int _b)
            {
                a = _a;
                b = _b;
            }
            //Конструктор a == b
            public Rectangle(int _a)
            {
                a = _a;
                b = _a;
            }
            public int Square()
            {
                return a * b;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Human human = new Human(); //Создание экземпляра класса с конструктором по умолчанию
            //human.Greetings();

            //human.name = "Denis";
            //human.age = 32;
            //human.Greetings();

            //human = new Human("Nikita", 7);
            //human.Greetings();
        }
    }
}
