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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
