using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace BuggyTasks.ViewModels;

public partial class NewTaskViewModel : ObservableObject
{
    [ObservableProperty]
    string newTaskTitle;

    public ICommand AddNewTaskCommand { get; } 

    public NewTaskViewModel()
    {
        AddNewTaskCommand = new RelayCommand(OnAddTask);
    }

    void OnAddTask()
    {
        // Simulate adding a task
        Console.WriteLine($"Added task: {NewTaskTitle}");
    }
}