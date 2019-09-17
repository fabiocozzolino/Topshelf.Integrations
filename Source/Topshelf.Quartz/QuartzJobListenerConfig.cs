using System.Collections.Generic;
using Quartz;

namespace Topshelf.Quartz
{
    public class QuartzJobListenerConfig
    {
        public IJobListener Listener { get; set; }
        public IMatcher<JobKey>[] Matchers { get; set; }

        public QuartzJobListenerConfig(IJobListener listener, params IMatcher<JobKey>[] matchers)
        {
            Listener = listener;
            Matchers = matchers;
        }

    }
}