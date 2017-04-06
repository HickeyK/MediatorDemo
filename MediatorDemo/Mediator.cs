using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo
{
    public sealed class Mediator
    {
        // static members
        private static readonly Mediator _Instance = new Mediator();
        private Mediator() {}

        public static Mediator GetInstance()
        {
            return _Instance;
        }

        // instance functionality
        public event EventHandler<JobChangedEventArgs> JobChanged;

        public void OnJobChanged(object sender, Job job)
        {
            var jobChangedDelegate = JobChanged as EventHandler<JobChangedEventArgs>;
            if (jobChangedDelegate != null)
            {
                jobChangedDelegate(sender, new JobChangedEventArgs { Job = job });
            }
        }
    }


}
