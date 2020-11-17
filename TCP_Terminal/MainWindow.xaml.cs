using System;
using System.Collections.Generic;
using System.Linq;
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
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace TCP_Terminal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TCP_Client client = new TCP_Client();
        
        public MainWindow()
        {
            InitializeComponent();        
        }

        public void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            client.connect(txtBoxIP.Text, Int32.Parse(txtBoxPort.Text));
            return;
        }

        public void btnDisconnect_Click(object sender, RoutedEventArgs e)
        {
            client.disconnect();
            return;
        }

        public void btnSend_Click(object sender, RoutedEventArgs e)
        {
            client.send(txtMessage.Text);
            return;
        }
    }
}
