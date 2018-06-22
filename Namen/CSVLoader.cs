using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Namen
{
class CSVLoader
    {
        private static CSVLoader instance = null;
        //singelton Implementierung
        public static CSVLoader getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CSVLoader();
                }
                return instance;
            }
        }
        /// <summary>
        /// Gibt alle Einträge aus einer CSV zurück
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Zählt die Einträge in einer CSV
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
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
