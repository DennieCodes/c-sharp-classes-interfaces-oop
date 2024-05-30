namespace CSharpDotNetTutorial.WorkflowEngineExercise;
public class WorkflowDemo
{
    public static void Show()
    {
        var workflowEngine = new WorkflowEngine();
        var workFlow = new List<IWorkflowActivity>();

        workFlow.Add(new SetupSemanticKernel());
        workFlow.Add(new SetupPlanner());
        workFlow.Add(new SetupPlugins());
        workFlow.Add(new ExecutingCopilot());

        workflowEngine.Run(workFlow);
    }
}
