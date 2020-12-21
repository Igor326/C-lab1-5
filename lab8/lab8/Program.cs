using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
             
                Console.WriteLine("Введите количество машин в гараже:");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        string name;
                        string color;
                        ushort year;
                        ushort speed;
                        Console.WriteLine("#====================================#");
                        Console.WriteLine("#Введите данные о машине № {0}:", i + 1);
                        Console.Write("#Имя:");
                        name = Convert.ToString(Console.ReadLine());
                        Console.Write("#Цвет:");
                        color = Convert.ToString(Console.ReadLine());
                        Console.Write("#Год выпуска:");
                        year = Convert.ToUInt16(Console.ReadLine());
                        Console.Write("#Максимальная скорость:");
                        speed = Convert.ToUInt16(Console.ReadLine());
                        Console.WriteLine("#====================================#");
                        Garage.AddCarToGarage(name, color, year, speed);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Неверное количество машин!");
                    continue;
                }
            }
            byte choice;
            Console.WriteLine("Что пожелаете?");
            Console.WriteLine("1.Добавить автомобиль;");
            Console.WriteLine("2.Убрать автомобиль;");
            Console.WriteLine("3.Выбрать атвомобиль по критерию.");
            choice = Convert.ToByte(Console.ReadLine());
            switch (choice)
            {
                case 1:

                    int num;
                    while (true)
                    {
                        Console.WriteLine("Введите количество машин которые хотите добавить:");
                        num = Convert.ToInt32(Console.ReadLine());
                        if (num > 0)
                        {
                            for (int i = 0; i < num; i++)
                            {
                                string name;
                                string color;
                                ushort year;
                                ushort speed;
                                Console.WriteLine("#====================================#");
                                Console.WriteLine("#Введите данные о машине № {0}:", i + 1);
                                Console.Write("#Имя:");
                                name = Convert.ToString(Console.ReadLine());
                                Console.Write("#Цвет:");
                                color = Convert.ToString(Console.ReadLine());
                                Console.Write("#Год выпуска:");
                                year = Convert.ToUInt16(Console.ReadLine());
                                Console.Write("#Максимальная скорость:");
                                speed = Convert.ToUInt16(Console.ReadLine());
                                Console.WriteLine("#====================================#");
                                Garage.AddCarToGarage(name, color, year, speed);
                            }

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Неверное количество машин!");
                            continue;
                        }
                    }

                    break;
                case 2:
                    byte id;
                    while (true)
                    {


                        Console.WriteLine("Введите идентификатор автомобиля, который ви хотите убрать:");
                        id = Convert.ToByte(Console.ReadLine());
                        if (id >= 0 && Garage.sheikCars[id] != null)
                        {
                            Garage.RemoveCarFromGarage(id);
                            Console.WriteLine("Была убрана машина с именем {0}, её цвет - {1}, год выпуска - {2}, её айди - {3}.",Garage.sheikCars[id].name, Garage.sheikCars[id].color, Garage.sheikCars[id].graduationYear, id);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Был введен неверный идентификатор");
                        }
                    }
                    break;
                case 3:
                    string Name;
                    string Color;
                    string Year;
                    int Year1;
                    byte counter;
                    Console.WriteLine("Введите данные по которым будет произведен поиск(введите знак -(минус) чтобы даный критерий  не учитовался ):");
                    Console.Write("Введите имя: ");
                    Name = Convert.ToString(Console.ReadLine());
                    Console.Write("Введите цвет: ");
                    Color = Convert.ToString(Console.ReadLine());
                    Console.Write("Введите год выпуска: ");
                    Year = Convert.ToString(Console.ReadLine());
                   // if (Year != "-")
                        Year1 = Convert.ToInt32(Year);
                    if (Name=="-")
                    {
                        for (int i = 0; i <Garage.sheikCars.Count ; i++)
                        {
                            if (Garage.sheikCars[i].color==Color && Garage.sheikCars[i].graduationYear==Year1)
                            {
                                Console.WriteLine("Была найдена машина с именем { 0}, её цвет - { 1}, год выпуска - { 2}, её айди - { 3}.", Garage.sheikCars[i].name, Garage.sheikCars[i].color, Garage.sheikCars[i].graduationYear, i);
                            }
                        }

                    }
                    if (Color == "-")
                    {
                        for (int i = 0; i < Garage.sheikCars.Count; i++)
                        {
                            if (Garage.sheikCars[i].name == Name && Garage.sheikCars[i].graduationYear == Year1)
                            {
                                Console.WriteLine("Была найдена машина с именем { 0}, её цвет - { 1}, год выпуска - { 2}, её айди - { 3}.", Garage.sheikCars[i].name, Garage.sheikCars[i].color, Garage.sheikCars[i].graduationYear, i);
                            }
                        }

                    }
                    if (Year == "-")
                    {
                        for (int i = 0; i < Garage.sheikCars.Count; i++)
                        {
                            if (Garage.sheikCars[i].color == Color && Garage.sheikCars[i].name == Name)
                            {
                                Console.WriteLine("Была найдена машина с именем { 0}, её цвет - { 1}, год выпуска - { 2}, её айди - { 3}.", Garage.sheikCars[i].name, Garage.sheikCars[i].color, Garage.sheikCars[i].graduationYear, i);
                            }
                        }

                    }

                    break;
                default:
                    Console.WriteLine("Такого пункта нет в списке");
                    break;
                    


            }

            //Garage.AddCarToGarage("Ford", "red", 1969);
            //Garage.AddCarToGarage("Ferrari", "grey", 1992);
            //Console.WriteLine(Garage.sheikCars[0].name);
            //Console.WriteLine(Garage.sheikCars[1].name);


        }
    }
}
