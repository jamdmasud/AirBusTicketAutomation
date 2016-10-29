using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace AirBusTicketAutomation  
{
    public class EmailGateway : SmtpClient
    {
        public string UserName { set; get; }

        public EmailGateway()
            : base(
                ConfigurationManager.AppSettings["GmailHost"],
                Int32.Parse(ConfigurationManager.AppSettings["GmailPort"]))
        {
            this.UserName = ConfigurationManager.AppSettings["GmailUserName"];
            this.EnableSsl = Boolean.Parse(ConfigurationManager.AppSettings["GmailSsl"]);
            this.UseDefaultCredentials = false;
            this.Credentials = new System.Net.NetworkCredential(this.UserName, 
                ConfigurationManager.AppSettings["GmailPassword"]);
        }
    }
}