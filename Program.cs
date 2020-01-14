using System;
using System.Collections.Generic;
using System.Linq;

namespace Autoverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            string eingabe;
            int deleteEingabe;
            

            //erstellung der Marken
            List<string> Marken = new List<string>();
            Marken.Add("BMW");
            Marken.Add("Mercedes");
            Marken.Add("Audi");
            Marken.Add("Nissan");
            Marken.Add("Opel");
            Marken.Add("Skoda");
            Marken.Add("Seat");
            Marken.Add("Honda");
            Marken.Add("Alfa Romeo");
            Marken.Add("Dodge");
            Marken.Add("Fiat");
            Marken.Add("Jaguar");
            Marken.Add("Lexus");
            Marken.Add("Mazda");
            Marken.Add("MINI");
            Marken.Add("Ferrari");
            Marken.Add("Porsche");
            Marken.Add("Peugeot");
            Marken.Add("Tesla");
            Marken.Add("Volvo");

            List<string> Modelle = new List<string>();
            Modelle.Add("M5");
            Modelle.Add("I8");
            Modelle.Add("3er");
            Modelle.Add("A180");
            Modelle.Add("SLS AMG");
            Modelle.Add("G63 AMG");
            Modelle.Add("RS7");
            Modelle.Add("A1");
            Modelle.Add("Q8");
            Modelle.Add("Qashqai");
            Modelle.Add("Skyline GT-R");
            Modelle.Add("Micra");
            Modelle.Add("Vectra");
            Modelle.Add("Corsa");
            Modelle.Add("Zafira");
            Modelle.Add("Superb");
            Modelle.Add("Fabia");
            Modelle.Add("Octavia");
            Modelle.Add("Leon");
            Modelle.Add("Ibiza");
            Modelle.Add("Ateca");
            Modelle.Add("Civic");
            Modelle.Add("Jazz");
            Modelle.Add("NSX");
            Modelle.Add("Guiletta");
            Modelle.Add("Giulia");
            Modelle.Add("Stevio");
            Modelle.Add("RAM");
            Modelle.Add("Viper");
            Modelle.Add("Challenger");
            Modelle.Add("Multipla");
            Modelle.Add("500");
            Modelle.Add("Panda");
            Modelle.Add("XF");
            Modelle.Add("F-Type");
            Modelle.Add("E-Type");
            Modelle.Add("LFA");
            Modelle.Add("NX");
            Modelle.Add("UX");
            Modelle.Add("MX7");
            Modelle.Add("CX5");
            Modelle.Add("MX5");
            Modelle.Add("Cooper-S");
            Modelle.Add("Countryman");
            Modelle.Add("Cooper");
            Modelle.Add("F40");
            Modelle.Add("458 Italia");
            Modelle.Add("Spider");
            Modelle.Add("Panamera");
            Modelle.Add("Spyder");
            Modelle.Add("Taycan");
            Modelle.Add("307cc");
            Modelle.Add("508");
            Modelle.Add("3008");
            Modelle.Add("Cybertruck");
            Modelle.Add("Model S");
            Modelle.Add("Model X");
            Modelle.Add("XC90");
            Modelle.Add("S90");
            Modelle.Add("V90");

            //Liste der Autos
            List<Auto> Autos = new List<Auto>();
                        
            

            do
            {
                ShowMenu();
                
                 
                if (eingabe=="1")
                {
                    generateCar();
                }
                else if(eingabe=="2")
                {
                    addcar();
                }
                else if (eingabe=="3")
                {
                    ShowCars();
                    Console.ReadLine();
                }
                else if (eingabe=="4")
                {
                    deleteCar();
                }
                else if (eingabe == "5")
                {
                    hPrice();
                }
                else if (eingabe == "6")
                {
                    hPower();
                }
                else if (eingabe=="7")
                {
                    generate1000cars();
                }
                else if (eingabe != "X" || eingabe != "x")
                {
                    Console.Clear();
                    Console.WriteLine("Programm wird beendet");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ungültige Eingabe");
                    Console.ReadLine();
                }

            }
            while (eingabe != "X" && eingabe!="x");
            
            
           
            void ShowMenu()
            {
                Console.Clear();
                Console.WriteLine("__________AUTOVERWALTUNG___________");
                Console.WriteLine();
                Console.WriteLine("[1] Zufälliges Auto generieren");
                Console.WriteLine("[2] Autos mit Daten generieren");
                Console.WriteLine("[3] Liste aller Autos anzeigen");
                Console.WriteLine("[4] Autos Löschen");
                Console.WriteLine("[5] Ermittel höchsten Preis");
                Console.WriteLine("[6] Ermittel höchste Leistung");
                Console.WriteLine("[7] 1000 Autos generieren");
                Console.WriteLine("[X] Programm beenden");
                Console.WriteLine();
                Console.Write("Wählen Sie Ihre Eingabe: ");
                eingabe = Console.ReadLine();
            }
            void ShowCars()
            {
                Console.Clear();
                Console.WriteLine("___Liste der Autos___");
                Console.WriteLine();

                
                for(int i=0; i<Autos.Count;i++)
                {
                    Console.WriteLine("{0,-5}{1,-20}{2,-20}{3,-10}{4,-20}{5,-20}",i+1,Autos[i].getMarke(),Autos[i].getModell(),Autos[i].getLeistung()+" PS ",Autos[i].getPreis()+" Euro ","Baujahr: "+Autos[i].getBaujahr());
                }
                
            }
            void generateCar()
            {
                Random Zufall = new Random();
                int marke = Zufall.Next(0, 19);
                int modell = Zufall.Next();
                int Klasse=0;
                

                if ( marke==0)
                {
                    //BMW
                    modell = Zufall.Next(0, 2);

                    if (modell==0)
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
                else if (marke==1)
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
                    modell = Zufall.Next(9,11);
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
                    modell = Zufall.Next(21,23);
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
                    if (modell ==43)
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
                    if (modell ==51)
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
                    if (modell ==53)
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
                    modell = Zufall.Next(58,60);
                    if (modell == 58)
                    {
                        Klasse = 3;
                    }
                    if (modell ==59)
                    {
                        Klasse = 3;
                    }
                    if (modell == 60)
                    {
                        Klasse = 3;
                    }
                }

                if (Klasse==1)
                {
                    int leistung = Zufall.Next(300, 500);
                    int preis = Zufall.Next(80000, 250000);
                    int baujahr = Zufall.Next(2010, 2019);
                    Console.Clear();
                    Console.WriteLine("Zufällig generiertes Auto:");
                    Auto auto = new Auto(Marken[marke], Modelle[modell], Klasse, leistung, preis, baujahr);
                    auto.ZeigeAuto();
                    Console.ReadLine();
                    Autos.Add(auto);
                }
                else if (Klasse==2)
                {
                    int leistung = Zufall.Next(200, 299);
                    int preis = Zufall.Next(50000, 79999);
                    int baujahr = Zufall.Next(2010, 2019);
                    Console.Clear();
                    Console.WriteLine("Zufällig generiertes Auto:");
                    Auto auto = new Auto(Marken[marke], Modelle[modell], Klasse, leistung, preis, baujahr);
                    auto.ZeigeAuto();
                    Console.ReadLine();
                    Autos.Add(auto);
                }
                else if (Klasse == 3)
                {
                    int leistung = Zufall.Next(120, 199);
                    int preis = Zufall.Next(20000, 49999);
                    int baujahr = Zufall.Next(2000, 2019);
                    Console.Clear();
                    Console.WriteLine("Zufällig generiertes Auto:");
                    Auto auto = new Auto(Marken[marke], Modelle[modell], Klasse, leistung, preis, baujahr);
                    auto.ZeigeAuto();
                    Console.ReadLine();
                    Autos.Add(auto);
                }
                else if (Klasse == 4)
                {
                    int leistung = Zufall.Next(100, 119);
                    int preis = Zufall.Next(10000, 19999);
                    int baujahr = Zufall.Next(1980, 2010);
                    Console.Clear();
                    Console.WriteLine("Zufällig generiertes Auto:");
                    Auto auto = new Auto(Marken[marke], Modelle[modell], Klasse, leistung, preis, baujahr);
                    auto.ZeigeAuto();
                    Console.ReadLine();
                    Autos.Add(auto);
                }
                else if (Klasse == 5)
                {
                    int leistung = Zufall.Next(50, 99);
                    int preis = Zufall.Next(1000, 99999);
                    int baujahr = Zufall.Next(1980, 2005);
                    Console.Clear();
                    Console.WriteLine("Zufällig generiertes Auto:");
                    Auto auto = new Auto(Marken[marke], Modelle[modell], Klasse, leistung, preis, baujahr);
                    auto.ZeigeAuto();
                    Console.ReadLine();
                    Autos.Add(auto);
                }

                

                

                
               
            }            
            void addcar()
            {
                Console.Clear();
                Console.WriteLine("Geben Sie die Daten des Autos ein");
                Auto auto = new Auto();
                Console.Write("Marke: ");
                auto.setMarke(Console.ReadLine());
                Console.Write("Marke: ");
                auto.setModell(Console.ReadLine());
                Console.Write("Leistung: ");
                auto.setLeistung(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Preis: ");
                auto.setPreis(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Baujahr: ");
                auto.setBaujahr(Convert.ToInt32(Console.ReadLine()));
                Autos.Add(auto);
            }           
            void deleteCar()
            {
                try
                { 
                Console.Clear();
                ShowCars();
                Console.Write("Welches Auto wollen Sie entfernen?");
                deleteEingabe = Convert.ToInt32(Console.ReadLine());
                Autos.RemoveAt(deleteEingabe-1);
                ShowCars();
                Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Es sind noch keine Einträge vorhanden");
                    Console.ReadLine();
                }
            }
            void hPrice()
            {
                Console.Clear();
                int highestPrice = 0;
                int index = 0;



                try
                {
                    for (int i = 0; i < Autos.Count; i++)
                    {
                        if (Autos[i].getPreis() > highestPrice)
                        {
                            index = i;
                            highestPrice = Autos[i].getPreis();




                        }

                    }
                    ShowCars();
                    Console.WriteLine();
                    Console.WriteLine("Der höchste Preis beträgt " + highestPrice + " Euro ");
                    Console.WriteLine("{0,-4}{1,-20}{2,-20}{3,-20 }{4,-20 }", index + 1, Autos[index].getMarke(), Autos[index].getModell(), Autos[index].getLeistung() + " PS ", "Baujahr: " + Autos[index].getBaujahr());
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Es sind noch keine Einträge vorhanden");
                    Console.ReadLine();
                }
            }
            void hPower()
            {
                Console.Clear();
                int highestPower = 0;
                int index=0;

                try
                {
                    for (int i = 0; i < Autos.Count; i++)
                {
                
                   if (Autos[i].getLeistung() > highestPower)
                        {
                            index = i;
                            highestPower = Autos[i].getLeistung();


                        }
                   
                    


                }
                
                ShowCars();
                Console.WriteLine();
                Console.WriteLine("Die größte Leistung beträgt " + highestPower + " PS");
                Console.WriteLine("{0,-4}{1,-20}{2,-20}{3,-20 }{4,-20 }", index + 1, Autos[index].getMarke(), Autos[index].getModell(), Autos[index].getPreis()+" Euro ","Baujahr: "+ Autos[index].getBaujahr());
                Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Es sind noch keine Einträge vorhanden");
                    Console.ReadLine();
                }
            }
            void generate1000cars()
            {
                Random Zufall = new Random();
               

               



                Console.Clear();
                Console.WriteLine("Zufällig generiertes Auto:");

                for (int i = 0; i < 1000; i++)
                {
                    
                    int marke = Zufall.Next(0, 19);
                    int modell = Zufall.Next();
                    int Klasse = 0;


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
                        Console.WriteLine("Zufällig generiertes Auto:");
                        Auto auto = new Auto(Marken[marke], Modelle[modell], Klasse, leistung, preis, baujahr);
                        auto.ZeigeAuto();
                        Autos.Add(auto);
                    }
                    else if (Klasse == 2)
                    {
                        int leistung = Zufall.Next(200, 299);
                        int preis = Zufall.Next(50000, 79999);
                        int baujahr = Zufall.Next(2010, 2019);
                        Console.WriteLine("Zufällig generiertes Auto:");
                        Auto auto = new Auto(Marken[marke], Modelle[modell], Klasse, leistung, preis, baujahr);
                        auto.ZeigeAuto();
                        Autos.Add(auto);
                    }
                    else if (Klasse == 3)
                    {
                        int leistung = Zufall.Next(120, 199);
                        int preis = Zufall.Next(20000, 49999);
                        int baujahr = Zufall.Next(2000, 2019);
                        Console.WriteLine("Zufällig generiertes Auto:");
                        Auto auto = new Auto(Marken[marke], Modelle[modell], Klasse, leistung, preis, baujahr);
                        auto.ZeigeAuto();
                        Autos.Add(auto);
                    }
                    else if (Klasse == 4)
                    {
                        int leistung = Zufall.Next(100, 119);
                        int preis = Zufall.Next(10000, 19999);
                        int baujahr = Zufall.Next(1980, 2010);
                        Console.WriteLine("Zufällig generiertes Auto:");
                        Auto auto = new Auto(Marken[marke], Modelle[modell], Klasse, leistung, preis, baujahr);
                        auto.ZeigeAuto();
                        Autos.Add(auto);
                    }
                    else if (Klasse == 5)
                    {
                        int leistung = Zufall.Next(50, 99);
                        int preis = Zufall.Next(1000, 9999);
                        int baujahr = Zufall.Next(1980, 2005);
                        Console.WriteLine("Zufällig generiertes Auto:");
                        Auto auto = new Auto(Marken[marke], Modelle[modell], Klasse, leistung, preis, baujahr);
                        auto.ZeigeAuto();
                        Autos.Add(auto);
                    }
                }
                
            }
        }

        
    }
}
