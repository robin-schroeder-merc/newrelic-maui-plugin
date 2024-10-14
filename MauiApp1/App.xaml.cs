using NewRelic.MAUI.Plugin;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            CrossNewRelic.Current.HandleUncaughtException();
            CrossNewRelic.Current.TrackShellNavigatedEvents();

            // Set optional agent configuration
            // Options are: crashReportingEnabled, loggingEnabled, logLevel, collectorAddress, crashCollectorAddress
            // AgentStartConfiguration agentConfig = new AgentStartConfiguration(true, true, LogLevel.INFO, "mobile-collector.newrelic.com", "mobile-crash.newrelic.com");

            if (DeviceInfo.Current.Platform == DevicePlatform.Android)
            {
                CrossNewRelic.Current.Start("AA8b50aab94b70a4b318cc17b6d0f43ef42453ac15-NRMA");
                // Start with optional agent configuration 
                // CrossNewRelic.Current.Start("<YOUR_ANDROID_TOKEN>", agentConfig);
            }
            else if (DeviceInfo.Current.Platform == DevicePlatform.iOS)
            {
                CrossNewRelic.Current.Start("<YOUR_IOS_TOKEN>");
                // Start with optional agent configuration 
                // CrossNewRelic.Current.Start("<YOUR_IOS_TOKEN>", agentConfig);
            }
        }
    }
}
