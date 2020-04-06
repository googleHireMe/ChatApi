using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalrChat.Models
{
    public class Message
    {
        public string Username { get; set; }
        public string MessageContent { get; set; }
    }
}
