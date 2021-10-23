using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SocketClient_Server
{
    class HddSerialNumber
    {
       public void GetHddSerialNo()
        {
            ManagementObjectCollection instances = new ManagementClass("Win32_LogicalDisk").GetInstances();
            string text = "";
            foreach (ManagementBaseObject managementBaseObject in instances)
            {
                ManagementObject managementObject = (ManagementObject)managementBaseObject;
                text += Convert.ToString(managementObject["VolumeSerialNumber"]);

                MessageBox.Show("HDD Serial " + text);
            }
            

        }

    }
   
}
