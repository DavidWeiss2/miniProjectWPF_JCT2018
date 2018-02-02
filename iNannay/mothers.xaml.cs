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
        public BL.Bl BL
        {
            get; set;
        } = new BL.Bl();
        public mothers()
        {
            InitializeComponent();

            RefreshData();
        }

        private void txtID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void RefreshData(long ID = -1)
        {
            this.BL.Add(new Mother(223344256)
            {
                FirstName = "my",
                LastName = "lady",
                PhoneNumber = "phone"
            });
            this.BL.Add(new Mother(224334458)
            {
                FirstName = "my",
                LastName = "lady",
                PhoneNumber = "phone"
            });
            this.BL.Add(new Mother(223374459)
            {
                FirstName = "my",
                LastName = "lady",
                PhoneNumber = "phone"
            });
            this.lstvMothers.ItemsSource = this.BL.GetList(typeof(Mother), "LastName", true).Value;
        }
        public class User
        {
            public string ID
            {
                get; set;
            }

            public string FirstName
            {
                get; set;
            }

            public string LastName
            {
                get; set;
            }
        }

    }
}
