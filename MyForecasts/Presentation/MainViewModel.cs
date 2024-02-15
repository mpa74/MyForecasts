namespace MyForecasts.Presentation;

public partial class MainViewModel : ObservableObject
{
    private INavigator _navigator;

    [ObservableProperty]
    private string? name;

    [ObservableProperty] private EventDefinition demo;


    public MainViewModel(
        IStringLocalizer localizer,
        IOptions<AppConfig> appInfo,
        INavigator navigator)
    {
        _navigator = navigator;
        Title = "Main";
        Title += $" - {localizer["ApplicationName"]}";
        Title += $" - {appInfo?.Value?.Environment}";
        GoToSecond = new AsyncRelayCommand(GoToSecondView);

        demo = new()
        {
            EventId = "0",
            EventName = "My food expenses",
            EventType = Business.Enums.Events.EventType.Defaut,
            Value = 2000,
            Interval = 2,
            InType = Business.Enums.Events.IntervalType.Day,
        };
    }
    public string? Title { get; }

    public ICommand GoToSecond { get; }

    private async Task GoToSecondView()
    {
        await _navigator.NavigateViewModelAsync<SecondViewModel>(this, data: new Entity(Name!));
    }

}
