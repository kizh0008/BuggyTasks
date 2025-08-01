namespace BuggyTasks.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    async void OnGoToTaskList(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TaskListPage));
    }

    async void OnAddTask(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NewTaskPage));
    }

    async void OnGetLocation(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LocationPage));
    }

    async void OnDeviceInfo(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(DeviceInfoPage));
    }
}