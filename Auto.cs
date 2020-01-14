using System;
using System.Collections.Generic;
using System.Text;

namespace Autoverwaltung
{
    class Auto
    {
        protected string Marke;
        protected string Modell;
        protected int Klasse;
        protected int Leistung;
        protected int Preis;
        protected int Baujahr;

        //Konstruktor
        public Auto(string nMarke, string nModell,int nKlasse, int nLeistung, int nPreis, int nBauJahr)
        {
            setMarke(nMarke);
            setModell(nModell);
            setKlasse(nKlasse);
            setLeistung(nLeistung);
            setPreis(nPreis);
            setBaujahr(nBauJahr);
        }
        public Auto()
        {

        }
     

       

        //Getter+Setter
        public void setMarke(string nMarke)
        {
            Marke = nMarke;
        }
        public void setModell(string nModell)
        {
            Modell = nModell;
        }
        public void setKlasse(int nKlasse)
        {
            Klasse = nKlasse;
        }
        public void setLeistung(int nLeistung)
        {
            Leistung = nLeistung;
        }
        public void setPreis(int nPreis)
        {
            Preis = nPreis;
        }
        public void setBaujahr(int nBaujahr)
        {
            Baujahr = nBaujahr;
        }
        public string getMarke()
        {
            return Marke;
        }
        public string getModell()
        {
            return Modell;
        }
        public int getLeistung()
        {
            return Leistung;
        }
        public int getPreis()
        {
            return Preis;
        }
        public int getBaujahr()
        {
            return Baujahr;
        }

        //Methode zur Ausgabe
        public void ZeigeAuto()
        {
            Console.WriteLine("Marke: "+Marke);
            Console.WriteLine("Modell: "+Modell);
            Console.WriteLine("Leistung: "+Leistung+" PS");
            Console.WriteLine("Preis: "+Preis+" Euro");
            Console.WriteLine("Baujahr: "+Baujahr);
        }
    }
}
