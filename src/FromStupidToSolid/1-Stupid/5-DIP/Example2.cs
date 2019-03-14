namespace FromStupidToSolid.Stupid.DIP.Example2
{

    /*
     * Inspired from: https://exceptionnotfound.net/simply-solid-the-dependency-inversion-principle/
     * The article is nice and easy to understand, don't hesitate to read it and why not buying Matthew a coffee :)
     */

    public class Email
    {
        public string ToAddress { get; set; }

        public string Subject { get; set; }

        public void SendEmail(string message)
        {
            // Send email
        }
    }

    public class Sms
    {
        public string ToPhoneNumber { get; set; }

        public void SendSms(string message)
        {
            // Send sms
        }
    }

    public class NotificationService
    {
        private readonly Email _email = new Email
        {
            Subject = "Job ended",
            ToAddress = "devops@company.com"
        };

        private readonly Sms _sms = new Sms
        {
            ToPhoneNumber = "555-777-8888"
        };

        public void Send(string subject, string message)
        {
            // do some specific "NotificationService" work (logging, etc.)
            // ...

            // send messages:
            _email.Subject = subject;

            _email.SendEmail(message);
            _sms.SendSms(message);
        }
    }

    public static class Program
    {
        static void Main()
        {
            // do some stuff
            // ...

            // when done, send notifications:
            new NotificationService().Send("Job ended", "Ok, it's done!");

            // which types of notifications are sent?
            // what if we do/do not want to send a specific notification?
            // ...
        }
    }
}
