using NewRelic.MAUI.Plugin;

namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();

        CrossNewRelic.Current.RecordBreadcrumb("MAUIExampleBreadcrumb", new Dictionary<string, object>()
        {
            {"BreadNumValue", 12.3 },
            {"BreadStrValue", "MAUIBread" },
            {"BreadBoolValue", true }
        }
        );

    }
}