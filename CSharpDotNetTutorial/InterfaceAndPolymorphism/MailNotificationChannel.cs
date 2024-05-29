namespace CSharpDotNetTutorial.InterfaceAndPolymorphism;

public class MailNotificationChannel : INotificationChannel
{
    public void Send(Message message)
    {
        Console.WriteLine("Email was sent.");
    }
}
