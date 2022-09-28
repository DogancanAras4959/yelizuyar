using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yelizuyar.CORE.EmailConfig;

namespace yelizuyar.ENGINES.Interface
{
    public interface IEmailSender
    {
        Task SendEmailAsync(Message message);
    }
}
