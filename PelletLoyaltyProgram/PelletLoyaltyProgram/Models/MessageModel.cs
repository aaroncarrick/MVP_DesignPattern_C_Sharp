using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PelletLoyaltyProgram
{
    public class MessageModel : IMessageModel
    {
        private string Message { get; set; }

        public event EventHandler<MessageModelEventArgs> TextSet;


        public MessageModel()
        {
            Message = "";
        }

        public void Set(string value)
        {
            RaiseTextSetEvent(value);
        }

        public void RaiseTextSetEvent(string _message)
        {
            TextSet(this, new MessageModelEventArgs(_message));
        }
    }
}
