using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_2
{
    class PushButtonTelephone : diskPhone
    {

        public override List<char> availableSymbols => new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '*', '#' };

        public PushButtonTelephone(string phoneNumber) : base(phoneNumber) { }

        public override void TakeCall(string callingPhoneNumber)
        {
            Console.WriteLine($"Входящий вызов с номера {callingPhoneNumber}");
        }
    }
}

