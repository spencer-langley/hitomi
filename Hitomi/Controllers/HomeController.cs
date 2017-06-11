using Hitomi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Hitomi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmailData(VideoSession session)
        {
            //var json = new JavaScriptSerializer().Serialize(session);

            MailMessage mailMessage = new MailMessage();
            mailMessage.IsBodyHtml = true;
            mailMessage.To.Add("Hwada005@gmail.com");
            mailMessage.From = new MailAddress("datasender.2016@gmail.com");
            mailMessage.Body = BuildEmailBody(session);
            mailMessage.Subject = session.VideoName + " " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new System.Net.NetworkCredential("datasender.2016@gmail.com", "njihkpulboxbszsj");
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;

            smtpClient.Send(mailMessage);

            return Json("Message sent.");
        }

        private string BuildEmailBody(VideoSession session)
        {
            string body = "<table><tr><td>Timestamp</td><td>Response</td></tr>";

            foreach (var response in session.Keystrokes)
            {
                body += "<tr><td>" + response.Time + "</td><td>" + response.Vote + "</td></tr>";
            }

            body += "</table><br />";
            body += session.VideoURL;
            return body;
        }
    }
}