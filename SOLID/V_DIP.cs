using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    abstract class Message
    {
        public abstract void Send();
    }

    class SMS : Message
    {
        public string Number { get; set; }
        public string Content { get; set; }

        public override void Send()
        {
            SendSMS();
        }

        public void SendSMS()
        {
            Console.WriteLine("Sending SMS...");
        }
    }

    class MMS : Message
    {
        public string Number { get; set; }
        public byte[] Content { get; set; }

        public override void Send()
        {
            SendMMS();
        }

        public void SendMMS()
        {
            Console.WriteLine("Sending MMS...");
        }
    }

    class Mail : Message
    {
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public override void Send()
        {
            SendMail();
        }

        public void SendMail()
        {
            Console.WriteLine("Sending Mail...");
        }
    }

    class Messenger
    {
        public List<Message> Messages { get; set; }


        public void SendMessage()
        {
            foreach (var message in Messages)
            {
                message.Send();
            }
        }
    }
}
