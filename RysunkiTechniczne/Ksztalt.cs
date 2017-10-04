using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace RysunkiTechniczne
{
    abstract class Ksztalt
    {
        protected int pozycjaMyszkiMouseDownx { get; set; }
        protected int pozycjaMyszkiMouseDowny { get; set; }
        private static int idFigury { get; set; }
        public int xFormsa { get; set; }
        public int yFormsa { get; set; }
        public Point wspolrzednePoczatek { get; set; }
        public Point wspolrzedneKoniec { get; set; }

        public Ksztalt()
        {
            idFigury++;
        }
        public abstract void narysujFigure();
        public abstract void przesunFigureDo(int x, int y);
        public abstract void pozycjaMyszkiMouseDown(int x, int y);
    }
}
