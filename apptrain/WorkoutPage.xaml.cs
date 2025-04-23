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
		if(string.IsNullOrWhiteSpace(podxodText) || string.IsNullOrWhiteSpace(povtorText))//IsNullOrWhiteSpace ��������� ������ �� ������� ��������
        {
			await DisplayAlert("������", "��������� ��� ����", "��");
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
        await DisplayAlert("���������", $"{selecteercice}: {podxod}x{povtor}", "��");//����� ��������� ������������
        Navigation.PopAsync();//������� �� ������� ��������
    }
}