using SafetyAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using ASPSnippets.SmsAPI;


namespace SMSApi
{
    public class SendSMS
    {
        public bool SMStsatus(string to, string from, string message)
        {
            string AccountSid = "AC38ace510c0bab7f8f9aa436e420a9c29";
            string AuthToken = "80237d8a546b3b17b30b1c424d515491";
            var twilio = new Twilio.TwilioRestClient(AccountSid, AuthToken);


        //    var mess = twilio.SendMessage(
        //    "+13477565536", "+917797073789",
        //    "Hi Ishita..."
        //);
            var mess = twilio.SendMessage(
                from, to,
                message
            );
            if (mess != null)
                return true;
            else
                return false;
        }
            
    }
}