﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //TypeConvert typeTest = new TypeConvert();
            //typeTest.TypeConvertTest();
            //typeTest.OverflowTest();
            //typeTest.BoxAndUnBox();

            //MyClassChildTest classTest = new MyClassChildTest();
            //classTest.TestOutput();

            //StringTest strTest = new StringTest();
            //strTest.StringMemoryResident();

            //DelegateTest delegateTest = new DelegateTest();
            //delegateTest.TestCall();
            //delegateTest.TestInvoke();
            //delegateTest.TestDelegate();

            SMS sms = new SMS();
            SMSClient smsClient = new SMSClient(sms);
            sms.SendSMS("13111112222", "Test Message");

            Console.ReadLine();
        }
    }
}
