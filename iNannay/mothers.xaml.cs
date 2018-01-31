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
using BE;

namespace iNannay
{
    /// <summary>
    /// Interaction logic for mothers.xaml
    /// </summary>
    public partial class mothers : Window
    {
        List<Mother> items;
        public mothers()
        {
            InitializeComponent();
             items = new List<Mother>();
            
            refreshData();
        }

        private void txtID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void refreshData(long ID = -1)
        {

            items.Add(new Mother(22334456));
            items.Add(new Mother(22334457));
            items.Add(new Mother(22334458));
            lstvMothers.ItemsSource = items;
        }
        public class User
        {
            public string dID { get; set; }

            public string dFirstName { get; set; }

            public string dLastName { get; set; }
        }

    }
}
