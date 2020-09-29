using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMR
{
    class Enums
    {
        internal enum preparingStep
        {
            NotStarted,
            InProgress,
            Done,
            Canceled,
        }

        internal enum StateColor
        {
            Canceled,
            Succeed,
            InProgress,
        }
    }
}
