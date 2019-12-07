using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSenderLib
{
    public static class WpfTestMailSender
    {
        static public string EmailFrom = "user@yandex.ru";
        static public string EmailTo = "user@gmail.com";
        static public string TestMessage = "Test message";
        static public string TestMessageBody = "Test message body";

        static public string ServerHost = "smtp.yandex.ru";
        static public int ServerPort = 25;
    }
}
