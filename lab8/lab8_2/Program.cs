using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дисковый телефон:");
            diskPhone rotaryPhone = new diskPhone("911");

            Console.Write("Символы, доступные для ввода: ");
            foreach (var sym in rotaryPhone.AvailableSymbols)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {rotaryPhone.phoneNumber}");
            rotaryPhone.MakeCall();
            rotaryPhone.TakeCall("112");
            Console.WriteLine("=========================");
            Console.WriteLine("Кнопочный телефон:");
            PushButtonTelephone keyPhone = new PushButtonTelephone("222");

            Console.Write("Символы, доступные для ввода: ");
            foreach (var sym in keyPhone.AvailableSymbols)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {keyPhone.phoneNumber}");
            keyPhone.MakeCall();
            keyPhone.TakeCall("112");
            Console.WriteLine("=========================");

            Console.WriteLine("Телефон с черно-белым экраном:");
            mobileWithBlackAndWhiteScreen blackWhitePhone = new mobileWithBlackAndWhiteScreen("333", 400, 150, 2.8, "Черный");

            Console.Write("Символы, доступные для ввода: ");
            foreach (var sym in blackWhitePhone.AvailableSymbols)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {blackWhitePhone.phoneNumber}");
            Console.WriteLine($"Ширина экрана (пиксели): {blackWhitePhone.ScreenWidth}");
            Console.WriteLine($"Высота экрана (пиксели): {blackWhitePhone.ScreenHeight}");
            Console.WriteLine($"Размер экрана (дюймы): {blackWhitePhone.ScreenSize}");
            Console.WriteLine($"Цвет телефона: {blackWhitePhone.PhoneColor}");
            blackWhitePhone.MakeCall();
            blackWhitePhone.TakeCall("112");
            blackWhitePhone.SendSMS();
            blackWhitePhone.TakeSMS("112");


            Console.WriteLine("=========================");

            Console.WriteLine("Телефон с цветным экраном:");
            mobileWithColorScreen colorPhone = new mobileWithColorScreen("444", 200, 400, 3.2, "Черный", 16000000, "445");

            Console.Write("Символы, доступные для ввода: ");
            foreach (var sym in colorPhone.AvailableSymbols)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {colorPhone.phoneNumber}");
            Console.WriteLine($"Ширина экрана (пиксели): {colorPhone.ScreenWidth}");
            Console.WriteLine($"Высота экрана (пиксели): {colorPhone.ScreenHeight}");
            Console.WriteLine($"Размер экрана (дюймы): {colorPhone.ScreenSize}");
            Console.WriteLine($"Цвет телефона: {colorPhone.PhoneColor}");
            Console.WriteLine($"Количество сим-карт: {(colorPhone.TwoSIM ? 2 : 1)}");
            Console.WriteLine($"Второй номер: {(colorPhone.TwoSIM ? colorPhone.SecondaryPhoneNumber : "-")}");
            colorPhone.MakeCall();
            colorPhone.TakeCall("112");
            colorPhone.SendSMS();
            colorPhone.TakeSMS("112");
            colorPhone.SendMMS();
            colorPhone.TakeMMS("112");


            Console.WriteLine("=========================");
            Console.WriteLine("Смартфон:");
            smartphone smartPhone = new smartphone("555", 1080, 1920, 6.28, "Черный", 16777216, 10, 3);

            Console.Write("Доступные символы: ");
            foreach (var sym in smartPhone.AvailableSymbols)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {smartPhone.phoneNumber}");
            Console.WriteLine($"Ширина экрана (пиксели): {smartPhone.ScreenWidth}");
            Console.WriteLine($"Высота экрана (пиксели): {smartPhone.ScreenHeight}");
            Console.WriteLine($"Размер экрана (дюймы): {smartPhone.ScreenSize}");
            Console.WriteLine($"Цвет телефона: {smartPhone.PhoneColor}");
            Console.WriteLine($"Количество сим-карт: {(smartPhone.TwoSIM ? 2 : 1)}");
            Console.WriteLine($"Второй номер: {(smartPhone.TwoSIM ? smartPhone.SecondaryPhoneNumber : "-")}");
            Console.WriteLine($"Сенсорный экран: {(smartPhone.IsTouchScreen ? "да" : "нет")}");
            Console.WriteLine($"Максимальное количество касаний: {smartPhone.MaxTouches}");
            Console.WriteLine($"Количество камер: {smartPhone.CamerasQuantity}");
            smartPhone.MakeCall();
            smartPhone.TakeCall("101");
            smartPhone.SendSMS();
            smartPhone.TakeSMS("101");
            smartPhone.SendMMS();
            smartPhone.TakeMMS("101");
            smartPhone.TakePhoto();
            smartPhone.RecordVideo();

            Console.ReadLine();

        }
    }
}
