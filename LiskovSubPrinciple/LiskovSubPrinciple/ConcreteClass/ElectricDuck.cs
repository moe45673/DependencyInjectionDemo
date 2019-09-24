using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using LiskovSubPrinciple.BaseClass;

namespace LiskovSubPrinciple.ConcreteClass
{
    public class ElectricDuck : DuckBase
    {
        private bool _isTurnedOn;

        public bool IsTurnedOn => _isTurnedOn;

        public void TurnOnDuck()
        {
            _isTurnedOn = true;
        }

        public void TurnOffDuck()
        {
            _isTurnedOn = false;
        }

        public override void Swim()
        {
            if (!IsTurnedOn)
                return;

            base.Swim();
        }

        

        
    }
}
