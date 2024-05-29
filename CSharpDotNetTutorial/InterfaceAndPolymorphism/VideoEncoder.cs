namespace CSharpDotNetTutorial.InterfaceAndPolymorphism;
public class VideoEncoder
{
    private readonly IList<INotificationChannel> notificationChannels;

    public VideoEncoder()
    {
        this.notificationChannels = new List<INotificationChannel>();
    }

    public void Encode(Video video)
    {
        foreach (var channel in this.notificationChannels)
            channel.Send(new Message());
    }

    public void RegisterNotificationChannel(INotificationChannel channel)
    {
        this.notificationChannels.Add(channel);
    }
}
