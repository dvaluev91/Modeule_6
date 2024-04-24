namespace Module_6.Unit_5
{
    class Car
    {
        public double Fuel;
        public int Mileage;

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
        }
        public void Move()
        {
            Mileage++;
            Fuel -= 0.5;
        }
        public void FillTheCar()
        {
            Fuel = 50;
        }
    }
    class Triangle
    {
        public int a;
        public int b;
        public int c;
        public int h;

        public double FindSquareTriangle()
        {
            return 0.5 * h * a;
        }
        public double FindPerimeterTriangl()
        {
            return a + b + c;
        }
        
    }
    class Circle
    {
        public const double Pi = 3.14;
        public int r;

        public double FindSquareCircle()
        { 
            return Pi * Math.Pow(r,2);
        }
        public double FindPerimeterCircle()
        {
            return Pi * 2 * r;
        }
    }
    class Square
    {
        public int side;

        public int FindSquare()
        {
            return side * side;
        }
        public int FindPerimeterSquare()
        {
            return side * 4;
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
