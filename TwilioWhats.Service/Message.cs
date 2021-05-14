using System;
using System.Collections.Generic;
using TwilioWhats.Utils;

namespace TwilioWhats.Service
{
    public class Message : MessageContract
    {
        public string SenderId { get; protected set; }
        public string PhoneNumber { get; protected set; }
        public string TextMessage { get; protected set; }
        public List<Uri> Url { get; protected set; }


        public Message(string senderId, string phoneNumber, string textMessage, List<Uri> url = null)
        {
            SenderId = senderId;
            PhoneNumber = phoneNumber;
            TextMessage = textMessage;
            Url = url;

        }

        public override bool IsValid()
        {
            if (SenderId.IsNullOrEmpty())
            {
                Errors.Add("SenderId is empty");
                return false;
            }

            if (PhoneNumber.IsNullOrEmpty())
            {
                Errors.Add("Phone number is empty");
                return false;
            }

            if (!PhoneNumber.IsNumber())
            {
                Errors.Add("Phone number is not a number");
                return false;
            }

            if (TextMessage.IsNullOrEmpty())
            {
                Errors.Add("The message is empty");
                return false;
            }

            if (TextMessage.Length > 160)
            {
                Errors.Add("The message exceeded 160 characters");
                return false;
            }

            return true;
        }


    }
}
