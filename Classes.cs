using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace VMR
{
    public static class StateColor
    {
        public static SolidColorBrush Canceled = Brushes.Red;
        public static SolidColorBrush Succeed = Brushes.Green;
        public static SolidColorBrush InProgress = Brushes.Gray;

    }    public static class StateName
    {
        public static string Canceled = "order cancelled!";
        public static string Succeed = "order completed!";
        public static string InProgress = "Cancel Order";

    }
}
