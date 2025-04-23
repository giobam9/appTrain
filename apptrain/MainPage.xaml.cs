//using Android.Health.Connect.DataTypes;

namespace apptrain
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            List<string> exercises = new List<string>
            {
                "жим лежа",
                "становая тяга",
                "подтягивания"
            };
            ExerciseListView.ItemsSource = exercises;
           
            List<string> day = new List<string>
            {
                "понедельник ",
                "среда",
                "пятница"
            };
            DayList.ItemsSource = day;

        }
        private async void OnExerciseSelected(object sender, SelectionChangedEventArgs e)// метод который автоматически вызывается когда я выбираю что то из списка
        {
            if (e.CurrentSelection.Count == 0)//проверка на случай случайного нажатия и выход из метода
                return;
            string SelectedExercise = (string)e.CurrentSelection[0];//берем первый элемент спискка,e.CurrentSelectio - список выбранных элементов
            await Navigation.PushAsync(new WorkoutPage(SelectedExercise));//создаем новую страницу и передаем туда выбранное упражнение ,await - ожидает пока страница полностью откроется
            ExerciseListView.SelectedItem = null;

        }

        private  async void  DayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count == 0)//проверка на случай случайного нажатия и выход из метода
                return;

            string SelectedDay = (string)e.CurrentSelection[0];//берем первый элемент спискка,e.CurrentSelectio - список выбранных элементов
            await Navigation.PushAsync(new DayPage(SelectedDay));//создаем новую страницу и передаем туда выбранное упражнение ,await - ожидает пока страница полностью откроется
            DayList.SelectedItem = null;
        }

        private async void OnHistoryClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoryPage());
        }
    }

}
