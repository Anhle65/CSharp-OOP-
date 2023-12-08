using System.Collections.Generic;

namespace WorkflowEngine
{
    public interface IWorkflow
    {
        public void Add(IActivity activity);
        IEnumerable<IActivity> GetActivities();
        public void Remove(IActivity activity);
    }
}
