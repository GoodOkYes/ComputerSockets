using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/*
    *******************************
    * 
    * 
    * Author: aChanKiller 
    * GitHub Link: https://github.com/aChanKiller
    * 
    * Website: https://aChanKiller.ru
    * Protect: 0%
    *******************************



*/

namespace SocketClient_Server
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //HddSerialNumber
            /*
            HddSerialNumber hddSerialNumber = new HddSerialNumber();
            hddSerialNumber.GetHddSerialNo();
            */
            //CpuInfo
            /*
            CPUInfo cPUInfo = new CPUInfo();
            cPUInfo.GetCPUManufacturer();
            */
            GetIpStyle ip = new GetIpStyle();
            ip.GetDefaultIPGateway();

         
        }
        

   



    }
}
