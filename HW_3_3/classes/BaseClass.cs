using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_3
{
    public abstract class BaseClass : IBaseInterface
    {
        private bool B;
        public BaseClass(bool b){
            B = b;
        }
        protected abstract void FillByUser();
        protected abstract void RandFill();
        public abstract void Mid_value();
        public abstract void Print();
        public void Fill(){
            if(B){
                FillByUser();
            }
            else{
                RandFill();
            }
        }
    }
}
