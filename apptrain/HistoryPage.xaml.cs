namespace apptrain;

public partial class HistoryPage : ContentPage
{
	public HistoryPage()
	{
		InitializeComponent();
        LoadWorkouts();
    }

    private async void LoadWorkouts() {

        List<WorkoutEntery> workouts = await App.Database.GetWorkoutsAsync();
        WorkoutListView.ItemsSource = workouts;

    }

}