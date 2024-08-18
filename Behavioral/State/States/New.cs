using System;
using State.Models;

namespace State.States;

public class New : Abstract.ProjectState
{
    public New(Project project) : base(project) { }
    
    public override void AddTask(string task)
    {
        Project.ChangeState(new InProgress(Project));
        bool added = Project.TasksWithFinishStatus.TryAdd(task, false);
        
        if (!added)
            Console.WriteLine($"Task with name '{task}' exist.");
    }            

    public override void CompleteTask(string task)
    {
        Console.WriteLine("This is new project, there are no tasks.");
    }

    public override void Suspend()
    {
        Project.ChangeState(new Suspended(Project));
    }

    public override void Resume()
    {
        Console.WriteLine("Project is not suspended.");
    }
}
