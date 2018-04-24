using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public delegate void HealthPointsChangedEventHandler(Hero sender, HealthPointsChangedEventArgs aEventArgs);

    public class HealthPointsChangedEventArgs : EventArgs
    {
        public int HealthPtsLeft { get; }

        public HealthPointsChangedEventArgs(int aHealthPtsLeft)
        {
            this.HealthPtsLeft = aHealthPtsLeft;
        }

    }
}
