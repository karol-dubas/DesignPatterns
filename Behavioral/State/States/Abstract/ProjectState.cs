using State.Models;

namespace State.States.Abstract;

public abstract class ProjectState
{
    protected readonly Project Project;

    protected ProjectState(Project project)
    {
        Project = project;
    }
    
    public abstract void AddTask(string task);
    public abstract void CompleteTask(string task);
    public abstract void Suspend();
    public abstract void Resume();
}
