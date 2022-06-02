namespace EvaShop.Services
{
    public interface IEmailSender
    {
        bool Notify(string message,string to,string subject="");
        string GetEmail();

    }
}
