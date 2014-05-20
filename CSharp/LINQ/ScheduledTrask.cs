using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LINQ
{
    public class ScheduledTrask
    {
        public ITask Task { get; protected set; }
        public TimeSpan Interval { get; protected set; }
        public TimeSpan Expiration { get; protected set; }
        public ScheduledTrask(ITask task, TimeSpan interval, TimeSpan expiration)
        {
            Task = task;
            Interval = interval;
            Expiration = expiration;
        }
    }
}
