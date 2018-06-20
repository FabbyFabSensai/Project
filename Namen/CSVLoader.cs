using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Namen
{



    /// <summary>
    /// Beispiel zum Verwenden des XML Loaders, um alle Daten aus der Mitte.csv Datei auszulesen, wobei i für die Zeile in der Datei steht(wir müssen nicht bei 0 anfangen zu zählen, da das nur die Spaltenbeschreibung in der CSV-Datei darstellt) 
    /// und der Index danach den Wert des Feldes darstellt,  0--> Name, 1--> Anzahl, 2--> Geschlecht, 3 --> Position  
    /// CSVLoader test = new CSVLoader();
    /// string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
    /// string[][] data = test.readCSV(path + "\\csv_data\\mitte.csv");
    ///        for(int i = 1; i <= data.Length-1; i++)
    ///      {
    ///        if (data[i][2] = m)
    ///        {
    ///             Console.WriteLine(data[i][0] + " " + data[i][1] + " " + data[i][2] + " " + data[i][3]);
    ///        }
    ///      }
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
        public  int countNewBornInFile(string path)
        {

            int originalLineCount = 0;
            if (File.Exists(path))
            {
                string[][] data = readCSV(path);
                for (int i = 1; i <= data.Length - 1; i++)
                {
                    int temp = Convert.ToInt32(data[i][1]);
                    originalLineCount = originalLineCount + temp;
                }

            }
            else
            {
                return 0;
            }
           
            return originalLineCount;
        }


    }
}
