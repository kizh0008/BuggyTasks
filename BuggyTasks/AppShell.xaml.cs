namespace BuggyTasks;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(Views.NewTaskPage), typeof(Views.NewTaskPage));
        Routing.RegisterRoute(nameof(Views.TaskListPage), typeof(Views.TaskListPage));
        Routing.RegisterRoute(nameof(Views.LocationPage), typeof(Views.LocationPage));
        Routing.RegisterRoute(nameof(Views.DeviceInfoPage), typeof(Views.DeviceInfoPage));
    }
}