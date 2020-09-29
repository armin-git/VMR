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
using VMR.Data;

namespace VMR.Template
{
    /// <summary>
    /// Interaction logic for TPproduct.xaml
    /// </summary>
    public partial class TPorder : UserControl
    {
        public event Action OrderCanceled;

        public TPorder()
        {
            InitializeComponent();
        }

        private void ChangeOrderStateButton_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Button b = (Button)sender;
            Guid Id = (Guid)b.Tag;
            var item = Context.Products.Single(p => p.Id == Id);
            if (item.State == Enums.preparingStep.NotStarted || item.State == Enums.preparingStep.InProgress)
            {
                OrderCanceled?.Invoke();
                item.State = Enums.preparingStep.Canceled;
                item.StateName = StateName.Canceled;
            }
        }
    }
}
