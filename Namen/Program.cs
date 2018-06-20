using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
           
            Console.WriteLine(getNewBornWholeBerlin());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Namen());
        }

        public static List<Kind> GetNamensliste(string bezirk)
        {
            List<Kind> kinder = new List<Kind>();
            CSVLoader daten = CSVLoader.getInstance;
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
                    for (int a = Convert.ToInt32(kind.anzahl); a<=90 - Convert.ToInt32(kind.anzahl); a++ )
                    {
                        diagramm += " ";
                    }
                    diagramm += "Name: " + kind.name + ", Anzahl: " + kind.anzahl +"\n";
                } else if (geschlecht=="a")
                {
                    for (int i = 0; i < Convert.ToInt32(kind.anzahl); i++)
                    {
                        diagramm += (char)35;
                    }
                    for (int a = Convert.ToInt32(kind.anzahl); a <= 90 - Convert.ToInt32(kind.anzahl); a++)
                    {
                        diagramm += " ";
                    }
                    diagramm += "Name: " + kind.name + ", Anzahl: " + kind.anzahl + "\n";
                }
            }
            return diagramm;
        }
        /// <summary>
        /// Gibt alle Mädchen in einem Bezirk als Liste zurück
        /// </summary>
        /// <param name="bezirk"></param>
        /// <returns></returns>
        public static List<Kind> getMaedchen(string bezirk)
        {
            List<Kind> kinder = new List<Kind>();
            foreach(Kind kind in GetNamensliste(bezirk))
            {
                if (kind.geschlecht == "w")
                {
                    kinder.Add(kind);
                }
            }
            return kinder;
        }
        /// <summary>
        /// Gibt alle Jungen in einem Bezirk als Liste zurück
        /// </summary>
        /// <param name="bezirk"></param>
        /// <returns></returns>
        public static List<Kind> getJungen(string bezirk)
        {
            List<Kind> kinder = new List<Kind>();
            foreach (Kind kind in GetNamensliste(bezirk))
            {
                if (kind.geschlecht == "m")
                {
                    kinder.Add(kind);
                }
            }
            return kinder;
        }
        /// <summary>
        /// Gibt die summe aller neugeborenen Kinder in Berlin zurück
        /// </summary>
        /// <returns></returns>
        public static int getNewBornWholeBerlin()
        {
            CSVLoader loader = CSVLoader.getInstance;
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            int mitte = loader.countNewBornInFile(path + "\\csv_data\\" + "mitte" + ".csv");
            int charlottenburgWilmersdorf = loader.countNewBornInFile(path + "\\csv_data\\" + "charlottenburg-wilmersdorf" + ".csv");
            int friedrichshainKreuzberg = loader.countNewBornInFile(path + "\\csv_data\\" + "friedrichshain-kreuzberg" + ".csv");
            int lichtenberg = loader.countNewBornInFile(path + "\\csv_data\\" + "lichtenberg" + ".csv");
            int marzahnHellersdorf = loader.countNewBornInFile(path + "\\csv_data\\" + "marzahn-hellersdorf" + ".csv");
            int neukoelln = loader.countNewBornInFile(path + "\\csv_data\\" + "neukoelln" + ".csv");
            int pankow = loader.countNewBornInFile(path + "\\csv_data\\" + "pankow" + ".csv");
            int reinickendorf = loader.countNewBornInFile(path + "\\csv_data\\" + "reinickendorf" + ".csv");
            int spandau = loader.countNewBornInFile(path + "\\csv_data\\" + "spandau" + ".csv");
            int steglitzZehlendorf = loader.countNewBornInFile(path + "\\csv_data\\" + "steglitz-zehlendorf" + ".csv");
            int tempelhofSchoeneberg = loader.countNewBornInFile(path + "\\csv_data\\" + "tempelhof-schoenebergf" + ".csv");
            int treptowKoepenick = loader.countNewBornInFile(path + "\\csv_data\\" + "treptow-koepenick" + ".csv");
            int result = mitte + charlottenburgWilmersdorf + friedrichshainKreuzberg + lichtenberg + marzahnHellersdorf + neukoelln + pankow + reinickendorf + spandau + steglitzZehlendorf + tempelhofSchoeneberg + treptowKoepenick;


            return result;
        }



    }
}
