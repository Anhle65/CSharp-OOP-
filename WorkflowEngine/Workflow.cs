using System.Collections.Generic;

namespace WorkflowEngine
{
    public class Workflow : IWorkflow
    {
        private readonly List<IActivity> _activities;
        public Workflow()
        {
            _activities = new List<IActivity>();
        }
        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _activities.Remove(activity);
        }
        // Using IEnumerable rather than IList
        // since it makes sure the client won't directly work with the _activities
        // Helpful to test the method without confusion
        public IEnumerable<IActivity> GetActivities()
        { 
            return _activities;
        }
    }
}
