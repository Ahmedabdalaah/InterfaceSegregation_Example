using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_Example
{
    internal interface EmailNotification
    {
        string SendEmail(string custom_id);
    }
}
