using System.Drawing;

namespace Module_6.Unit_6
{
    enum TurnDirection
    {
        None = 0,
        Left,
        Right
    }//Поворотники
    public class Car
    {
        private double Fuel;
        private int Mileage;
        private string color;
        private TurnDirection turn;
        public Car()
        {
            Fuel = 50;
            Mileage = 0;
            color = "White";
        }
        private void Move()
        {
            Mileage++;
            Fuel -= 0.5;
        }
        private void Turn(TurnDirection direction)
        {
            turn = direction;
        }
        public void FillTheCar()
        {
            Fuel = 50;
        }
        public string GetColor()
        {
            return color;
        }
        public void ChangeColor(string newColor)
        {
            if (color != newColor)
            {
                color = newColor;
            }
        }
        public bool IsTurningLeft()
        {
            return turn == TurnDirection.Left;
        }
        public bool IsTurningRight() 
        {
            return turn == TurnDirection.Right;
        }
    }
    // Задание 6.6.1 Класс светофор
    public class TrafficLight
    {
        private string _color;

        private void ChangeColor(string color)
        {
        }
        public string GetColor()
        { 
            return _color;
        }
    }
    class User
    {
        private string login;
        private string mail;
        private int age;
        public int Age 
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }//Свойство поля Age
        public string Login 
        {
            get
            {
                return login;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Поле логина должно быть не менее 3 символов длиной");
                }
                else 
                {
                    login = value;
                }
            } 
        }
        public string Mail
        {
            get { return mail; }
            set 
            {
                if (value.Contains('@'))
                {
                    mail = value;
                }
                else
                {
                    Console.WriteLine("Неверный формат почтового адреса");
                }
            }

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Age = 32;
            Console.WriteLine("Возраст пользователя равен: {0}", user.Age);
        }
    }
}
