using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SocketClient_Server
{
    class CPUInfo
    {
       public void GetCPUManufacturer()
        {
            string text = string.Empty;
            foreach (ManagementBaseObject managementBaseObject in new ManagementClass("Win32_Processor").GetInstances())
            {
                ManagementObject managementObject = (ManagementObject)managementBaseObject;
                if (text == string.Empty)
                {
                    text = managementObject.Properties["Manufacturer"].Value.ToString();
                    MessageBox.Show("CPU " + text);
                }
            }
           
        }



    }
}
