using MimeKit;
using MailKit.Net.Smtp;
using System.Security.Cryptography.X509Certificates;

namespace PhoneBookBusinessService
{
    public class Email
    {
        public void SentEmail(string sub, string bod)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("PhoneBookAdmin", "Adsys@Phonebook.com"));
            message.To.Add(new MailboxAddress("User", "user@Phonebook.com"));
            message.Subject = sub;

            message.Body = new TextPart("html")
            {

                Text = bod
              
            };

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect("sandbox.smtp.mailtrap.io", 2525, MailKit.Security.SecureSocketOptions.StartTls);

                    client.Authenticate("758a917243f83a", "f3c85e984cc409");

                    client.Send(message);
                    Console.WriteLine("Email sent by the Adsys.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error sending email: {ex.Message}");
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
           
        }
        public void AddEmail(string contacts)
        {
            string sub = "Your Information has been Added!";
            string bod = "<h1>hello, user!</h1>" +
                "<p>thank you for adding to the phonebook</p>" +
                "<p><strong>welcome!</strong></p>";
            SentEmail(sub, bod);
        }
        public void UpdateEmail(string contacts)
        {
            string sub = "Your Information has been Updated!";
            string bod = "<h1>Hello, User!</h1>" +
                            "<p>Thank you for updating your Phonebook Account</p>" +
                            "<p><strong>We Hope to See you Again!</strong></p>";
            SentEmail(sub, bod);
        }
        public void DeleteEmail(string contacts)
        {
            string sub = "Your Information has been Deleted!";
            string bod = "<h1>Hello, User!</h1>" +
                            "<p>Your Phonebook Account has been Deleted.</p>" +
                            "<p><strong>Thank you for using our system and we hope to see you again!</strong></p>";
            SentEmail(sub, bod);
        }
    }
}
