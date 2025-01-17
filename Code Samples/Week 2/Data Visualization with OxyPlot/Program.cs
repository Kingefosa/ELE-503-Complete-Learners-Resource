using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using System;
using System.Collections.Generic;
using System.Linq;

public class HistogramPlot
{
    public PlotModel CreateHistogram(List<double> data, int binCount)
    {
        double min = data.Min();
        double max = data.Max();
        double binWidth = (max - min) / binCount;
        int[] bins = new int[binCount];

        foreach (var value in data)
        {
            int bin = (int)((value - min) / binWidth);
            if (bin == binCount) bin--;
            bins[bin]++;
        }

        var model = new PlotModel { Title = "Histogram Example" };
        var histogram = new ColumnSeries
        {
            Title = "Frequency",
            FillColor = OxyColors.SkyBlue
        };

        for (int i = 0; i < binCount; i++)
        {
            histogram.Items.Add(new ColumnItem { Value = bins[i] });
        }

        model.Series.Add(histogram);
        model.Axes.Add(new CategoryAxis
        {
            Position = AxisPosition.Bottom,
            Labels = Enumerable.Range(0, binCount)
                               .Select(x => $"{min + x * binWidth:F2}")
                               .ToList()
        });

        model.Axes.Add(new LinearAxis
        {
            Position = AxisPosition.Left,
            Title = "Frequency"
        });

        return model;
    }
}

// Usage Example
class Program
{
    static void Main(string[] args)
    {
        List<double> data = new List<double> { /* Your data here */ };
        HistogramPlot hp = new HistogramPlot();
        PlotModel model = hp.CreateHistogram(data, 10);

        // Render the plot (implementation depends on the UI framework)
        // Example for WPF:
        // var plotView = new PlotView { Model = model };
    }
}
