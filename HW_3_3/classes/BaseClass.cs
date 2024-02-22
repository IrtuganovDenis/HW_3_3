using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_3
{
    public abstract class BaseClass : IBaseInterface
    {
        protected abstract void FillByUser();
        protected abstract void RandFill();
        public abstract void Mid_value();
        public abstract void Print();
    }
}
