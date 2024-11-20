namespace AnimalMatchingGame
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void PlayAgainButton_Clicked(System.Object sender, System.EventArgs e)
        {

            AnimalButton.IsVisible = true;
            PlayAgainButton.IsVisible = false;

            List<String> animalEmoji = [

                "🐙", "🐙",
                "🐟", "🐟",
                "🦋", "🦋",
                "🐘", "🐘",
                "🐈", "🐈",
                "🐕", "🐕",
                "🐪", "🐪",
                "🦒", "🦒",

                ];

            foreach (var button in AnimalButton.Children.OfType<Button>())
            {
                int index = Random.Shared.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                button.Text = nextEmoji;
                animalEmoji.RemoveAt(index);

            }

            Dispatcher.StartTimer(TimeSpan.FromSeconds(.1), TimerTick);
        }

        int tenthsOfSeconsElapsed = 0;

        private bool TimerTick()
        {
           if(!this.IsLoaded)  return false; 
           tenthsOfSeconsElapsed++;
            TimeElapsed.Text = "Time Elapsed: " +
                (tenthsOfSeconsElapsed / 10F).ToString("0.0s");

            if( PlayAgainButton.IsVisible)
            {
                tenthsOfSeconsElapsed = 0;
                return false;

            }
            return true;


        }

        Button lastClicked;
        bool findMatch = false;
        int matchFound;


        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {

           if(sender is Button buttonClicked) {
                if (!string.IsNullOrWhiteSpace(buttonClicked.Text) && (findMatch == false))
                {
                    buttonClicked.BackgroundColor= Colors.Red;
                    lastClicked = buttonClicked;
                    findMatch = true;

                } else

                {
                    if ((buttonClicked != lastClicked) && (buttonClicked.Text == lastClicked.Text)
                        && (!string.IsNullOrWhiteSpace(buttonClicked.Text)))
                            {
                        matchFound++;
                        lastClicked.Text = "";
                        buttonClicked.Text = " ";
                    }

                    lastClicked.BackgroundColor = Colors.LightBlue;
                    buttonClicked.BackgroundColor = Colors.LightBlue;
                    findMatch = false;
                }
                
                
                }

           if( matchFound == 8)
            {
                matchFound = 0;
                AnimalButton.IsVisible = false;
                PlayAgainButton.IsVisible = true;


            }
        }
    }

}
