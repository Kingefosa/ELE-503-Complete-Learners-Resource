using System;
using System.Collections.Generic;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;

public class GaussSeidelVisualizer
{
    private double[,] A;
    private double[] b;
    private double[] initialGuess;
    private double tolerance;
    private int maxIterations;

    public GaussSeidelVisualizer(double[,] A, double[] b, double[] initialGuess, double tolerance = 1e-6, int maxIterations = 1000)
    {
        this.A = A;
        this.b = b;
        this.initialGuess = initialGuess;
        this.tolerance = tolerance;
        this.maxIterations = maxIterations;
    }

    public PlotModel PlotConvergence()
    {
        int n = b.Length;
        double[] x = new double[n];
        Array.Copy(initialGuess, x, n);
        double[] xOld = new double[n];
        Array.Copy(x, xOld, n);

        List<double[]> iterations = new List<double[]>();
        iterations.Add((double[])x.Clone());

        for (int iter = 0; iter < maxIterations; iter++)
        {
            for (int i = 0; i < n; i++)
            {
                double sum = 0.0;
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                        sum += A[i, j] * x[j];
                }
                x[i] = (b[i] - sum) / A[i, i];
            }

            iterations.Add((double[])x.Clone());

            // Check for convergence
            double error = 0.0;
            for (int i = 0; i < n; i++)
            {
                error += Math.Abs(x[i] - xOld[i]);
            }

            if (error < tolerance)
                break;

            Array.Copy(x, xOld, n);
        }

        // Create plot
        var model = new PlotModel { Title = "Gauss-Seidel Convergence" };
        var xAxis = new LinearAxis { Position = AxisPosition.Bottom, Title = "Iteration" };
        var yAxis = new LinearAxis { Position = AxisPosition.Left, Title = "Variable Values" };
        model.Axes.Add(xAxis);
        model.Axes.Add(yAxis);

        for (int i = 0; i < n; i++)
        {
            var series = new LineSeries { Title = $"x{i + 1}" };
            for (int j = 0; j < iterations.Count; j++)
            {
                series.Points.Add(new DataPoint(j, iterations[j][i]));
            }
            model.Series.Add(series);
        }

        return model;
    }
}

// Usage Example
class Program
{
    static void Main(string[] args)
    {
        // System:
        // 3x + y = 9
        // x + 2y = 8

        double[,] A = new double[,]
        {
            {3, 1},
            {1, 2}
        };

        double[] b = new double[] { 9, 8 };
        double[] initialGuess = new double[] { 0, 0 };

        GaussSeidelVisualizer gsVis = new GaussSeidelVisualizer(A, b, initialGuess);
        PlotModel plot = gsVis.PlotConvergence();

        // Render the plot in your UI framework (e.g., WPF)
        // Example for WPF:
        // var plotView = new PlotView { Model = plot };
    }
}
