using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Net;
using System.Diagnostics;
using System.Net.Sockets;
using System.Xml.Linq;

namespace SocketClient_Server
{
    class GetIpStyle
    {

        public void GetDefaultIPGateway()
        {
            
            string HostUserName = System.Net.Dns.GetHostName();
            MessageBox.Show("HostUserName: " + HostUserName);


            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    MessageBox.Show(ip.ToString());
                }
            }

        }
    }
           
}