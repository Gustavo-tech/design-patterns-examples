using Facade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Services;
internal class MailService
{
    internal void SendEmail(User user)
    {
        // Simulate sending an email
        Console.WriteLine("Email sent to " + user.Name);
    }
}
