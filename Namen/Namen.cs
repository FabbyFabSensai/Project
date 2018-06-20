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

        public void bestaetigenButton_Click(object sender, EventArgs e)
        {
            bool pruefungBezirke = false;
            bool pruefungGeschlechter = false;
            var buttons = districtBox.Controls.OfType<RadioButton>();
            var geschlechter = genderBox.Controls.OfType<CheckBox>();
            var bezirk = "";
            foreach (RadioButton pruefButton in buttons)
            {
                if (pruefButton.Checked)
                {
                    pruefungBezirke = true;
                    bezirk = pruefButton.Text;
                }
            }
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
                if (femaleCheckbox.Checked && maleCheckbox.Checked)
                {
                    namenLabel.Text = "Alle Namen";
                    richTextBox1.Text = Program.ausgabeNamen(bezirk, "a");
                    //diagramBox.ZoomFactor = 2;
                    //diagramBox.Text = Program.Diagramm(bezirk, "a");
                }
                else if (femaleCheckbox.Checked)
                {
                    namenLabel.Text = "Mädchennamen";
                    string[] xDaten = new string[Program.getMaedchen(bezirk).Count()];
                    double[] yDaten = new double[Program.getMaedchen(bezirk).Count()];
                    int zaehler = 0;
                    foreach (Kind kind in Program.getMaedchen(bezirk))
                    {
                        xDaten[zaehler] = kind.name;
                        yDaten[zaehler] = Convert.ToDouble(kind.anzahl);
                        zaehler++;
                    }
                    richTextBox1.Text = Program.ausgabeNamen(bezirk, "w");
                    ChartArea area = new ChartArea("Chart");
                    diagrammBox.ChartAreas.Add(area);
                    Series balken = new Series();
                    balken.Points.DataBindXY(xDaten, yDaten);
                    balken.Name = "Vornamen";
                    balken.ChartType = SeriesChartType.Bar;
                    balken.ChartArea = "Chart";
                    diagrammBox.Series.Add(balken);
                    this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                }
                else
                {
                    namenLabel.Text = "Jungennamen";
                    richTextBox1.Text = Program.ausgabeNamen(bezirk, "m");
                    //diagramBox.ZoomFactor = 2;
                    //diagramBox.Text = Program.Diagramm(bezirk, "m");
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
    }
}
