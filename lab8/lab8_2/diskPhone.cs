using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_2
{
    class diskPhone
    {
        public string phoneNumber { get; set; } = "911";
        public virtual List<char> AvailableSymbols => new List<char>() {'0','1','2','3','4','5','6','7','8','9' };
        public diskPhone(string phoneNumber)
        {
            phoneNumber = this.phoneNumber;
        }
       protected string InsertNumber()
        {
            Console.WriteLine("Введите номер абонента, для звонка:");
            string number = Console.ReadLine();
            while (true)
            {
                bool isValid = false;
                string number1 = Console.ReadLine();

                foreach (char symbol in number)
                    if (!AvailableSymbols.Contains(symbol))
                    {
                        isValid = true;
                        break;
                    }
                if (isValid)
                {
                    Console.Write("Некорректный ввод. Попробуйте снова: ");
                    continue;
                }
                return number;
               
            }
            
        }
        public virtual void MakeCall()
        {
            Console.WriteLine($"Звонок на номер {InsertNumber()}");
        }
        public virtual  void TakeCall(string callingPhoneNumber)
        {
            Console.WriteLine($"Входящий вызов");
        }
    }
}
