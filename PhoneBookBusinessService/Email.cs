using MimeKit;
using MailKit.Net.Smtp;
using PhoneBookModels;
using System.Reflection.Metadata.Ecma335;

namespace PhoneBookBusinessService
{
    public class Email
    {

        public Task Email1(string receive, string sub, string bod)
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
                    client.AuthenticateAsync("758a917243f83a", "f3c85e984cc409");
                    client.SendAsync(message);
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
                return Task.CompletedTask;
            }
           
        
        }
        public Task Email2(string receive)
        {
            var sub = "Your Information has been added!";
            var bod = "<h1>Hello, User!</h1>" +
                         "<p>Thank you for adding to the Phonebook</p>" +
                          "<p><strong>Welcome!</strong></p>";
            return Email1(receive, sub, bod);
        }
        public Task Email3(string receive)
        {
            var sub = "Your Information has been updated!";
            var bod = "<h1>Hello, User!</h1>" +
                       "<p>Thank you for updating your Phonebook Account</p>" +
                       "<p><strong>We Hope to See you Again!</strong></p>";
            return Email1(receive, sub, bod);
        }
        public Task Email4(string receive)
        {
            var sub= "Your Information has been deleted!";
            var bod = "<h1>Hello, User!</h1>" +
                       "<p>Your Phonebook Account has been Deleted.</p>" +
                       "<p><strong>Thank you for using our system and we hope to see you again!</strong></p>";
            return Email1(receive, sub, bod);
        }

        
    }
}


        
        
        
    

        
            


    //        message.Subject = "Your Information has been added!";

                //        message.Body = new TextPart("html")
                //        {
                //            Text = "<h1>Hello, User!</h1>" +
                //            "<p>Thank you for adding to the Phonebook</p>" +
                //            "<p><strong>Welcome!</strong></p>"
                //        };

                //        using (var client = new SmtpClient())
                //        {
                //            try
                //            {
                //                client.Connect("sandbox.smtp.mailtrap.io", 2525, MailKit.Security.SecureSocketOptions.StartTls);

                //                client.Authenticate("758a917243f83a", "f3c85e984cc409");

                //                client.Send(message);
                //                Console.WriteLine("Email sent by the Adsys.");
                //            }
                //            catch (Exception ex)
                //            {
                //                Console.WriteLine($"Error sending email: {ex.Message}");
                //            }
                //            finally
                //            {
                //                client.Disconnect(true);
                //            }
                //        }
                //        return Email1(contacts);
                //    }
                //}
                //public bool Email2
                //{
                //    public Email2()
                //    {
                //        var message2 = new MimeMessage();
                //        message2.From.Add(new MailboxAddress("PhoneBookAdmin", "Adsys@Phonebook.com"));
                //        message2.To.Add(new MailboxAddress("User", "user@Phonebook.com"));
                //        message2.Subject = "Your Information has been added!";

                //        message2.Body = new TextPart("html")
                //        {
                //            Text = "<h1>Hello, User!</h1>" +
                //            "<p>Thank you for updating your Phonebook Account</p>" +
                //            "<p><strong>We Hope to See you Again!</strong></p>"
                //        };

                //        using (var client1 = new SmtpClient())
                //        {
                //            try
                //            {
                //                client1.Connect("sandbox.smtp.mailtrap.io", 2525, MailKit.Security.SecureSocketOptions.StartTls);

                //                client1.Authenticate("758a917243f83a", "f3c85e984cc409");

                //                client1.Send(message2);
                //                Console.WriteLine("Email sent by the Adsys.");
                //            }
                //            catch (Exception ex)
                //            {
                //                Console.WriteLine($"Error sending email: {ex.Message}");
                //            }
                //            finally
                //            {
                //                client1.Disconnect(true);
                //            }
                //        }
                //    }
                //}
                //public class Email3
                //{
                //    public Email3()
                //    {
                //        var message3 = new MimeMessage();
                //        message3.From.Add(new MailboxAddress("PhoneBookAdmin", "Adsys@Phonebook.com"));
                //        message3.To.Add(new MailboxAddress("User", "user@Phonebook.com"));
                //        message3.Subject = "Your Information has been added!";

                //        message3.Body = new TextPart("html")
                //        {
                //            Text = "<h1>Hello, User!</h1>" +
                //            "<p>Your Phonebook Account has been Deleted.</p>" +
                //            "<p><strong>Thank you for using our system and we hope to see you again!</strong></p>"
                //        };

                //        using (var client2 = new SmtpClient())
                //        {
                //            try
                //            {
                //                client2.Connect("sandbox.smtp.mailtrap.io", 2525, MailKit.Security.SecureSocketOptions.StartTls);

                //                client2.Authenticate("758a917243f83a", "f3c85e984cc409");

                //                client2.Send(message3);
                //                Console.WriteLine("Email sent by the Adsys.");
                //            }
                //            catch (Exception ex)
                //            {
                //                Console.WriteLine($"Error sending email: {ex.Message}");
                //            }
                //            finally
                //            {
                //                client2.Disconnect(true);
                //            }
                //        }
        
    


