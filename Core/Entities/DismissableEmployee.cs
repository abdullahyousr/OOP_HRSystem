using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem.Core.Entities
{
    internal abstract class DismissableEmployee : Employee
    {
        public bool IsDismissed { get; private set; }
        //public abstract IEnumerable<PayItem> GetPayItems();
        public virtual void Dismiss()
        {
            IsDismissed = true;
        }
    }
}
