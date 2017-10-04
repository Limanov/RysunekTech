using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RysunkiTechniczne.Metody
{
    public class Dodajwspolrzedne
    {
        public static Point DodajXY(string x1, string y1)
        {
            double x;
            double y;
            Point point = new Point();
            if (Double.TryParse(x1, out x))

                if (Double.TryParse(y1, out y))
                {
                    point.X = x;
                    point.Y = y;
                    return point;
                }
            point.X = 0;
            point.Y = 0;
            return point;
        }
    }
}
