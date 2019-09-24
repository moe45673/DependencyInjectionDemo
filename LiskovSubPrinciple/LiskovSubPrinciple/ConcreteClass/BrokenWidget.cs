using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiskovSubPrinciple.BaseClass;

namespace LiskovSubPrinciple.ConcreteClass
{
    public class BrokenWidget : WidgetBase
    {
        //New Argument Type
        public override IList<int> SomeList(object title)
        {
            return new List<int>();
        }

        //New Return Type
        public override IList<object> SomeList(string title)
        {
            return new List<object>();
        }
    }
}
