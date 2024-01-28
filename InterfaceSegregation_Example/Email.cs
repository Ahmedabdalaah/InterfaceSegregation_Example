using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_Example
{
    internal class Email : EmailNotification
    {
        public string SendEmail(string custom_id)
        {
            return $"Email : welcome {custom_id} in website ";
        }
    }
}
