using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // Zakładam, że jest to zewnętrzna biblioteka.
    public class SmsSender
    {
        public void Send(string to, string text)
        {
            Console.WriteLine($"Sending SMS to: {to}, text: {text}");
        }
    }
}
