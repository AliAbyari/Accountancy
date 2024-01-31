using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accountancy
{
    public class PumkinSender
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        string StrSenderNumber = "";
        string StrUser = "";
        string StrPass = "";

        public void SendMessage(string To, string Body)
        {
            Accountancy.PumkinSendService.Send PumkinSender = new PumkinSendService.Send();

            db.GetSmsSetting(ref StrUser, ref StrPass, ref StrSenderNumber);

            long[] RecId = null;
            byte[] Status = null;

            string[] strNumbers = new string[] { To.ToString() };

            int result = PumkinSender.SendSms(StrUser, StrPass, StrSenderNumber, strNumbers, Body, false, ref Status, ref RecId);
        }
    }
}
