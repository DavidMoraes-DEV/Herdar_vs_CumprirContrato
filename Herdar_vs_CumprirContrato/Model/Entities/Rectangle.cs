using System.Globalization;

namespace Herdar_vs_CumprirContrato.Model.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }

        public override double Area()
        {
            return Width * Heigth;
        }

        public override string ToString()
        {
            return "Rectangle color = " + Color + ", width = " + Width.ToString("F2", CultureInfo.InvariantCulture) + ", height = " + Heigth.ToString("F2", CultureInfo.InvariantCulture) + ", area = " + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
