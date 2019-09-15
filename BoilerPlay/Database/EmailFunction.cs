using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace BoilerPlay.Database
{
    public class EmailFunction
    {
        public static void sendEmail(Database.HelloWorldQueryMethods.Account acc, Database.HelloWorldQueryMethods.Posts post)
        {
            
            string to = acc.Email; //To address    
            string from = "boilerplaypurdue@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = "Hi " + acc.Name + ", This is an email confirming your involvement in "+post.Title+" at "+post.DateTime.ToString("dd/MM/yyyy hh:mm tt")+", at "+post.Location;
            message.Subject = "BoilerPlay Confirmation Email for "+post.Title;
            message.Body = mailbody;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("boilerplaypurdue@gmail.com", "helloworld!");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}