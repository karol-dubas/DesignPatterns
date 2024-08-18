using System;
using System.Linq;
using State.Models;

namespace State.States;

public class InProgress : Abstract.ProjectState
{
    public InProgress(Project project) : base(project) { }

    public override void AddTask(string task)
    {
        bool added = Project.TasksWithFinishStatus.TryAdd(task, false);

        if (!added)
            Console.WriteLine($"Task with name '{task}' exist.");
    }

    public override void CompleteTask(string task)
    {
        if (!Project.TasksWithFinishStatus.ContainsKey(task))
            Console.WriteLine($"There is no task with name: '{task}'.");
            
        Project.TasksWithFinishStatus[task] = true;

        if (Project.TasksWithFinishStatus.All(p => p.Value == true))
            Project.ChangeState(new Finished(Project));
    }

    public override void Suspend()
    {
        Project.ChangeState(new Suspended(Project));
    }

    public override void Resume()
    {
        Console.WriteLine("Project not suspended.");
    }
}