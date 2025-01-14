using System;
using System.Windows.Forms;  // MessageBox için gerekli namespace
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace ReviseMee
{
    public class SmsService
    {
        public void SendSms(string phoneNumber, string message)
        {
            string accountSid = "your_account_sid";
            string authToken = "your_auth_token";
            string fromPhone = "your_twilio_phone_number"; // Twilio telefon numaranız

            TwilioClient.Init(accountSid, authToken);

            var messageResource = MessageResource.Create(
                body: message,
                from: new Twilio.Types.PhoneNumber(fromPhone),
                to: new Twilio.Types.PhoneNumber(phoneNumber)
            );

            // MessageBox ile başarılı mesajı gösteriyoruz
            MessageBox.Show($"SMS gönderildi: {messageResource.Sid}");
        }
    }
}
