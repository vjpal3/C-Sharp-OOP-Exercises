using System.Collections.Generic;

namespace Exercises
{
    class WorkFlow : IWorkFlow
    {
        //This is readonly field so that it should not be accidently re-initialized.
        private readonly List<IActivity> _activities; 

        public WorkFlow()
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

        // return type is IEnumerable rather than IList, becoz _activities should not be modified without using the Add and Remove methods declared in this class.
        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
        


    }
}
