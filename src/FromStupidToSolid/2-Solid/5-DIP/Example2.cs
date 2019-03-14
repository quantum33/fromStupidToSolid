using System.Collections.Generic;

namespace FromStupidToSolid.Solid.DIP.Example2
{

    /*
     * Inspired from: https://exceptionnotfound.net/simply-solid-the-dependency-inversion-principle/
     * The article is nice and easy to understand, don't hesitate to read it and why not buying Matthew a coffee :)
     */

    public interface INotifier
    {
        void Notify();
    }

    public class EmailNotifier : INotifier
    {
        public string ToAddress { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }

        public void Notify()
        {
            // Send email
        }
    }

    public class SmsNotifier : INotifier
    {
        public string ToPhoneNumber { get; set; }

        public string Message { get; set; }

        public void Notify()
        {
            // Send sms
        }
    }

    public class NotificationService
    {
        public void Send(IEnumerable<INotifier> notifiers)
        {
            // do some specific "NotificationService" work (logging, etc.)
            //...
            foreach (INotifier notifier in notifiers)
            {
                notifier.Notify();
            }
        }
    }

    public class Program
    {
        public void Main()
        {
            // do some stuff
            // ...

            var message = "Ok, it's done!";

            // Then, choose which types of notification we want to send:
            var notifiers = new List<INotifier>
            {
                new SmsNotifier { ToPhoneNumber = "555-777-8888", Message = message  },
                new EmailNotifier { Subject = "Job ended", ToAddress = "devops@company.com", Content = message }
            };

            // when done, send notifications:
            new NotificationService().Send(notifiers);
        }
    }

    public class AnotherProgram
    {
        public void Main()
        {
            // do some stuff
            // ...

            IEnumerable<INotifier> configuredNotifiers = GetNotifiersFromConfiguration();
            new NotificationService().Send(configuredNotifiers);
        }

        private IEnumerable<INotifier> GetNotifiersFromConfiguration()
        {
            // eg: read from app.config or configuration database...
            // do some stuff...

            return new List<INotifier>();
        }
    }
}