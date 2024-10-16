namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

            NewRelic.MAUI.Plugin.CrossNewRelic.Current.LogDebug("OnCounterClicked");

            var attr = new Dictionary<string, object>();
            attr.Add("OnCounterClicked", count);
            NewRelic.MAUI.Plugin.CrossNewRelic.Current.LogAttributes(attr);
        }

        private void OnCrashClicked(object sender, EventArgs e)
        {
            NewRelic.MAUI.Plugin.CrossNewRelic.Current.CrashNow();
        }

        private async void OnPage1Clicked(object sender, EventArgs e)
        {
            //push page 1 on the stack
            await ((Shell)App.Current.MainPage).GoToAsync("newPage1");
        }
    }

}
