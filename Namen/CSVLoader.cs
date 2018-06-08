using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Namen
{



    /// <summary>
    /// Beispiel zum verwenden des XML Loaders, um alle Daten aus der Mitte.csv Datei auszulesen, wobei i für die Zeile in der Datei steht(wir müssen nicht mit 0 Anfangen zuzählen, da das nur die Spalten beschreibung in der CSV-Datei darstellt) 
    /// und der index danach den werd des Feldes darstellt,  0--> name, 1-->Anzahl;2-->geschlecht, 3 --> position  
    //CSVLoader test = new CSVLoader();
    //string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
    //  string[][] data = test.readCSV(path + "\\csv_data\\mitte.csv");
    //        for(int i = 1; i<= data.Length-1; i++)
    //      {
    //        Console.WriteLine(data[i][0] + " " + data[i][1] + " " + data[i][2] + " " + data[i][3]);
          //  }
/// </summary>
class CSVLoader
    {
        public string[][] readCSV(string path)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                string[][] parts = new string[lines.Length][];
                for(int i = 0; i<= lines.Length-1; i++)
                {
                    parts[i] = lines[i].Split(';');
                }
                return parts;

            }
            else
            {
                return null;
            }



            
        }


    }
}
