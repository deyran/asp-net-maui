namespace PickerControl
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                LabelName.Text = picker.Items[selectedIndex];                
            }
        }

        private void BttDados_Clicked(object sender, EventArgs e)
        {
            var monkeyList = new List<string>();

            monkeyList.Add("Baboon");
            monkeyList.Add("Capuchin Monkey");
            monkeyList.Add("Blue Monkey");
            monkeyList.Add("Squirrel Monkey");
            monkeyList.Add("Golden Lion Tamarin");
            monkeyList.Add("Howler Monkey");
            monkeyList.Add("Japanese Macaque");

            PickerTest01.Title = "Select a monkey";
            PickerTest01.ItemsSource = monkeyList;
        }
    }
}
