using System;
using System.Collections.Generic;

namespace Autoverwaltung
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var    menü   = new MenüManager();
            var    carGen = new CarGenerator();
            var List = new Listen();
            string eingabe;

            List.MarkenListe();
            List.ModellListen();
            
         
            var Autos = new List<Auto>();

            do
            {
                eingabe = menü.ShowMenu();

                if (eingabe == "1")
                {
                    var listOfAutos = carGen.GenerateCar(marken, modelle);
                    Autos.AddRange(listOfAutos);
                }
                else if (eingabe == "2")
                {
                    addcar();
                }
                else if (eingabe == "3")
                {
                    menü.ShowCars(Autos);
                    Console.ReadLine();
                }
                else if (eingabe == "4")
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
                else if (eingabe == "7")
                {
                    var listOfAutos = carGen.Generate1000Cars(marken, modelle);
                    Autos.AddRange(listOfAutos);
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
            } while (eingabe != "X" && eingabe != "x");

           

            void addcar()
            {
                Console.Clear();
                Console.WriteLine("Geben Sie die Daten des Autos ein");
                var auto = new Auto();
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
                    menü.ShowCars(Autos);
                    Console.Write("Welches Auto wollen Sie entfernen?");
                    var deleteEingabe = Convert.ToInt32(Console.ReadLine());
                    Autos.RemoveAt(deleteEingabe - 1);
                    menü.ShowCars(Autos);
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
                var highestPrice = 0;
                var index        = 0;

                try
                {
                    for (var i = 0; i < Autos.Count; i++)
                        if (Autos[i]
                                    .getPreis() >
                            highestPrice)
                        {
                            index = i;
                            highestPrice = Autos[i]
                                    .getPreis();
                        }

                    menü.ShowCars(Autos);
                    Console.WriteLine();
                    Console.WriteLine("Der höchste Preis beträgt " + highestPrice + " Euro ");
                    Console.WriteLine("{0,-4}{1,-20}{2,-20}{3,-20 }{4,-20 }", index + 1, Autos[index]
                                              .getMarke(), Autos[index]
                                              .getModell(), Autos[index]
                                                                    .getLeistung() +
                                                            " PS ", "Baujahr: " +
                                                                    Autos[index]
                                                                            .getBaujahr());
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
                var highestPower = 0;
                var index        = 0;

                try
                {
                    for (var i = 0; i < Autos.Count; i++)
                        if (Autos[i]
                                    .getLeistung() >
                            highestPower)
                        {
                            index = i;
                            highestPower = Autos[i]
                                    .getLeistung();
                        }

                    menü.ShowCars(Autos);
                    Console.WriteLine();
                    Console.WriteLine("Die größte Leistung beträgt " + highestPower + " PS");
                    Console.WriteLine("{0,-4}{1,-20}{2,-20}{3,-20 }{4,-20 }", index + 1, Autos[index]
                                              .getMarke(), Autos[index]
                                              .getModell(), Autos[index]
                                                                    .getPreis() +
                                                            " Euro ", "Baujahr: " +
                                                                      Autos[index]
                                                                              .getBaujahr());
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Es sind noch keine Einträge vorhanden");
                    Console.ReadLine();
                }
            }
        }
    }
}