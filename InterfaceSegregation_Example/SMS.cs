using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_Example
{
    internal class SMS : SMSNotification
    {
        public string SendSMS(string custom_Id)
        {
            return $"SMS : welcome {custom_Id} in website ";
        }
    }
}
