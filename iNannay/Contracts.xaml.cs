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

namespace iNannay
{
    /// <summary>
    /// Interaction logic for Contracts.xaml
    /// </summary>
    public partial class Contracts : Window
    {


        List<User> items;
        public Contracts()
        {
            InitializeComponent();
            items = new List<User>();

            refreshData();
        }

        private void txtID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void refreshData(long ID = -1)
        {

            items.Add(new User() { dID = "22334456", dFirstName = "Mia", dLastName = "kahlifa" });
            items.Add(new User() { dID = "45454345", dFirstName = "Stormy", dLastName = "Daniels" });
            items.Add(new User() { dID = "43434345", dFirstName = "banks", dLastName = "Briana" });
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
