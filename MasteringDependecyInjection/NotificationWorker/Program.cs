using NotificationWorker.Interfaces;
using NotificationWorker.Services;

internal class Program
{


    

    private static void Main()
    {
        Console.WriteLine("Hello, World!");
        
        INotificationService service = new EmailService();

        service.Notify("", "");
    }
}