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
using System.Windows.Shapes;

namespace Mattermost_WPF
{
    /// <summary>
    /// Interaction logic for EditServer.xaml
    /// </summary>
    public partial class EditServer : Window
    {
        private MattermostServer server;

        public EditServer()
        {
            InitializeComponent();
            server = null;
        }

        public EditServer(MattermostServer server)
        {
            InitializeComponent();
            this.server = server;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.server != null)
            {
                this.server.SetName(ServerNameBox.Text);
                this.server.SetUrl(ServerUrlBox.Text);
                this.server.SetPort((uint)Int32.Parse(ServerPortBox.Text));

                if (ServerSecureBox.IsChecked == true)
                {
                    this.server.SetPrefix("https://");
                }
                else
                {
                    this.server.SetPrefix("http://");
                }
            }
            else
            {

                this.server = new MattermostServer(
                    ServerNameBox.Text,
                    ServerUrlBox.Text,
                    ServerSecureBox.IsChecked == true ? "https://" : "http://",
                    (uint)Int32.Parse(ServerPortBox.Text)
                    );
            }

            this.SaveServer();
        }

        private void SaveServer()
        {
            // Save server to config
            return;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
