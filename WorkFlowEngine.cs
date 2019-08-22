namespace Exercises
{
    class WorkFlowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach (var activity in workFlow.GetActivities())
            {
                //This method can be inserted in a try-catch block for handling Exceptions.
                activity.Execute();
            }
        }
    }
}
