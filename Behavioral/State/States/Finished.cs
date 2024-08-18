using System;
using State.Models;
using State.States.Abstract;

namespace State.States;

public class Finished : ProjectState
{
    public Finished(Project project) : base(project) { }

    public override void AddTask(string task)
    {
        Project.ChangeState(new InProgress(Project));
        Project.TasksWithFinishStatus.Add(task, false);
    }

    public override void CompleteTask(string task)
    {
        Console.WriteLine("Can't complete, there are no tasks. Project is already finished.");
    }

    public override void Suspend()
    {
        Console.WriteLine("Can't complete, there are no tasks. Project is already finished.");
    }

    public override void Resume()
    {
        Console.WriteLine("Project is not suspended.");
    }
}