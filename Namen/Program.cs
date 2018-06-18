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
        //public static Dictionary<int, Kind> kind = new Dictionary<int, Kind>();

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
            kinder = Topliste(kinder);
            return kinder;
        }
        /// <summary>
        /// Kürzt die Liste der Kinder auf die ersten 20 Einträge von jeweils erstem, zweiten und dritten Vornamen und Geschlecht
        /// </summary>
        /// <param name="kinder"></param>
        /// <returns></returns>
        public static List<Kind> Topliste(List<Kind> kinder)
        {
            List<Kind> kinder2 = new List<Kind>();
            int zaehler = 0;
            foreach (Kind eintrag in kinder)
            {
                if (Convert.ToInt32(eintrag.position) == 1 && eintrag.geschlecht == "m" && zaehler < 20)
                {
                    kinder2.Add(eintrag);
                    zaehler++;
                }
                if (Convert.ToInt32(eintrag.position) == 2 && eintrag.geschlecht == "m" && zaehler < 40)
                {
                    kinder2.Add(eintrag);
                    zaehler++;
                }
                if (Convert.ToInt32(eintrag.position) == 3 && eintrag.geschlecht == "m" && zaehler < 60)
                {
                    kinder2.Add(eintrag);
                    zaehler++;
                }
                if (Convert.ToInt32(eintrag.position) == 1 && eintrag.geschlecht == "w" && zaehler < 80)
                {
                    kinder2.Add(eintrag);
                    zaehler++;
                }
                if (Convert.ToInt32(eintrag.position) == 2 && eintrag.geschlecht == "w" && zaehler < 100)
                {
                    kinder2.Add(eintrag);
                    zaehler++;
                }
                if (Convert.ToInt32(eintrag.position) == 3 && eintrag.geschlecht == "w" && zaehler < 120)
                {
                    kinder2.Add(eintrag);
                    zaehler++;
                }
            }
            return kinder2;
        }
        /// <summary>
        /// Gibt die Namensliste als String zurück entsprechend dem Geschlecht und Bezirk
        /// </summary>
        /// <param name="bezirk"></param>
        /// <param name="geschlecht"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Liefert die Ausgabe für das Diagramm als String
        /// </summary>
        /// <param name="bezirk"></param>
        /// <param name="geschlecht"></param>
        /// <returns></returns>
        public static string Diagramm(string bezirk, string geschlecht)
        {
            string diagramm = "";
            foreach (Kind kind in GetNamensliste(bezirk.ToLower()))
            {
                if (kind.geschlecht==geschlecht)
                {
                    for (int i = 0; i < Convert.ToInt32(kind.anzahl); i++)
                    {
                        diagramm += (char) 35;
                    }
                    for (int a = Convert.ToInt32(kind.anzahl); a<=70 - Convert.ToInt32(kind.anzahl); a++ )
                    {
                        diagramm += " ";
                    }
                    diagramm += "Name: " + kind.name + ", Anzahl: " + kind.anzahl +"\n";
                } else
                {
                    for (int i = 0; i < Convert.ToInt32(kind.anzahl); i++)
                    {
                        diagramm += (char)35;
                    }
                    for (int a = Convert.ToInt32(kind.anzahl); a <= 70 - Convert.ToInt32(kind.anzahl); a++)
                    {
                        diagramm += " ";
                    }
                    diagramm += "Name: " + kind.name + ", Anzahl: " + kind.anzahl + "\n";
                }
            }
            return diagramm;
        }
    }
}
