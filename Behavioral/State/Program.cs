using State.Models;

namespace State;

public static class Program
{
    private static void Main()
    {
        var project = new Project();
        project.AddTask("task1");
        project.AddTask("task1");
        project.AddTask("task2");
        project.CompleteTask("task1");
        project.Suspend();
        project.AddTask("task3");
        project.Resume();
        project.CompleteTask("task2");
    }
}
