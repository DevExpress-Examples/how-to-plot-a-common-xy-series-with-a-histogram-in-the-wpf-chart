*Files to look at*:
- [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) ([MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
- [MainWindow.xaml](./CS/MainWindow.xaml)

# How to Add a Line Series to a Histogram Chart

The following example shows how to plot a common XY series with a histogram in the same chart:

![](images/histogram-chart.png)

1. Create and configure histogram and line series.
2. Add a `ViewModel`and assign it to the [](xref:System.Windows.FrameworkElement.DataContext) property. 
2. Use the [Series.DataSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Series.DataSource) property to bind series to an observable collection from the `ViewModel`.

## Documentation

- [Histogram](https://docs.devexpress.com/WPF/400974/controls-and-libraries/charts-suite/chart-control/histogram?p=netframework)