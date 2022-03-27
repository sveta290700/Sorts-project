using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System.Windows.Forms;

namespace SortsProjectApp
{
    public partial class GraphForm : Form
    {
        public GraphForm(double time1, double time2, double time3, double time4)
        {
            InitializeComponent();

            Graph.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0, time1),
                        new ObservablePoint(1, time2),
                        new ObservablePoint(2, time3),
                        new ObservablePoint(3, time4),
                    },
                    PointGeometrySize = 10
                }
            };
            Graph.AxisX.Add(new Axis
            {
                Labels = new[] { "Пузырёк", "Вставками", "Быстрая", "Расчёска" }
            });
            Graph.AxisY.Add(new Axis
            {
                Title = "Время, мс"
            });
        }
    }
}
