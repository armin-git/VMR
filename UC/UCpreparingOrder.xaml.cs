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
using VMR.Template;

namespace VMR.UC
{
    /// <summary>
    /// Interaction logic for UCpreparingOrder.xaml
    /// </summary>
    public partial class UCpreparingOrder : UserControl, IUC
    {
        public event Action Back;

        public UCpreparingOrder()
        {
            InitializeComponent();
            TPorder.OrderCanceled += PorderOnOrderCanceled;
            TPproduct.OrderCompleted += PproductOnOrderCompleted;
        }

        private void PproductOnOrderCompleted()
        {
            enableBack();
        }
        private void PorderOnOrderCanceled()
        {
            enableBack();
        }
        void enableBack()
        {
            Dispatcher?.Invoke(() =>
            {
                BackImage.IsEnabled = true;
                BackImage.Opacity = 1.0;
            });
        }

        private void back_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Back?.Invoke();
        }

    }
}
