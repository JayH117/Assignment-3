using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Flame : Trap
    {
        public bool IsActive
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Activate()
        {
            IsActive = true;

        }
    }
}
