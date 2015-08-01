namespace DesignPatterns.TemplateMethod
{
    public interface ICanSendEmail
    {
        void SendEmail(string from, string to, string subject, string text);
    }
}