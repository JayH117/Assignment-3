using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public abstract class WeaponRanged
    {
        private bool MakesNoise;
        private int ReloadTime;
        public bool Overheats;
        private int AmmoCount;
        private int DamagePower;

        public void Fire()
        {
            throw new System.NotImplementedException();
        }

        public void Reload()
        {
            throw new System.NotImplementedException();
        }
    }
}
