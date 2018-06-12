using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Namen
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void bestaetigenButton_Click(object sender, EventArgs e)
        {
            bool pruefungBezirke = false;
            bool pruefungGeschlechter = false;
            var buttons = districtBox.Controls.OfType<RadioButton>();
            var geschlechter = genderBox.Controls.OfType<CheckBox>();
            var bezirk = "";
            foreach ( RadioButton pruefButton in buttons)
            {
                if (pruefButton.Checked) {
                    pruefungBezirke = true;
                    bezirk = pruefButton.Text;
                } 
            }
            foreach (CheckBox pruefBox in geschlechter)
            {
                if(pruefBox.Checked)
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
                    string eintrag="";
                    foreach (string eintraege in Program.GetNamensliste(bezirk.ToLower(), "a"))
                    {
                        eintrag = eintrag + eintraege+ "/n" ;
                    }
                    namenslisteLabel.Text = eintrag;
                }
                else if (femaleCheckbox.Checked)
                {
                    namenLabel.Text = "Mädchennamen";
                }
                else namenLabel.Text = "Jungennamen";           
            }
        }


        //test
        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void bezirkLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
