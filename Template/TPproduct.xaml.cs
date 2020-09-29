using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace VMR.Template
{
    /// <summary>
    /// Interaction logic for TPproduct.xaml
    /// </summary>
    public partial class TPproduct : UserControl, IPproduct
    {
        public event Action<Guid> ProductSelected;
        public static event Action OrderCompleted;

        public TPproduct()
        {
            InitializeComponent();
        }
        public void DoOrder(Guid Id)
        {
            var item = Context.Products.Single(p => p.Id == Id);
            new Thread(() =>
                {
                    int itemCount = item.PreparingSteps.Count;
                    for (var i = 0; i < itemCount + 1; i++)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        if (item.State == Enums.preparingStep.Canceled)
                        {
                            item.StateColor = StateColor.Canceled;
                            item.StateName = StateName.Canceled;
                            item.State = Enums.preparingStep.Canceled;
                            break;
                        }
                        preparingStep step, previousStep;
                        if (i > 0)
                        {
                            previousStep = item.PreparingSteps[i - 1];
                            previousStep.Picture = Static.DoneIcon;
                        }
                        if (i < itemCount)
                        {
                            step = item.PreparingSteps[i];
                            step.Picture = Static.InProgressIcon;
                        }
                        else if (i == itemCount)
                        {
                            item.StateColor = StateColor.Succeed;
                            item.StateName = StateName.Succeed;
                            item.State = Enums.preparingStep.Done;
                            OrderCompleted?.Invoke();
                        }
                    }
                })
            { IsBackground = true }.Start();
        }
        private void Product_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Border b = (Border)sender;
            var Id = (Guid)b.Tag;
            ProductSelected?.Invoke(Id);
            DoOrder(Id);
        }
    }
}
