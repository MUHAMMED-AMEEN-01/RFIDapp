using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Windows.Forms;

namespace RFIDapp
{
    internal class ipPortValid
    {
        public static bool IsValidIP(string IP, int Port)
        {
            bool isValidIp = (IP.Contains(".") && IP.Split('.').Length == 4);
            if (IPAddress.TryParse(IP, out var ipAddress)&& isValidIp)
            {
                if (Convert.ToInt64(Port) >= 0 && Convert.ToInt64(Port) <= 65535)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Please enter a valid port number (0-65535).", "Invalid Port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid IP address.", "Invalid IP Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
