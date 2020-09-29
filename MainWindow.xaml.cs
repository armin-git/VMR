using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using VMR.Data;
using VMR.Model;
using VMR.UC;

namespace VMR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UCchooseBeverage.TPproduct.ProductSelected += PproductOnProductSelected;
            UCpreparingOrder.Back += UCpreparingOrderOnBack;
            LoadData();
        }

        private void LoadData()
        {
            Context.LoadData();
            UCchooseBeverage.TPproduct.ProductItemsControl.ItemsSource = Context.Products;
        }
        private void PproductOnProductSelected(Guid id)
        {
            UCchooseBeverage.Visibility = Visibility.Collapsed;
            UCpreparingOrder.Visibility = Visibility.Visible;
            UCpreparingOrder.TPorder.OrderItemsControl.ItemsSource = Context.Products.Where(p => p.Id == id);
            UCpreparingOrder.BackImage.IsEnabled = false;
            UCpreparingOrder.BackImage.Opacity = .2;
        }
        private void UCpreparingOrderOnBack()
        {
            LoadData();
            UCchooseBeverage.Visibility = Visibility.Visible;
            UCpreparingOrder.Visibility = Visibility.Collapsed;
        }

    }
}
