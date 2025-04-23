namespace apptrain;

public partial class DayPage : ContentPage
{
    string daysTren;
	public DayPage(string days)
	{
		InitializeComponent();
        daysTren = days;
        daysName.Text = days;
    }

    private void OnsaveClicked(object sender, EventArgs e)
    {
        string nameTrenirovki = nameTren.Text;
        if(string.IsNullOrWhiteSpace(nameTrenirovki))
        {
            DisplayAlert("������", "��������� ����", "��");
            return;
        }
        string result = $"{daysTren}:{nameTrenirovki}";
        DisplayAlert("���������", result, "��");
        Navigation.PopAsync();
    }
}