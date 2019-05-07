using CommunicatingBetweenControls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicatingBetweenControls
{
    public sealed class Mediator
    {
        //static members
        private static readonly Mediator _Instance = new Mediator();
        private Mediator() { } // hide constructor

        public static Mediator GetInstance()
        {
            return _Instance;
        }

        //instance functionality
        public event EventHandler<JobChangedEventArgs> JobChanged;
        public void OnJobChanged(object sender, Job job)
        {
            //var jobChangeDelegate = JobChanged as EventHandler<JobChangedEventArgs>;
            //if (jobChangeDelegate != null)
            //{
            //    jobChangeDelegate(sender, new JobChangedEventArgs { Job = job });
            //}
            (JobChanged as EventHandler<JobChangedEventArgs>)?.Invoke(sender, new JobChangedEventArgs { Job = job });
        }
    }
}
