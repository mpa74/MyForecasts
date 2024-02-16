using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace MyForecasts.Presentation;

public partial record SecondViewModel(Entity Entity)
{
    private static readonly ISeries[] value = [
                new LineSeries<double>
            {
                Values = new double[] { 2, 1, 3, 5, 3, 4, 6 },
                Fill = null
            }
            ];

    public ISeries[] MySeries { get; set; } = value;
    
    
}
