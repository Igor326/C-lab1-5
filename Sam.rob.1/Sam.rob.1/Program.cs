using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.rob._1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int choose=0;
            Liquor Vodka = new Liquor("Belvedere Vodka",19.0,0,"Польща",0.5 ) ;
            Liquor Tequilla = new Liquor("San Jose",11.0, 0,"Мекиска",0.7);
            Liquor Scotch = new Liquor("Passport Scotch",18.0, 36,"Шотландия",0.7);
            Liquor Cognac = new Liquor("Hennessy", 32,36," Франция", 0.7);
            Liquor Rum = new Liquor("Captain Morgan", 19.5, 48, "Карибские острова", 1.0);
            
            Console.WriteLine("Выберите себе напиток по вкусу:(введите с клавиатуры число 1-5)");
            Console.WriteLine("1.Водка");
            Console.WriteLine("2.Текила");
            Console.WriteLine("3.Скотч");
            Console.WriteLine("4.Коньяк");
            Console.WriteLine("5.Ром");
            while (true)
            {
                choose = Convert.ToInt32(Console.ReadLine());
                if(choose<1 || choose > 5)
                {
                    Console.WriteLine("Введен некоректные данные, ввелие ругие!");
                    continue;
                }
                break;
            }
            switch (choose){
                case 1:
                    Console.WriteLine("Вы выбрали водку!");
                    Vodka.Info();
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали текилу!");
                    Tequilla.Info();
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали скотч!");
                    Scotch.Info();
                    break;
                case 4:
                    Console.WriteLine("Вы выбрали коньяк!");
                    Cognac.Info();
                    break;
                case 5:
                    Console.WriteLine("Вы выбрали ром!");
                    Rum.Info();
                    break;

            }


        }
    }
}
