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

namespace TCP_Terminal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isServer = false;
        bool isClient = false;

        TCP_Client client = new TCP_Client();
        TCP_Server server = new TCP_Server();

        public MainWindow()
        {
            InitializeComponent();
        }

         private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            if (isServer)
            {
               txtInfo.Text = server.Connect(txtBoxIP.Text);
            }
            if (isClient)
            {
                txtInfo.Text = client.Connect(txtBoxIP.Text);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void cbkServer_Checked(object sender, RoutedEventArgs e)
        {
            isClient = false;
            isServer = true;
        }

        private void cbkClient_Checked(object sender, RoutedEventArgs e)
        {
            isClient = true;
            isServer = false;
        }
    }
}
