using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mitchelltaxgroup.Services
{
    public interface IMailer
    {

        bool SendMail(string FromName, string email, string message);
    }
}
