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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow() => InitializeComponent();

        private void btnMothers_Click(object sender, RoutedEventArgs e)
        {
            mothers frmMothers = new mothers();
            frmMothers.Show();
        }

        private void btnMothers_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Contracts frmCont = new Contracts();
            frmCont.Show();
        }

        private void btnMothers_Copy_Click(object sender, RoutedEventArgs e)
        {
            Children frmCHH = new Children();
            frmCHH.Show();
        }
    }
}
