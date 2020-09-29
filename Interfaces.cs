using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMR
{
    interface IPproduct
    {

        event Action<Guid> ProductSelected;
        void DoOrder(Guid Id);
    }

    interface IUC
    {
        event Action Back;
    }
}
