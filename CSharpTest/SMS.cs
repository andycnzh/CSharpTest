using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class SMS
    {
        public event EventHandler SMSEvent;
        public event EventHandler<SMSEventArgs> SMSDataEvent;

        protected virtual void OnSMSEvent()
        {
            this.SMSEvent?.Invoke(this, null);
        }

        protected virtual void OnSMSDataEvent(SMSEventArgs e)
        {
            this.SMSDataEvent?.Invoke(this, e);
        }

        public void SendSMS(string toPhoneNo, string message)
        {
            OnSMSEvent();

            if (!string.IsNullOrEmpty(toPhoneNo))
            {
                SMSEventArgs args = new SMSEventArgs();
                args.ToPhoneNo = toPhoneNo;
                args.Message = message;

                OnSMSDataEvent(args);
            }
        }
    }

    class SMSClient
    {
        public SMSClient(SMS sms)
        {
            sms.SMSEvent += new EventHandler(SMS_SMSEvent);
            sms.SMSDataEvent += new EventHandler<SMSEventArgs>(SMS_SMSDataEvent);
            sms.SMSDataEvent += new EventHandler<SMSEventArgs>(SMS_SMSDataEvent_Other);
        }

        private void SMS_SMSDataEvent(object sender, SMSEventArgs e)
        {
            Console.WriteLine(e.ToPhoneNo + ":" + e.Message);
        }

        private void SMS_SMSDataEvent_Other(object sender, SMSEventArgs e)
        {
            Console.WriteLine("Other " + e.ToPhoneNo + ":" + e.Message);
        }

        private void SMS_SMSEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Received notification");
        }
    }

    internal class SMSEventArgs
    {
        public string ToPhoneNo { get; set; }

        public string Message { get; set; }
    }
}
