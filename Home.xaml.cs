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

namespace Taller
{
    /// <summary>
    /// Lógica de interacción para Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string productName = txtProductName.Text;

            txtResults.Text = productName;
        }

        private void btnComprar_Click(object sender, RoutedEventArgs e)
        {
            int count = int.Parse(txtb_contador.Text);
            count++;
            txtb_contador.Text = count.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtb_contador.Text = "0";
        }
    }
}
