namespace BuggyTasks.Views;

public partial class LocationPage : ContentPage
{
    public LocationPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await GetLocation(); 
    }

    async Task GetLocation()
    {
        try
        {
            var location = await Geolocation.GetLastKnownLocationAsync();
            if (location != null)
            {
                Console.WriteLine($"Lat: {location.Latitude}, Long: {location.Longitude}");
            }
            else
            {
                Console.WriteLine("No location found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Location error: {ex.Message}");
        }
    }
}