using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_2
{
    class mobileWithColorScreen : mobileWithBlackAndWhiteScreen
    {
        public int ScreenColorsQuantity { get; set; }
        public bool TwoSIM { get; set; }
        public string SecondaryPhoneNumber { get; set; }

        public mobileWithColorScreen(string phoneNumber, int screenWidth, int screenHeight,
            double screenSize, string phoneColor,
            int screenColorsQuantity,
            string secondaryPhoneNumber = null)
            : base(phoneNumber, screenWidth, screenHeight, screenSize, phoneColor)
        {
            ScreenColorsQuantity = screenColorsQuantity;
            SecondaryPhoneNumber = secondaryPhoneNumber;
            if (SecondaryPhoneNumber != null)
                TwoSIM = true;
        }
        public override void MakeCall()
        {
            if (!TwoSIM)
                base.MakeCall();
            else
            {
                Console.Write("Выберите с какой сим-карты (1,2) хотите позвонить: ");
                int choosenSim;
                while (!int.TryParse(Console.ReadLine(), out choosenSim) || choosenSim < 1 || choosenSim > 2)
                    Console.WriteLine("Некорректный ввод, попробуйте снова: ");

                Console.WriteLine($"Вы позвонили с номера {(choosenSim == 1 ? phoneNumber : SecondaryPhoneNumber)} на номер {InsertNumber()}");
            }
        }
        public override void SendSMS()
        {
            if (!TwoSIM)
                base.SendSMS();
            else
            {
                Console.Write("Выберите с какой сим-карты (1,2) хотите отправить СМС сообщение: ");
                int choosenSim;
                while (!int.TryParse(Console.ReadLine(), out choosenSim) || choosenSim < 1 || choosenSim > 2)
                    Console.WriteLine("Некорректный ввод, попробуйте снова: ");

                Console.WriteLine($"SMS сообщение отправлено с номера {(choosenSim == 1 ? phoneNumber : SecondaryPhoneNumber)} на номер {InsertNumber()}");
            }
        }
        public virtual void SendMMS()
        {
            if (!TwoSIM)
                Console.WriteLine($"ММС сообщение отправлено на номер {InsertNumber()}");
            else
            {
                Console.Write("Выберите с какой сим-карты (1,2) хотите отправить ММС сообщение: ");
                int choosenSim;
                while (!int.TryParse(Console.ReadLine(), out choosenSim) || choosenSim < 1 || choosenSim > 2)
                    Console.WriteLine("Некорректный ввод, попробуйте снова: ");

                Console.WriteLine($"MMS сообщение отправлено с номера {(choosenSim == 1 ? phoneNumber : SecondaryPhoneNumber)} на номер {InsertNumber()}");
            }
        }
        public virtual void TakeMMS(string senderPhoneNumber)
        {
            Console.WriteLine($"Входящее MMS сообщение от {senderPhoneNumber}");
        }
    }
}
