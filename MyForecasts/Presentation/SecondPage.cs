using LiveChartsCore;
using LiveChartsCore.SkiaSharpView.SKCharts;
using LiveChartsCore.SkiaSharpView.WinUI;

namespace MyForecasts.Presentation;

public sealed partial class SecondPage : Page
{
    public SecondPage()
    {
        this.DataContext<SecondViewModel>((page, vm) => page
            .Background(Theme.Brushes.Background.Default)
            .Content(
                new Grid()
                .RowDefinitions("Auto,Auto,*")
                .SafeArea(SafeArea.InsetMask.All)
                .Children(
                new NavigationBar()
                    .Content("Second Pages")
                    .MainCommand(new AppBarButton()
                        .Icon(new BitmapIcon().UriSource(new Uri("ms-appx:///MyForecasts/Assets/Icons/back.png")))
                    ),
                new TextBlock()
                    .Text("Comminy")
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .VerticalAlignment(VerticalAlignment.Center),
                
                
                new CartesianChart()
                    .Grid(row:2)
                    .Name("DataSeries")
                    
                    
                )
            )
        );
    }
}

