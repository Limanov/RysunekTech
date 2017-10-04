using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RysunkiTechniczne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Ksztalt> lista = new List<Ksztalt>();
        public MainWindow()
        {
             
            InitializeComponent();
        }

        private void Wyczysc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rysujlinie_Click(object sender, RoutedEventArgs e)
        {
            Linia linia = new Linia(textBoxX.Text,textBoxY.Text,textBoxX2.Text,textBoxY2.Text);
            linia.linia.Stroke = Brushes.Black;
            lista.Add(linia);
            GlownePlotno.Children.Add(linia.linia);
        }

        private void MouseDown_Click(object sender, MouseButtonEventArgs e)
        {
            
            var position = e.GetPosition(GlownePlotno);
            Linia linia = new Linia(position.X.ToString(),position.Y.ToString(), position.X.ToString(), position.Y.ToString());
            linia.linia.Stroke = Brushes.Black;
            lista.Add(linia);
        }

        private void MouseUp_Unclick(object sender, MouseButtonEventArgs e)
        {
            Linia linia = (Linia)lista[lista.Count-1];
            var position = e.GetPosition(GlownePlotno);
            linia.linia.X2 = position.X;
            linia.linia.Y2 = position.Y;
            GlownePlotno.Children.Add(linia.linia);
        }
    }
}
