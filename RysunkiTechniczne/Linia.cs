using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace RysunkiTechniczne
{
    class Linia:Ksztalt
    {
        public Line linia { get; set; }

        public Linia(string x1, string y1, string x2, string y2)
        {
            linia = new Line();
            linia.Stroke = Brushes.Black;
            wspolrzednePoczatek = Metody.Dodajwspolrzedne.DodajXY(x1,y1);
            wspolrzedneKoniec = Metody.Dodajwspolrzedne.DodajXY(x2,y2);
            linia.X1 = wspolrzednePoczatek.X;
            linia.Y1 = wspolrzednePoczatek.Y;
            linia.X2 = wspolrzedneKoniec.X;
            linia.Y2 = wspolrzedneKoniec.Y;
        }
        public override void narysujFigure()
        {
            

        }

        public override void pozycjaMyszkiMouseDown(int x, int y)
        {

        }

        public override void przesunFigureDo(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
