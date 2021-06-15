using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamostiynaRobotaSem2
{
    public class Message
    {
        public User Initiator { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Data { get; set; }
    }
}
