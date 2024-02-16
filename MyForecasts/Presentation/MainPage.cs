namespace MyForecasts.Presentation;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.DataContext<MainViewModel>((page, vm) => page
            .NavigationCacheMode(NavigationCacheMode.Required)
            .Background(Theme.Brushes.Background.Default)
            .Content(new Grid()
                .SafeArea(SafeArea.InsetMask.All)
                .RowDefinitions("Auto,*")
                .Children(
                    new NavigationBar().Content(() => vm.Title),
                    new StackPanel()
                        .Grid(row: 1)
                        .HorizontalAlignment(HorizontalAlignment.Center)
                        .VerticalAlignment(VerticalAlignment.Center)
                        .Spacing(16)
                        .Children(
                            new TextBox()
                                .Text(x => x.Bind(() => vm.Demo.EventName).Mode(BindingMode.TwoWay))
                                .PlaceholderText("Your event names:"),
                            new TextBlock().Text(x=> x.Bind(() => vm.Demo.EventDescription)),

                            new NumberBox().Header("Value")
                                .Value(() => vm.Demo.Value),

                            new NumberBox().Header("Interval")
                                .Value(() => vm.Demo.Interval),

                            new NumberBox().Header("Interval type")
                                .Value(() => vm.Demo.InType),


                            new Button()
                                .Content("Make forecast")
                                .AutomationProperties(automationId: "SecondPageButton")
                                .Command(() => vm.GoToSecond)
                                ))));
    }
}
