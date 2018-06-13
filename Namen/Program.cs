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
            int mwZaehler = 0;
            string[] eintraege;
            foreach(string[] listeneintrag in data)
            {
                if (listeneintrag[2] == geschlecht) mwZaehler++;
            }
            if (geschlecht == "m" || geschlecht == "w")
            {
                eintraege = new string[mwZaehler];
            }
            else eintraege = new string[data.Length];
            int zaehler = 0;
            if (geschlecht == "m" || geschlecht == "w")
            {
                for (int i = 1; i <= data.Length - 1; i++)
                {
                    if (data[i][2] == geschlecht)
                    {
                        eintraege[zaehler] = (data[i][0] + " " + data[i][1] + " " + data[i][2] + " " + data[i][3]);
                        zaehler++;
                    }
                }
            }
            if (geschlecht == "a")
            {
                for (int i = 1; i <= data.Length-1; i++)
                {
                    eintraege[i] = (data[i][0] + " " + data[i][1] + " " + data[i][2] + " " + data[i][3]);
                }
            }
            return eintraege;
        }
        public static string ausgabeNamen(string bezirk, string geschlecht)
        {
            string eintrag = "";
            foreach (string eintraege in Program.GetNamensliste(bezirk.ToLower(), geschlecht))
            {
                eintrag = eintrag + eintraege + "\n";
            }
            return eintrag;
        }

    }
}
