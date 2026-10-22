using System;
using System.ComponentModel;
//ДЗ ВТОРОЙ ВАРИАНТ ТОЛЬКО ФАЙЛ CS
namespace Structure
{
    internal class Program
    {
        //---СТРУКТУРА РЮКЗАК---

        //struct BackPack
        //{
        //    public string brand; //брэнд
        //    public string type;//тип
        //    public ushort straps;//кол-во лямок
        //    public string color; //цвет
        //    public string clasp; //тип застежки
        //    public ushort pockets;//кол-во карманов
        //    public string size;//размер
        //    // метод
        //    public void PrintInfo() //вывод информации о структуре
        //    {
        //        Console.Write($"Информация о сумке:\nБрэнд: {brand}\nТип: {type}\nКоличество лямок: {straps}\nЦвет: {color}\nТип застежки: {clasp}\nКоличество карманов: {pockets}\nРазмер: {size}");
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Console.Clear();
        //    BackPack bag;
        //    bag.brand = "YkycNcykY";
        //    bag.type = "Походный рюкзак";
        //    bag.straps = 3;
        //    bag.color = "Мультикам";
        //    bag.clasp = "Молния и липучка";
        //    bag.pockets = 10;
        //    bag.size = "Большой";
        //    bag.PrintInfo();
        //    Console.ReadKey();
        //}


        //---СТРУКТУРА ТРЕУГОЛЬНИК--- (1способ обхода приват)

        //struct Traingle
        //{
        //    public ushort sizeA;
        //    public ushort sizeB;
        //    public ushort sizeC;

        //    //1 способ обхода модификатора private (Вызов приватного метода из публичного)
        //    public void PrintInfo()
        //    {
        //        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        //        Console.ForegroundColor = ConsoleColor.White;
        //        Console.WriteLine("---Информация о треугольнике---");
        //        Console.Write($"Длины сторон\nСторона A: {sizeA}\nСторона B: {sizeB}\nСторона C: {sizeC}");
        //        Console.WriteLine($"\nПлощадь: {Area(sizeA, sizeB, sizeC)}");
        //    }
        //    double Area(ushort sizeA, ushort sizeB, ushort sizeC)
        //    {
        //        double semiperimeter = (sizeA + sizeB + sizeC) / 2; //полупериметр
        //        double temp = semiperimeter * (semiperimeter - sizeA) * (semiperimeter - sizeB) * (semiperimeter - sizeC);
        //        temp = Math.Round(Math.Sqrt(temp), 4);
        //        return temp;
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Console.Clear();
        //    Traingle obj;
        //    obj.sizeA = 5;
        //    obj.sizeB = 5;
        //    obj.sizeC = 5;
        //    obj.PrintInfo();

        //    Console.ReadKey();
        //}

        //(2 способ обхода приват)

        //struct UserInfo
        //{
        //    string name;
        //    string login;
        //    string password;

        //    //1 вариант
        //    //public UserInfo(string _name, string _login, string _password, string _email)
        //    //{
        //    //    name = _name;
        //    //    login = _login;
        //    //    password = _password;
        //    //    email = _email;
        //    //}

        //    //2 вариант
        //    public UserInfo(string name, string login, string password) //конструктор
        //    {
        //        this.name = name;
        //        this.login = login;
        //        this.password = password;
        //        //PrintInfo();
        //    }

        //    void PrintInfo()
        //    {
        //        Console.WriteLine("Информация о пользователе:");
        //        Console.WriteLine($"Имя: {name}\nЛогин: {login}\nПароль: {password}");

        //    }

        //    //static void Main(string[] args)
        //    //{
        //    //    Console.Clear();
        //    //    UserInfo user = new UserInfo("Милана КрутаяБабушка", "milanka78", "plaonskrypnuk");
        //    //    Console.ReadKey();
        //    //}
        //}  
        //static UserInfo CreateUserInfoForPrint()
        //{
        //    Console.Write("Введите имя нового пользователя: ");
        //    string name = Console.ReadLine();
        //    while (string.IsNullOrWhiteSpace(name))
        //    {
        //        Console.WriteLine("НЕКОРРЕКТНОЕ ЗНАЧЕНИЕ");
        //        Console.Write("Попробуйте еще раз: ");
        //        name = Console.ReadLine();
        //    }
        //    Console.Write("Введите логин: ");
        //    string login = Console.ReadLine();
        //    while (string.IsNullOrWhiteSpace(login))
        //    {
        //        Console.WriteLine("НЕКОРРЕКТНОЕ ЗНАЧЕНИЕ");
        //        Console.Write("Попробуйте еще раз: ");
        //        login = Console.ReadLine();
        //    }
        //    Console.Write("Введите пароль: ");
        //    string password = Console.ReadLine();
        //    while (string.IsNullOrWhiteSpace(password))
        //    {
        //        Console.WriteLine("НЕКОРРЕКТНОЕ ЗНАЧЕНИЕ");
        //        Console.Write("Попробуйте еще раз: ");
        //        password = Console.ReadLine();
        //    }
        //    return new UserInfo(name, login, password);
        //}
        //static void Main(string[] args)
        //{
        //    Console.Clear();
        //    UserInfo user = CreateUserInfoForPrint();
        //    Console.ReadKey();
        //}

        //struct TriangleInfo
        //{
        //    ushort sizeA;
        //    ushort sizeB;
        //    ushort sizeC;

        //    public TriangleInfo(ushort sizeA, ushort sizeB, ushort sizeC)
        //    {
        //        this.sizeA = sizeA;
        //        this.sizeB = sizeB;
        //        this.sizeC = sizeC;
        //        PrintInfo();
        //    }
        //    void PrintInfo()
        //    {
        //        Console.WriteLine("---Информация о треугольнике---");
        //        Console.Write($"Длины сторон\nСторона A: {sizeA}\nСторона B: {sizeB}\nСторона C: {sizeC}");
        //        Console.WriteLine($"\nПлощадь: {Area(sizeA, sizeB, sizeC)}");
        //    }
        //    double Area(ushort sizeA, ushort sizeB, ushort sizeC)
        //    {
        //        double semiperimeter = (sizeA + sizeB + sizeC) / 2; //полупериметр
        //        double temp = semiperimeter * (semiperimeter - sizeA) * (semiperimeter - sizeB) * (semiperimeter - sizeC);
        //        temp = Math.Round(Math.Sqrt(temp), 2);
        //        return temp;
        //    }

        //    static void Main(string[] args)
        //    {
        //        Console.Clear();
        //        TriangleInfo first = new TriangleInfo(5, 6, 4);
        //        Console.ReadKey();
        //    }
        struct HotelInfo
        {
            string name;
            sbyte roomsCount;
            string category;
            double price;

            public HotelInfo (string name, sbyte roomsCount, string category, double price)
            {
                this.name = name;
                this.roomsCount = roomsCount;
                this.category = category;
                this.price = price;
                PrintInfo();
            }

            void PrintInfo()
            {
                Console.WriteLine("-----Информация о гостинице-----");
                Console.WriteLine($"Имя: {name}\nКоличество номеров: {roomsCount}\nКатегория: {category}\nЦена: {price}");
            }
            static void Main(string[] args)
            {
                Console.Clear();
                HotelInfo user = new HotelInfo("ФайвПалмс", 50, "блатной", 124953);
                HotelInfo secondUser = new HotelInfo("Северная", 25, "не", 2345);
                Console.ReadKey();
            }
        }
    }
}

