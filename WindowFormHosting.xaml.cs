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

namespace WpfControlExample
{
    /// <summary>
    /// Interaction logic for WindowFormHosting.xaml
    /// </summary>
    public partial class WindowFormHosting : Window
    {
        public WindowFormHosting()
        {
            InitializeComponent();
            (wfhSample.Child as System.Windows.Forms.WebBrowser).Navigate("http://www.shivatutorials.com");
        }
        private void wbWinForms_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Title = (sender as System.Windows.Forms.WebBrowser).DocumentTitle;
        }

    }
}
