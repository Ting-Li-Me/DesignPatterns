namespace SimpleFactoryPattern
{
    using Interfaces;
    using Models;
    class ChartFactory
    {
        public static IChart GetChart(string type)
        {
            IChart chart = null;

            if (type.ToLower() =="histogram")
            {
                chart = new HistogramChart();
            }
            else if (type.ToLower()=="pie")
            {
                chart = new PieChart();
            }
            else if (type.ToLower()=="line")
            {
                chart = new LineChart();
            }
            return chart;
        }


    }
}
