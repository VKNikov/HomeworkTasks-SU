namespace TheSlum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TheSlum.Interfaces;

    class Injection : Bonus, ITimeoutable
    {
        public Injection(string itemId) : base(itemId, 200, 0, 0)
        {
            this.Timeout = 3;
            this.Countdown = 3;
            this.HasTimedOut = false;
        }
    }
}
