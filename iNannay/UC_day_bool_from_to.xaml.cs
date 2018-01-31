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

namespace iNannay
{
    /// <summary>
    /// Interaction logic for UC_day_bool_from_to.xaml
    /// </summary>
    public partial class UC_day_bool_from_to : UserControl
    {
        public UC_day_bool_from_to()
        {
            InitializeComponent();
            mainGrid.DataContext = this;
        }

        private void txtHH_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtHH.Text.Length > 1)
            { txtMM.Focus(); }


        }

        private void txtMM_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtMM.Text.Length > 1)
            { txtHH_to.Focus(); }
        }

        private void txtHH_to_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtHH_to.Text.Length > 1)
            { txtMM_to.Focus(); }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Selected = !Selected;

        }
        private bool selected = false;
        public bool Selected
        {
            get { return selected; }

            set
            {
                if (value) //button.Background = Brushes.Blue; mbox     
                    mainGrid.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                else mainGrid.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                selected = value;
              
            }
        }

        public string day { get; set; } = "day";
    }
}
