using System;

namespace HW_17_03_07_2024
{
    //    Завдання 3:
    //Створіть користувацький тип «Пристрій», який зберігатиме таку
    //інформацію:
    // назва пристрою;
    // виробник пристрою;
    // вартість.
    //Для двох масивів пристроїв реалізуйте операції:
    // різниця масивів;
    // перетин масивів;
    // об'єднання масивів.
    //Критерій для проведення операцій — виробник пристрою
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Device> devices1 = new List<Device>() {
               new Device("iPhone 13 Pro", "Apple",1000.0),
               new Device("PlayStation 5", "Sony",699.0),
               new Device("Xiaomi Mi Band 6", "Xiaomi",150.0),
               new Device("Galaxy S21 Ultra", "Samsung", 950.0)
           };
            List<Device> devices2 = new List<Device>() {
               new Device("MacBook Air M1", "Apple",1100.0),
               new Device("Fitbit Charge 4", "Fitbit",210.0),
               new Device("Kindle Paperwhite", "Amazon",180.0),
               new Device("Nintendo Switch", "Nintendo", 320.0)
           };
            // різниця масивів; по фирме
            var diffArr = devices1.Where(dev1 => !devices2.Any(dev2=> dev2.DevManuf == dev1.DevManuf));
            foreach (Device dev in diffArr) { Console.WriteLine(dev); }
            // перетин масивів; по фирме
            Console.WriteLine();
            var intersArr = devices1.Where(dev1 => devices2.Any(dev2 => dev2.DevManuf == dev1.DevManuf));
            foreach (Device dev in intersArr) { Console.WriteLine(dev); }
            // об'єднання масивів.
            Console.WriteLine();
            var combArr = devices1.Union(devices2);
            foreach (Device dev in combArr) { Console.WriteLine(dev); }

        }
    }
};





