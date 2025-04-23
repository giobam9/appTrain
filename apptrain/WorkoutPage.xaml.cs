namespace apptrain;

public partial class WorkoutPage : ContentPage
{
	string selecteercice;
	public WorkoutPage(string  exercises)
	{
		InitializeComponent();
		selecteercice = exercises;
		ExerciseName.Text = exercises;


    }
	private async void OnSaveClicked(object sender,EventArgs e)
	{
		string podxodText = Podxod.Text;
		string povtorText = Povtor.Text; 
		if(string.IsNullOrWhiteSpace(podxodText) || string.IsNullOrWhiteSpace(povtorText))//IsNullOrWhiteSpace проверяет строку на наличие символов
        {
			await DisplayAlert("ошибка", "заполните оба поля", "ОК");
			return;
		}

        int podxod = int.Parse(podxodText);
        int povtor = int.Parse(povtorText);
        WorkoutEntery entry = new WorkoutEntery
        {
            Exercise = selecteercice,
            Podxod = podxod,
            Povtor = povtor,
            Date = DateTime.Now
        };



        await App.Database.SaveWorkoutAsync(entry);
        await DisplayAlert("Сохранено", $"{selecteercice}: {podxod}x{povtor}", "ОК");//вывод сообщения пользователю
        Navigation.PopAsync();//возврат на главную страницу
    }
}