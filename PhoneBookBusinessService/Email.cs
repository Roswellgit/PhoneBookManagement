using MimeKit;
using MailKit.Net.Smtp;

namespace PhoneBookBusinessService
{
    public class Email
    {
        public Email()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("PhoneBookAdmin", "Adsys@Phonebook.com"));
            message.To.Add(new MailboxAddress("User", "user@Phonebook.com"));
            message.Subject = "Your Information has been added!";

            message.Body = new TextPart("html")
            {
                Text = "<h1>Hello, User!</h1>" +
                "<p>Thank you for adding to the Phonebook</p>" +
                "<p><strong>Welcome!</strong></p>"
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
    }
    public class Email2
    {
        public Email2()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("PhoneBookAdmin", "Adsys@Phonebook.com"));
            message.To.Add(new MailboxAddress("User", "user@Phonebook.com"));
            message.Subject = "Your Information has been added!";

            message.Body = new TextPart("html")
            {
                Text = "<h1>Hello, User!</h1>" +
                "<p>Thank you for updating your Phonebook Account</p>" +
                "<p><strong>We Hope to See you Again!</strong></p>"
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
    }
    public class Email3
    {
        public Email3()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("PhoneBookAdmin", "Adsys@Phonebook.com"));
            message.To.Add(new MailboxAddress("User", "user@Phonebook.com"));
            message.Subject = "Your Information has been added!";

            message.Body = new TextPart("html")
            {
                Text = "<h1>Hello, User!</h1>" +
                "<p>Your Phonebook Account has been Deleted.</p>" +
                "<p><strong>Thank you for using our system and we hope to see you again!</strong></p>"
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
    }

}
