using System.Collections.Generic;
using State.States;
using State.States.Abstract;

namespace State.Models;

public class Project
{
    private ProjectState _projectState;

    public readonly Dictionary<string, bool> TasksWithFinishStatus = new();

    public Project()
    {
        _projectState = new New(this);
    }

    public void ChangeState(ProjectState projectState) => _projectState = projectState;
    public void AddTask(string task) => _projectState.AddTask(task);
    public void CompleteTask(string task) => _projectState.CompleteTask(task);
    public void Suspend() => _projectState.Suspend();
    public void Resume() => _projectState.Resume();
}