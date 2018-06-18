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
        public static Dictionary<int, Kind> kind = new Dictionary<int, Kind>();

        public static List<Kind> GetNamensliste(string bezirk)
        {
            List<Kind> kinder = new List<Kind>();
            CSVLoader daten = new CSVLoader();
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string[][] data = daten.readCSV(path + "\\csv_data\\" + bezirk +".csv");
            foreach (string[] listeneintrag in data)
            {
                if (listeneintrag[0] != "vorname")
                {
                    kinder.Add(new Kind(listeneintrag[0], listeneintrag[1], listeneintrag[2], listeneintrag[3]));
                }
            }
            return kinder;
        }
        public static string ausgabeNamen(string bezirk, string geschlecht)
        {
            string eintrag = "";
            foreach (Kind eintraege in Program.GetNamensliste(bezirk.ToLower()))
            {
                if ( eintraege.geschlecht == geschlecht)
                {
                    eintrag = eintrag + eintraege.name + " " + eintraege.anzahl +"\n";
                } else if (geschlecht=="a")
                {
                    eintrag = eintrag + eintraege.name + " " + eintraege.anzahl + "\n";
                }
            }
            return eintrag;
        }

    }
}
