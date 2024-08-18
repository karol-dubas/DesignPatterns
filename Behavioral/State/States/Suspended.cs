using System;
using System.Linq;
using State.Models;

namespace State.States;

public class Suspended : Abstract.ProjectState
{
    public Suspended(Project project) : base(project) { }

    public override void AddTask(string task)
    {
        Console.WriteLine("Project is suspended.");
    }

    public override void CompleteTask(string task)
    {
        Console.WriteLine("Project is suspended.");
    }

    public override void Suspend()
    {
        Console.WriteLine("Project is suspended.");
    }

    public override void Resume()
    {
        if (!Project.TasksWithFinishStatus.Any())
        {
            Project.ChangeState(new New(Project));
            return;
        }

        if (Project.TasksWithFinishStatus.All(p => p.Value == true))
        {
            Project.ChangeState(new Finished(Project));
            return;
        }
        
        Project.ChangeState(new InProgress(Project));
    }
}