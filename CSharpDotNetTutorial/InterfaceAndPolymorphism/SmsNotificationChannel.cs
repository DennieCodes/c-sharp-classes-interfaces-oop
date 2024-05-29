namespace CSharpDotNetTutorial.InterfaceAndPolymorphism;

public class SmsNotificationChannel : INotificationChannel
{
    public void Send(Message message)
    {
        Console.WriteLine("Sending text message.");
    }
}
