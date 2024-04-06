using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String FromMail = "";
            String FromPassword = "";
            //Create a new mail
            MailMessage message= new MailMessage();
            message.From = new MailAddress(FromMail);
            message.Subject = "Test mail from workshop";
            List<string> emailAddresses = new List<string>
        {
            "","",""
        };

            foreach (string emailAddress in emailAddresses)
            {
                message.To.Add(new MailAddress(emailAddress));
            }
            //message.To.Add(new MailAddress("ayazdemirov123@gmail.com"));
            message.Body = "Test body from workshop from  heyder";
            //SMTP conf
            try{
                var smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(FromMail, FromPassword);
                smtpClient.EnableSsl = true;
                //send message
                //for(int i = 0; i <5; i++)
                //{

                smtpClient.Send(message);

                //    Random random = new Random();
                //    int randomNumber = random.Next(3, 6);
                //    Thread.Sleep(randomNumber); 



                //}

            }
            catch(Exception ex) { 
                Console.WriteLine(ex.ToString());
            }



        }
    }
}
