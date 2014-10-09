namespace TheSlum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TheSlum.Interfaces;

    public class Pill : Bonus, ITimeoutable
    {
        public Pill(string itemId) : base(itemId, 0, 0, 100)
        {
            this.Timeout = 1;
            this.Countdown = 1;
            this.HasTimedOut = false;
        }
    }
}
