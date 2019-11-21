using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PelletLoyaltyProgram
{
    public class MessageModelEventArgs
    {
        public string Message { get; set; }

        public MessageModelEventArgs(string _message)
        {
            Message = _message;
        }
    }
}
