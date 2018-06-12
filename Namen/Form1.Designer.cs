namespace Namen
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuBox = new System.Windows.Forms.GroupBox();
            this.bestaetigenButton = new System.Windows.Forms.Button();
            this.districtBox = new System.Windows.Forms.GroupBox();
            this.treptowButton = new System.Windows.Forms.RadioButton();
            this.tempelhofButton = new System.Windows.Forms.RadioButton();
            this.steglitzButton = new System.Windows.Forms.RadioButton();
            this.spandauButton = new System.Windows.Forms.RadioButton();
            this.reinickendorfButton = new System.Windows.Forms.RadioButton();
            this.pankowButton = new System.Windows.Forms.RadioButton();
            this.neukoellnButton = new System.Windows.Forms.RadioButton();
            this.mitteButton = new System.Windows.Forms.RadioButton();
            this.marzahnButton = new System.Windows.Forms.RadioButton();
            this.lichtenbergButton = new System.Windows.Forms.RadioButton();
            this.friedrichshainButton = new System.Windows.Forms.RadioButton();
            this.charlottenburgButton = new System.Windows.Forms.RadioButton();
            this.berlinButton = new System.Windows.Forms.RadioButton();
            this.genderBox = new System.Windows.Forms.GroupBox();
            this.femaleCheckbox = new System.Windows.Forms.CheckBox();
            this.maleCheckbox = new System.Windows.Forms.CheckBox();
            this.menuLabel = new System.Windows.Forms.Label();
            this.headlineBox = new System.Windows.Forms.GroupBox();
            this.bezirkLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namenLabel = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.graphBox = new System.Windows.Forms.GroupBox();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.namenslisteLabel = new System.Windows.Forms.Label();
            this.menuBox.SuspendLayout();
            this.districtBox.SuspendLayout();
            this.genderBox.SuspendLayout();
            this.headlineBox.SuspendLayout();
            this.listBox.SuspendLayout();
            this.graphBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBox
            // 
            this.menuBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuBox.Controls.Add(this.bestaetigenButton);
            this.menuBox.Controls.Add(this.districtBox);
            this.menuBox.Controls.Add(this.genderBox);
            this.menuBox.Controls.Add(this.menuLabel);
            this.menuBox.Location = new System.Drawing.Point(12, 12);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(223, 689);
            this.menuBox.TabIndex = 0;
            this.menuBox.TabStop = false;
            this.menuBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bestaetigenButton
            // 
            this.bestaetigenButton.BackColor = System.Drawing.SystemColors.Control;
            this.bestaetigenButton.Location = new System.Drawing.Point(77, 535);
            this.bestaetigenButton.Name = "bestaetigenButton";
            this.bestaetigenButton.Size = new System.Drawing.Size(140, 37);
            this.bestaetigenButton.TabIndex = 3;
            this.bestaetigenButton.Text = "Bestätigen";
            this.bestaetigenButton.UseVisualStyleBackColor = false;
            this.bestaetigenButton.Click += new System.EventHandler(this.bestaetigenButton_Click);
            // 
            // districtBox
            // 
            this.districtBox.Controls.Add(this.treptowButton);
            this.districtBox.Controls.Add(this.tempelhofButton);
            this.districtBox.Controls.Add(this.steglitzButton);
            this.districtBox.Controls.Add(this.spandauButton);
            this.districtBox.Controls.Add(this.reinickendorfButton);
            this.districtBox.Controls.Add(this.pankowButton);
            this.districtBox.Controls.Add(this.neukoellnButton);
            this.districtBox.Controls.Add(this.mitteButton);
            this.districtBox.Controls.Add(this.marzahnButton);
            this.districtBox.Controls.Add(this.lichtenbergButton);
            this.districtBox.Controls.Add(this.friedrichshainButton);
            this.districtBox.Controls.Add(this.charlottenburgButton);
            this.districtBox.Controls.Add(this.berlinButton);
            this.districtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtBox.Location = new System.Drawing.Point(6, 133);
            this.districtBox.Name = "districtBox";
            this.districtBox.Size = new System.Drawing.Size(211, 396);
            this.districtBox.TabIndex = 2;
            this.districtBox.TabStop = false;
            // 
            // treptowButton
            // 
            this.treptowButton.AutoSize = true;
            this.treptowButton.Location = new System.Drawing.Point(7, 356);
            this.treptowButton.Name = "treptowButton";
            this.treptowButton.Size = new System.Drawing.Size(140, 21);
            this.treptowButton.TabIndex = 12;
            this.treptowButton.TabStop = true;
            this.treptowButton.Text = "Treptow-Köpenick";
            this.treptowButton.UseVisualStyleBackColor = true;
            // 
            // tempelhofButton
            // 
            this.tempelhofButton.AutoSize = true;
            this.tempelhofButton.Location = new System.Drawing.Point(7, 328);
            this.tempelhofButton.Name = "tempelhofButton";
            this.tempelhofButton.Size = new System.Drawing.Size(175, 21);
            this.tempelhofButton.TabIndex = 11;
            this.tempelhofButton.TabStop = true;
            this.tempelhofButton.Text = "Tempelhof-Schöneberg";
            this.tempelhofButton.UseVisualStyleBackColor = true;
            // 
            // steglitzButton
            // 
            this.steglitzButton.AutoSize = true;
            this.steglitzButton.Location = new System.Drawing.Point(7, 300);
            this.steglitzButton.Name = "steglitzButton";
            this.steglitzButton.Size = new System.Drawing.Size(146, 21);
            this.steglitzButton.TabIndex = 10;
            this.steglitzButton.TabStop = true;
            this.steglitzButton.Text = "Steglitz-Zehlendorf";
            this.steglitzButton.UseVisualStyleBackColor = true;
            // 
            // spandauButton
            // 
            this.spandauButton.AutoSize = true;
            this.spandauButton.Location = new System.Drawing.Point(7, 273);
            this.spandauButton.Name = "spandauButton";
            this.spandauButton.Size = new System.Drawing.Size(83, 21);
            this.spandauButton.TabIndex = 9;
            this.spandauButton.TabStop = true;
            this.spandauButton.Text = "Spandau";
            this.spandauButton.UseVisualStyleBackColor = true;
            // 
            // reinickendorfButton
            // 
            this.reinickendorfButton.AutoSize = true;
            this.reinickendorfButton.Location = new System.Drawing.Point(7, 246);
            this.reinickendorfButton.Name = "reinickendorfButton";
            this.reinickendorfButton.Size = new System.Drawing.Size(113, 21);
            this.reinickendorfButton.TabIndex = 8;
            this.reinickendorfButton.TabStop = true;
            this.reinickendorfButton.Text = "Reinickendorf";
            this.reinickendorfButton.UseVisualStyleBackColor = true;
            // 
            // pankowButton
            // 
            this.pankowButton.AutoSize = true;
            this.pankowButton.Location = new System.Drawing.Point(7, 218);
            this.pankowButton.Name = "pankowButton";
            this.pankowButton.Size = new System.Drawing.Size(75, 21);
            this.pankowButton.TabIndex = 7;
            this.pankowButton.TabStop = true;
            this.pankowButton.Text = "Pankow";
            this.pankowButton.UseVisualStyleBackColor = true;
            // 
            // neukoellnButton
            // 
            this.neukoellnButton.AutoSize = true;
            this.neukoellnButton.Location = new System.Drawing.Point(7, 190);
            this.neukoellnButton.Name = "neukoellnButton";
            this.neukoellnButton.Size = new System.Drawing.Size(81, 21);
            this.neukoellnButton.TabIndex = 6;
            this.neukoellnButton.TabStop = true;
            this.neukoellnButton.Text = "Neukölln";
            this.neukoellnButton.UseVisualStyleBackColor = true;
            // 
            // mitteButton
            // 
            this.mitteButton.AutoSize = true;
            this.mitteButton.Location = new System.Drawing.Point(7, 162);
            this.mitteButton.Name = "mitteButton";
            this.mitteButton.Size = new System.Drawing.Size(56, 21);
            this.mitteButton.TabIndex = 5;
            this.mitteButton.TabStop = true;
            this.mitteButton.Text = "Mitte";
            this.mitteButton.UseVisualStyleBackColor = true;
            // 
            // marzahnButton
            // 
            this.marzahnButton.AutoSize = true;
            this.marzahnButton.Location = new System.Drawing.Point(7, 134);
            this.marzahnButton.Name = "marzahnButton";
            this.marzahnButton.Size = new System.Drawing.Size(155, 21);
            this.marzahnButton.TabIndex = 4;
            this.marzahnButton.TabStop = true;
            this.marzahnButton.Text = "Marzahn-Hellersdorf";
            this.marzahnButton.UseVisualStyleBackColor = true;
            // 
            // lichtenbergButton
            // 
            this.lichtenbergButton.AutoSize = true;
            this.lichtenbergButton.Location = new System.Drawing.Point(7, 106);
            this.lichtenbergButton.Name = "lichtenbergButton";
            this.lichtenbergButton.Size = new System.Drawing.Size(101, 21);
            this.lichtenbergButton.TabIndex = 3;
            this.lichtenbergButton.TabStop = true;
            this.lichtenbergButton.Text = "Lichtenberg";
            this.lichtenbergButton.UseVisualStyleBackColor = true;
            // 
            // friedrichshainButton
            // 
            this.friedrichshainButton.AutoSize = true;
            this.friedrichshainButton.Location = new System.Drawing.Point(7, 78);
            this.friedrichshainButton.Name = "friedrichshainButton";
            this.friedrichshainButton.Size = new System.Drawing.Size(186, 21);
            this.friedrichshainButton.TabIndex = 2;
            this.friedrichshainButton.TabStop = true;
            this.friedrichshainButton.Text = "Friedrichshain-Kreuzberg";
            this.friedrichshainButton.UseVisualStyleBackColor = true;
            // 
            // charlottenburgButton
            // 
            this.charlottenburgButton.AutoSize = true;
            this.charlottenburgButton.Location = new System.Drawing.Point(6, 50);
            this.charlottenburgButton.Name = "charlottenburgButton";
            this.charlottenburgButton.Size = new System.Drawing.Size(200, 21);
            this.charlottenburgButton.TabIndex = 1;
            this.charlottenburgButton.TabStop = true;
            this.charlottenburgButton.Text = "Charlottenburg-Wilmersdorf";
            this.charlottenburgButton.UseVisualStyleBackColor = true;
            // 
            // berlinButton
            // 
            this.berlinButton.AutoSize = true;
            this.berlinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.berlinButton.Location = new System.Drawing.Point(6, 22);
            this.berlinButton.Name = "berlinButton";
            this.berlinButton.Size = new System.Drawing.Size(133, 22);
            this.berlinButton.TabIndex = 0;
            this.berlinButton.TabStop = true;
            this.berlinButton.Text = "Gesamt Berlin";
            this.berlinButton.UseVisualStyleBackColor = true;
            // 
            // genderBox
            // 
            this.genderBox.Controls.Add(this.femaleCheckbox);
            this.genderBox.Controls.Add(this.maleCheckbox);
            this.genderBox.Location = new System.Drawing.Point(6, 44);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(211, 74);
            this.genderBox.TabIndex = 1;
            this.genderBox.TabStop = false;
            // 
            // femaleCheckbox
            // 
            this.femaleCheckbox.AutoSize = true;
            this.femaleCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleCheckbox.Location = new System.Drawing.Point(7, 44);
            this.femaleCheckbox.Name = "femaleCheckbox";
            this.femaleCheckbox.Size = new System.Drawing.Size(80, 21);
            this.femaleCheckbox.TabIndex = 1;
            this.femaleCheckbox.Text = "Weiblich";
            this.femaleCheckbox.UseVisualStyleBackColor = true;
            // 
            // maleCheckbox
            // 
            this.maleCheckbox.AutoSize = true;
            this.maleCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleCheckbox.Location = new System.Drawing.Point(7, 17);
            this.maleCheckbox.Name = "maleCheckbox";
            this.maleCheckbox.Size = new System.Drawing.Size(83, 21);
            this.maleCheckbox.TabIndex = 0;
            this.maleCheckbox.Text = "Männlich";
            this.maleCheckbox.UseVisualStyleBackColor = true;
            this.maleCheckbox.CheckedChanged += new System.EventHandler(this.maleCheckbox_CheckedChanged);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(25, 16);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(62, 25);
            this.menuLabel.TabIndex = 0;
            this.menuLabel.Text = "Menü";
            this.menuLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // headlineBox
            // 
            this.headlineBox.Controls.Add(this.bezirkLabel);
            this.headlineBox.Controls.Add(this.label2);
            this.headlineBox.Controls.Add(this.namenLabel);
            this.headlineBox.Location = new System.Drawing.Point(241, 12);
            this.headlineBox.Name = "headlineBox";
            this.headlineBox.Size = new System.Drawing.Size(1013, 85);
            this.headlineBox.TabIndex = 1;
            this.headlineBox.TabStop = false;
            // 
            // bezirkLabel
            // 
            this.bezirkLabel.AutoSize = true;
            this.bezirkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bezirkLabel.Location = new System.Drawing.Point(371, 23);
            this.bezirkLabel.Name = "bezirkLabel";
            this.bezirkLabel.Size = new System.Drawing.Size(175, 46);
            this.bezirkLabel.TabIndex = 2;
            this.bezirkLabel.Text = "Bezirken";
            this.bezirkLabel.Click += new System.EventHandler(this.bezirkLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "in ";
            // 
            // namenLabel
            // 
            this.namenLabel.AutoSize = true;
            this.namenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namenLabel.Location = new System.Drawing.Point(6, 23);
            this.namenLabel.MinimumSize = new System.Drawing.Size(309, 54);
            this.namenLabel.Name = "namenLabel";
            this.namenLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.namenLabel.Size = new System.Drawing.Size(309, 54);
            this.namenLabel.TabIndex = 0;
            this.namenLabel.Text = "Namen";
            this.namenLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.namenLabel.UseCompatibleTextRendering = true;
            this.namenLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // listBox
            // 
            this.listBox.Controls.Add(this.namenslisteLabel);
            this.listBox.Controls.Add(this.vScrollBar1);
            this.listBox.Location = new System.Drawing.Point(241, 103);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(1013, 276);
            this.listBox.TabIndex = 2;
            this.listBox.TabStop = false;
            this.listBox.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(993, 16);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 257);
            this.vScrollBar1.TabIndex = 0;
            // 
            // graphBox
            // 
            this.graphBox.Controls.Add(this.vScrollBar2);
            this.graphBox.Location = new System.Drawing.Point(241, 385);
            this.graphBox.Name = "graphBox";
            this.graphBox.Size = new System.Drawing.Size(1013, 316);
            this.graphBox.TabIndex = 3;
            this.graphBox.TabStop = false;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(993, 16);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 297);
            this.vScrollBar2.TabIndex = 0;
            // 
            // namenslisteLabel
            // 
            this.namenslisteLabel.AutoSize = true;
            this.namenslisteLabel.Location = new System.Drawing.Point(7, 20);
            this.namenslisteLabel.Name = "namenslisteLabel";
            this.namenslisteLabel.Size = new System.Drawing.Size(0, 13);
            this.namenslisteLabel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1266, 713);
            this.Controls.Add(this.graphBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.headlineBox);
            this.Controls.Add(this.menuBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuBox.ResumeLayout(false);
            this.menuBox.PerformLayout();
            this.districtBox.ResumeLayout(false);
            this.districtBox.PerformLayout();
            this.genderBox.ResumeLayout(false);
            this.genderBox.PerformLayout();
            this.headlineBox.ResumeLayout(false);
            this.headlineBox.PerformLayout();
            this.listBox.ResumeLayout(false);
            this.listBox.PerformLayout();
            this.graphBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox menuBox;
        private System.Windows.Forms.GroupBox headlineBox;
        private System.Windows.Forms.GroupBox listBox;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox graphBox;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.GroupBox genderBox;
        private System.Windows.Forms.CheckBox femaleCheckbox;
        private System.Windows.Forms.CheckBox maleCheckbox;
        private System.Windows.Forms.GroupBox districtBox;
        private System.Windows.Forms.RadioButton berlinButton;
        private System.Windows.Forms.RadioButton treptowButton;
        private System.Windows.Forms.RadioButton tempelhofButton;
        private System.Windows.Forms.RadioButton steglitzButton;
        private System.Windows.Forms.RadioButton spandauButton;
        private System.Windows.Forms.RadioButton reinickendorfButton;
        private System.Windows.Forms.RadioButton pankowButton;
        private System.Windows.Forms.RadioButton neukoellnButton;
        private System.Windows.Forms.RadioButton mitteButton;
        private System.Windows.Forms.RadioButton marzahnButton;
        private System.Windows.Forms.RadioButton lichtenbergButton;
        private System.Windows.Forms.RadioButton friedrichshainButton;
        private System.Windows.Forms.RadioButton charlottenburgButton;
        private System.Windows.Forms.Button bestaetigenButton;
        private System.Windows.Forms.Label namenLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bezirkLabel;
        private System.Windows.Forms.Label namenslisteLabel;
    }
}

