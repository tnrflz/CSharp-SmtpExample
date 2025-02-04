using System.Net.Mail;
using System.Net;

class Program
{
    static void Main()
    {

        // SMTP settings
        string smtpServer = ""; 
        int smtpPort = 587; 
        string smtpUser = ""; 
        string smtpPass = ""; 

        string fromEmail = ""; 
        string toEmail = ""; 
        string subject = "Test"; 
        string body = "This is a test mail";
        string fromName = "";

        try
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(fromEmail, fromName);
            mail.To.Add(toEmail);
            mail.Bcc.Add(fromEmail); 
            mail.Subject = subject;
            mail.Body = body;

            SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort)
            {
                Credentials = new NetworkCredential(smtpUser, smtpPass),
                EnableSsl = false
            };

            smtpClient.Send(mail);
            Console.WriteLine("E-mail sent successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("E-mail sending error: " + ex.Message);
        }

  
    }
}
