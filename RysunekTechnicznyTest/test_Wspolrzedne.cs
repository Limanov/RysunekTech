using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;

namespace RysunekTechnicznyTest
{
    [TestClass]
    public class Test_Wspolrzedne
    {
        [TestMethod]
        public void Dodaj_Wspolrzedne()
        {
            Point punkt = new Point();
            punkt = RysunkiTechniczne.Metody.Dodajwspolrzedne.DodajXY("2","3");
            Point punkt2 = new Point(2,3);
            Assert.AreEqual(punkt,punkt2);
        }
    }
}
