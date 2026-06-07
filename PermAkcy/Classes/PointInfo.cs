using System.Windows.Shapes;

namespace PermAkcy.Classes
{
    class PointInfo
    {
        // Значение
        public double value { get; set; }
        // Объект линии
        public Line line { get; set; }
        public PointInfo(double value)
        {
            this.value = value;
        }
    }

}