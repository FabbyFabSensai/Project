using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Namen
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }

        public static string[] GetNamensliste(string bezirk, string geschlecht)
        {
            CSVLoader daten = new CSVLoader();
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string[][] data = daten.readCSV(path + "\\csv_data\\" + bezirk +".csv");
            string[] eintraege = new string[data.Length];
            if (geschlecht == "m" || geschlecht == "w")
                for(int i = 1; i <= data.Length-1; i++)
                 {
                    if (data[i][2] == geschlecht)
                    {
                        eintraege[i] = (data[i][0] + " " + data[i][1] + " " + data[i][2] + " " + data[i][3]);
                    }
                 }
            if (geschlecht == "a")
                for (int i = 1; i <= data.Length - 1; i++)
                {
                        eintraege[i] = (data[i][0] + " " + data[i][1] + " " + data[i][2] + " " + data[i][3]);
                }
            return eintraege;
        }

    }
}
