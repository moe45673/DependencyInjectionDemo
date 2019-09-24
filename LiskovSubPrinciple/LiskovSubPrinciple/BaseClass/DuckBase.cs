using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubPrinciple.BaseClass
{
    public abstract class DuckBase
    {
        protected bool _isSwimming = false;

        public bool IsSwimming => _isSwimming;

        /// <summary>
        /// Changes IsSwimming state to true
        /// </summary>
        public virtual void Swim()
        {
            _isSwimming = true;
            Console.WriteLine("Duck is now swimming");
        }

        /// <summary>
        /// Changes IsSwimming state to false
        /// </summary>
        /// <exception cref="InvalidOperationException">If Duck is already not swimming, will throw exception</exception>
        public virtual void StopSwimming()
        {
            if (!IsSwimming)
            {
                throw new InvalidOperationException("Error - Attempted to call StopSwimming() on a Duck that is not swimming!");
            }

            _isSwimming = false;
            Console.WriteLine("Duck has stopped swimming");
        }
    }
}
