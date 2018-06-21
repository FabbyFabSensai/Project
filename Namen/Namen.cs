using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Namen
{
    public partial class Namen : Form
    {
        public Namen()
        {
            InitializeComponent();
            //leere Tabelle anzeigen
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Anzahl";
            dataGridView1.Columns[2].Name = "Geschlecht";
            dataGridView1.Columns[3].Name = "Position";
            dataGridView1.Columns[0].DisplayIndex = 0;
            dataGridView1.Columns[1].DisplayIndex = 1;
            dataGridView1.Columns[2].DisplayIndex = 2;
            dataGridView1.Columns[3].DisplayIndex = 3;
      
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void maleCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }
        //Initialisierung Diagrammelemente
        ChartArea area = new ChartArea("Chart");
        Series mbalken = new Series();
        Series jbalken = new Series();
        public void bestaetigenButton_Click(object sender, EventArgs e)
        {
            //Leeren des Diagramms für Mehrfachaufrufe
            diagrammBox.ChartAreas.Clear();
            diagrammBox.Series.Clear();
            area.AxisX.Interval = 1;
            panel2.AutoScroll = true;
            mbalken.Name = "Mädchen";
            jbalken.Name = "Jungen";
            bool pruefungBezirke = false;
            bool pruefungGeschlechter = false;
            var buttons = districtBox.Controls.OfType<RadioButton>();
            var geschlechter = genderBox.Controls.OfType<CheckBox>();
            var bezirk = "";
            //Prüfung ob ein Bezirk ausgewählt ist
            foreach (RadioButton pruefButton in buttons)
            {
                if (pruefButton.Checked)
                {
                    pruefungBezirke = true;
                    bezirk = pruefButton.Text;
                }
            }
            //Pruefung ob mindestens ein Geschlecht ausgewählt ist
            foreach (CheckBox pruefBox in geschlechter)
            {
                if (pruefBox.Checked)
                {
                    pruefungGeschlechter = true;
                }
            }
            if (pruefungBezirke == false) MessageBox.Show("Bitte wählen Sie einen Bezirk aus");
            if (pruefungGeschlechter == false) MessageBox.Show("Bitte wählen Sie mindestens ein Geschlecht aus");
            if (pruefungBezirke == true && pruefungGeschlechter == true)
            {
                bezirkLabel.Text = bezirk;
                if (bezirk != "Gesamt Berlin")
                {
                    gesamtLabel.Text = "";
                    //Ausgabe alle Kinder
                    if (femaleCheckbox.Checked && maleCheckbox.Checked)
                    {
                        namenLabel.Text = "Alle Namen";
                        fillTable(true, true, bezirk);
                        // Anfang Diagramm für beide Geschlechter
                        string[] xDaten = new string[Program.getMaedchen(bezirk).Count()];
                        double[] yDaten = new double[Program.getMaedchen(bezirk).Count()];
                        string[] xDaten2 = new string[Program.getJungen(bezirk).Count()];
                        double[] yDaten2 = new double[Program.getJungen(bezirk).Count()];
                        int zaehler = 0;
                        int zaehler2 = 0;
                        //Füllung der MädchenSerie
                        for (int i = Program.getMaedchen(bezirk).Count - 1; i >= 0; i--)
                        {
                            xDaten[zaehler] = Program.getMaedchen(bezirk)[i].name;
                            yDaten[zaehler] = Convert.ToDouble(Program.getMaedchen(bezirk)[i].anzahl);
                            zaehler++;
                        }
                        //Füllung der JungenSerie
                        for (int i = Program.getJungen(bezirk).Count - 1; i >= 0; i--)
                        {
                            xDaten[zaehler2] = xDaten[zaehler2] + " / " + Program.getJungen(bezirk)[i].name;
                            yDaten2[zaehler2] = Convert.ToDouble(Program.getJungen(bezirk)[i].anzahl);
                            zaehler2++;
                        }
                        diagrammBox.ChartAreas.Add(area);
                        mbalken.Points.DataBindXY(xDaten, yDaten);
                        mbalken.Color = Color.PaleVioletRed;
                        mbalken["PixelPointWidth"] = "8";
                        mbalken.ChartType = SeriesChartType.Bar;
                        mbalken.ChartArea = "Chart";
                        jbalken.Points.DataBindXY(xDaten, yDaten2);
                        jbalken.Color = Color.Blue;
                        jbalken["PixelPointWidth"] = "8";
                        jbalken.ChartType = SeriesChartType.Bar;
                        jbalken.ChartArea = "Chart";
                        diagrammBox.Series.Add(jbalken);
                        diagrammBox.Series.Add(mbalken);
                        // Ende Diagramm
                    }
                    //Ausgabe für Mädchen
                    else if (femaleCheckbox.Checked)
                    { 
                        fillTable(true, false, bezirk);
                        namenLabel.Text = "Mädchennamen";
                        string[] xDaten = new string[Program.getMaedchen(bezirk).Count()];
                        double[] yDaten = new double[Program.getMaedchen(bezirk).Count()];
                        int zaehler = 0;
                        for (int i = Program.getMaedchen(bezirk).Count-1; i >= 0; i--)
                        {
                            xDaten[zaehler] = Program.getMaedchen(bezirk)[i].name;
                            yDaten[zaehler] = Convert.ToDouble(Program.getMaedchen(bezirk)[i].anzahl);
                            zaehler++;
                        }
                        diagrammBox.ChartAreas.Add(area);
                        mbalken.Points.DataBindXY(xDaten, yDaten);
                        mbalken.Color = Color.PaleVioletRed;
                        mbalken["PixelPointWidth"] = "8";
                        mbalken.ChartType = SeriesChartType.Bar;
                        mbalken.ChartArea = "Chart";
                        diagrammBox.Series.Add(mbalken);
                    }
                    //Ausgabe für Jungen
                    else
                    {
                        namenLabel.Text = "Jungennamen";
                        fillTable(false, true, bezirk);
                        string[] xDaten = new string[Program.getJungen(bezirk).Count()];
                        double[] yDaten = new double[Program.getJungen(bezirk).Count()];
                        int zaehler = 0;
                        for (int i = Program.getJungen(bezirk).Count - 1; i >= 0; i--)
                        {
                            xDaten[zaehler] = Program.getJungen(bezirk)[i].name;
                            yDaten[zaehler] = Convert.ToDouble(Program.getJungen(bezirk)[i].anzahl);
                            zaehler++;
                        }
                        diagrammBox.ChartAreas.Add(area);
                        jbalken.Points.DataBindXY(xDaten, yDaten);
                        jbalken.Color = Color.Blue;
                        jbalken["PixelPointWidth"] = "8";
                        jbalken.ChartType = SeriesChartType.Bar;
                        jbalken.ChartArea = "Chart";
                        diagrammBox.Series.Add(jbalken);
                    }
                } else
                {
                    dataGridView1.Rows.Clear();
                    gesamtLabel.Text ="In Berlin wurden letztes \n"+"Jahr "+ Program.getNewBornWholeBerlin().ToString() + " Kinder geboren.";
                }
            }
        }
        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void bezirkLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void diagramBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void graphBox_Enter(object sender, EventArgs e)
        {

        }

        private void fillTable(bool isFemale, bool isMale, string bezirk)
        {
            //Tabelle leeren,Console.WriteLine(dataGridView1.RowCount);<-- zum debugen prüfen ob tabelle wirklich geleert worden ist
            dataGridView1.Rows.Clear();
            Console.WriteLine(dataGridView1.RowCount);
            if (isFemale && isMale)
            {
                List<Kind> girlsAndBoys = Program.getMaedchen(bezirk);
                girlsAndBoys.AddRange(Program.getJungen(bezirk));
                foreach (Kind kind in girlsAndBoys)
                {
                    String geschlecht = "";
                    if (kind.geschlecht == "m")
                    {
                        geschlecht = "männlich";
                    }
                    else if (kind.geschlecht == "w")
                    {
                        geschlecht = "weiblich";
                    }
                    string[] row = { kind.name, kind.anzahl, geschlecht, kind.position + ". Name" };
                    dataGridView1.Rows.Add(row);
                }
            }
            else if (isFemale)
            {
                List<Kind> girls = Program.getMaedchen(bezirk);
                foreach(Kind kind in girls)
                {
                    String geschlecht = "";
                    if(kind.geschlecht == "m")
                    {
                        geschlecht = "männlich";
                    } else if(kind.geschlecht == "w")
                    {
                        geschlecht = "weiblich";
                    }
                    string[] row = { kind.name, kind.anzahl, geschlecht, kind.position+". Name" };
                    dataGridView1.Rows.Add(row);   
                } 
            }
            else if (isMale)
            {
                List<Kind> boys = Program.getJungen(bezirk);
                foreach (Kind kind in boys)
                {
                    String geschlecht = "";
                    if (kind.geschlecht == "m")
                    {
                        geschlecht = "männlich";
                    }
                    else if (kind.geschlecht == "w")
                    {
                        geschlecht = "weiblich";
                    }
                    string[] row = { kind.name, kind.anzahl, geschlecht, kind.position + ". Name" };
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void diagrammBox_Click(object sender, EventArgs e)
        {

        }
    }
}
