namespace CSharpDotNetTutorial.WorkflowEngineExercise;

public class WorkflowEngine
{
    public void Run(List<IWorkflowActivity> activities)
    {
        // Takes a workflow and iterates over each activity and runs it
        foreach (var activity in activities)
        {
            activity.Execute();
        }
    }
}
