using System;
using System.Collections.Generic;

namespace Autoverwaltung
{
    public class MenüManager
    {
        public string ShowMenu()
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

            return Console.ReadLine();
        }
        public void  ShowCars(List<Auto> Autos)
        {
            Console.Clear();
            Console.WriteLine("___Liste der Autos___");
            Console.WriteLine();

            for (var i = 0; i < Autos.Count; i++)
               Console.WriteLine("{0,-5}{1,-20}{2,-20}{3,-10}{4,-20}{5,-20}", i + 1, Autos[i]
                                          .getMarke(), Autos[i]
                                          .getModell(), Autos[i]
                                                                .getLeistung() +
                                                        " PS ", Autos[i]
                                                                        .getPreis() +
                                                                " Euro ", "Baujahr: " +
                                                                          Autos[i]
                                                                                  .getBaujahr());
            
        }
    }
}
