namespace JamesThew.Services
{
    public class EmailService : IEmailService 
    {
        public void SendEmail(string to, string subject,string body)
        {
            //Logic to send email 
            Console.WriteLine($"Email sent to {to}: {subject}");
        }
    }
}