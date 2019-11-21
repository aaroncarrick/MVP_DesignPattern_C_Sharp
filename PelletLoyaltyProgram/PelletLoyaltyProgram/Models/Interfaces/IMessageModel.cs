using System;

namespace PelletLoyaltyProgram
{
    public interface IMessageModel
    {
        event EventHandler<MessageModelEventArgs> TextSet;

        void RaiseTextSetEvent(string _message);
        void Set(string value);
    }
}