namespace NotificationWorker.Interfaces
{
    public interface INotificationService
    {
        void Notify(string contact, string message);
    }
}
