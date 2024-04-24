namespace Module_6.Unit_3
{
    class Company
    {
        public string Type;
        public string Name;
    }
    class Department
    {
        public Company Company;
        public City City;
    }
    class City
    {
        public string Name;
    }
    class Bus
    {
        public int? Load;

        public void PrintStaatus()
        {
            if (Load.HasValue && Load > 0)
            {
                Console.WriteLine("Количество пассажиров в автобусе равно {0}", Load);
            }
            else 
            {
                Console.WriteLine("Автобус пуст!");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Department department = new Department();
            department.Company = new Company();
            department.Company.Name = null;
            department.Company.Type = "Банк";
            department.City = new City();
            department.City.Name = "Санкт-Петербург";
            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                string NameCompany = department?.Company?.Name ?? "Неизвестная компания";
                Console.WriteLine($"У банка {NameCompany} есть отделение в Санкт-Петербурге");
            }    
            Bus bus = new Bus();
            bus.Load = 2;
            bus.PrintStaatus();
            bus.Load = 0;
            bus.PrintStaatus();
        }
    }
}
