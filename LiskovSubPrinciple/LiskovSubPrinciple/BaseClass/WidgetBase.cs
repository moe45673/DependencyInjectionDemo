using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubPrinciple.BaseClass
{
    public abstract class WidgetBase
    {
        public virtual IList<int> SomeList(string title)
        {
            //Some useful boilerplate implementation
            return new List<int>();
        }
    }
}
