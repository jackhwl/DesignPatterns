using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using PluralSightBook.Core.Interfaces;

namespace PluralSightBook.Infrastructure.Services
{
    public class DebugEmailSender : ISendEmail
    {
        public void SendEmail(string message)
        {
            // send email
            Debug.Print("Sending Email: " + message);
        }
    }
}
