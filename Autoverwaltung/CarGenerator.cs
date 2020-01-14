using System;
using System.Collections.Generic;
using System.Text;

namespace Autoverwaltung
{
    public class CarGenerator
    {

        public List<Auto> GenerateCar(List<string> marken, List<string> modelle)
        {
            Random Zufall = new Random();
            int marke = Zufall.Next(0, 19);
            int modell = Zufall.Next();
            int Klasse = 0;

            var autos = new List<Auto>();

            if (marke == 0)
            {
                //BMW
                modell = Zufall.Next(0, 2);

                if (modell == 0)
                {
                    Klasse = 2;
                }
                if (modell == 1)
                {
                    Klasse = 1;
                }
                if (modell == 2)
                {
                    Klasse = 3;
                }
            }
            else if (marke == 1)
            {

                //Mercedes
                modell = Zufall.Next(3, 5);
                if (modell == 3)
                {
                    Klasse = 2;
                }
                if (modell == 4)
                {
                    Klasse = 1;
                }
                if (modell == 5)
                {
                    Klasse = 1;
                }
            }
            //Audi
            else if (marke == 2)
            {
                modell = Zufall.Next(6, 8);
                if (modell == 6)
                {
                    Klasse = 2;
                }
                if (modell == 7)
                {
                    Klasse = 3;
                }
                if (modell == 8)
                {
                    Klasse = 2;
                }
            }
            else if (marke == 3)
            {
                //Nissan
                modell = Zufall.Next(9, 11);
                if (modell == 9)
                {
                    Klasse = 3;
                }
                if (modell == 10)
                {
                    Klasse = 2;
                }
                if (modell == 11)
                {
                    Klasse = 5;
                }
            }
            else if (marke == 4)
            {
                //Opel
                modell = Zufall.Next(12, 14);
                if (modell == 12)
                {
                    Klasse = 3;
                }
                if (modell == 13)
                {
                    Klasse = 5;
                }
                if (modell == 14)
                {
                    Klasse = 4;
                }
            }
            else if (marke == 5)
            {
                //Skoda
                modell = Zufall.Next(15, 17);
                if (modell == 15)
                {
                    Klasse = 2;
                }
                if (modell == 16)
                {
                    Klasse = 4;
                }
                if (modell == 17)
                {
                    Klasse = 3;
                }
            }
            else if (marke == 6)
            {
                //Seat
                modell = Zufall.Next(18, 20);
                if (modell == 18)
                {
                    Klasse = 3;
                }
                if (modell == 19)
                {
                    Klasse = 4;
                }
                if (modell == 20)
                {
                    Klasse = 3;
                }
            }
            else if (marke == 7)
            {
                //Honda
                modell = Zufall.Next(21, 23);
                if (modell == 21)
                {
                    Klasse = 3;
                }
                if (modell == 22)
                {
                    Klasse = 4;
                }
                if (modell == 23)
                {
                    Klasse = 2;
                }
            }
            else if (marke == 8)
            {
                //Alfa
                modell = Zufall.Next(24, 26);
                if (modell == 24)
                {
                    Klasse = 3;
                }
                if (modell == 25)
                {
                    Klasse = 2;
                }
                if (modell == 26)
                {
                    Klasse = 4;
                }
            }
            else if (marke == 9)
            {
                //Dodge
                modell = Zufall.Next(27, 29);
                if (modell == 27)
                {
                    Klasse = 2;
                }
                if (modell == 28)
                {
                    Klasse = 2;
                }
                if (modell == 29)
                {
                    Klasse = 3;
                }
            }
            else if (marke == 10)
            {
                //Fiat
                modell = Zufall.Next(30, 32);
                if (modell == 30)
                {
                    Klasse = 5;
                }
                if (modell == 31)
                {
                    Klasse = 3;
                }
                if (modell == 32)
                {
                    Klasse = 4;
                }
            }
            else if (marke == 11)
            {
                //Jaguar
                modell = Zufall.Next(33, 35);
                if (modell == 33)
                {
                    Klasse = 2;
                }
                if (modell == 34)
                {
                    Klasse = 2;
                }
                if (modell == 35)
                {
                    Klasse = 2;
                }
            }
            else if (marke == 12)
            {
                //Lexus
                modell = Zufall.Next(37, 39);
                if (modell == 37)
                {
                    Klasse = 3;
                }
                if (modell == 38)
                {
                    Klasse = 3;
                }
                if (modell == 39)
                {
                    Klasse = 2;
                }
            }
            else if (marke == 13)
            {
                //Mazda
                modell = Zufall.Next(40, 42);
                if (modell == 40)
                {
                    Klasse = 3;
                }
                if (modell == 41)
                {
                    Klasse = 3;
                }
                if (modell == 42)
                {
                    Klasse = 3;
                }
            }
            else if (marke == 14)
            {
                //Mini
                modell = Zufall.Next(43, 45);
                if (modell == 43)
                {
                    Klasse = 3;
                }
                if (modell == 44)
                {
                    Klasse = 3;
                }
                if (modell == 45)
                {
                    Klasse = 3;
                }
            }
            else if (marke == 15)
            {
                //Ferrari
                modell = Zufall.Next(46, 48);
                if (modell == 46)
                {
                    Klasse = 1;
                }
                if (modell == 47)
                {
                    Klasse = 1;
                }
                if (modell == 48)
                {
                    Klasse = 2;
                }
            }
            else if (marke == 16)
            {
                //Porsche
                modell = Zufall.Next(49, 51);
                if (modell == 49)
                {
                    Klasse = 1;
                }
                if (modell == 50)
                {
                    Klasse = 2;
                }
                if (modell == 51)
                {
                    Klasse = 1;
                }
            }
            else if (marke == 17)
            {
                //Peugeot
                modell = Zufall.Next(52, 54);
                if (modell == 52)
                {
                    Klasse = 4;
                }
                if (modell == 53)
                {
                    Klasse = 3;
                }
                if (modell == 54)
                {
                    Klasse = 3;
                }
            }
            else if (marke == 18)
            {
                //Tesla
                modell = Zufall.Next(55, 57);
                if (modell == 55)
                {
                    Klasse = 2;
                }
                if (modell == 56)
                {
                    Klasse = 2;
                }
                if (modell == 57)
                {
                    Klasse = 1;
                }
            }
            else if (marke == 19)
            {
                //Volvo
                modell = Zufall.Next(58, 60);
                if (modell == 58)
                {
                    Klasse = 3;
                }
                if (modell == 59)
                {
                    Klasse = 3;
                }
                if (modell == 60)
                {
                    Klasse = 3;
                }
            }

            if (Klasse == 1)
            {
                int leistung = Zufall.Next(300, 500);
                int preis = Zufall.Next(80000, 250000);
                int baujahr = Zufall.Next(2010, 2019);
                Auto auto = new Auto(marken[marke], modelle[modell], Klasse, leistung, preis, baujahr);
                autos.Add(auto);
            }
            else if (Klasse == 2)
            {
                int leistung = Zufall.Next(200, 299);
                int preis = Zufall.Next(50000, 79999);
                int baujahr = Zufall.Next(2010, 2019);
                Auto auto = new Auto(marken[marke], modelle[modell], Klasse, leistung, preis, baujahr);
                autos.Add(auto);
            }
            else if (Klasse == 3)
            {
                int leistung = Zufall.Next(120, 199);
                int preis = Zufall.Next(20000, 49999);
                int baujahr = Zufall.Next(2000, 2019);
                Auto auto = new Auto(marken[marke], modelle[modell], Klasse, leistung, preis, baujahr);
                
                autos.Add(auto);
            }
            else if (Klasse == 4)
            {
                int leistung = Zufall.Next(100, 119);
                int preis = Zufall.Next(10000, 19999);
                int baujahr = Zufall.Next(1980, 2010);
                Auto auto = new Auto(marken[marke], modelle[modell], Klasse, leistung, preis, baujahr);
                autos.Add(auto);
            }
            else if (Klasse == 5)
            {
                int leistung = Zufall.Next(50, 99);
                int preis = Zufall.Next(1000, 99999);
                int baujahr = Zufall.Next(1980, 2005);
                Auto auto = new Auto(marken[marke], modelle[modell], Klasse, leistung, preis, baujahr);
                autos.Add(auto);
            }

            return autos;
        }

        internal object GenerateCar(object marken, object modelle)
        {
            throw new NotImplementedException();
        }

        public List<Auto> Generate1000Cars(List<string> marken, List<string> modelle)
        {
            var autos = new List<Auto>();
            for (int i = 0; i < 1000; i++)
            {
                autos.AddRange(GenerateCar(marken, modelle));
            }

            return autos;
        }
    }
}
