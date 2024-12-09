namespace ExperimentWithControls
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
           InitializeComponent();

            BirdPicker.ItemsSource = new String[] {
                "Duck",
                "Pigeon",
                "Penguin",
                "Ostrich",
                "Owl"

            };
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void Entry_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
        {
            EnteredText.Text = e.NewTextValue;
        }

        private void Slider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
        {
            SliderValue.Text = e.NewValue.ToString();   
        }

        private void Stepper_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
        {
            StepperValue.Text = e.NewValue.ToString();

        }

        private void AddBird_Clicked(System.Object sender, System.EventArgs e)
        {
            Birds.Text = Birds.Text + Environment.NewLine + BirdPicker.SelectedItem;
        }
    }

}
