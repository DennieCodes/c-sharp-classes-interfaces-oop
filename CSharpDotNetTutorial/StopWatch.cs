using System;
namespace CSharpDotNetTutorial;

public class StopWatch
{
    public DateTime startTime;
    private bool isRunning;

    public void Start()
    {
        if (isRunning == false)
        {
            this.startTime = DateTime.Now;
            this.isRunning = true;
        }
        else
        {
            throw new InvalidOperationException("The stopwatch is already running.");
        }
    }

    public TimeSpan Stop()
    {
        this.isRunning = false;
        return this.startTime - DateTime.Now;
    }
}