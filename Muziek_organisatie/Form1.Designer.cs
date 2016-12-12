namespace Muziek_organisatie
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.naamIN = new System.Windows.Forms.TextBox();
            this.genreIN = new System.Windows.Forms.TextBox();
            this.auteurIN = new System.Windows.Forms.TextBox();
            this.eersteRegelN = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.voegToeBtn = new System.Windows.Forms.Button();
            this.zoekIN = new System.Windows.Forms.TextBox();
            this.zoekBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nummersView = new System.Windows.Forms.ListView();
            this.nummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.auteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.letterIN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nummerIN = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nummerIN)).BeginInit();
            this.SuspendLayout();
            // 
            // naamIN
            // 
            this.naamIN.Location = new System.Drawing.Point(131, 13);
            this.naamIN.Name = "naamIN";
            this.naamIN.Size = new System.Drawing.Size(100, 20);
            this.naamIN.TabIndex = 0;
            // 
            // genreIN
            // 
            this.genreIN.Location = new System.Drawing.Point(131, 39);
            this.genreIN.Name = "genreIN";
            this.genreIN.Size = new System.Drawing.Size(100, 20);
            this.genreIN.TabIndex = 1;
            // 
            // auteurIN
            // 
            this.auteurIN.Location = new System.Drawing.Point(131, 65);
            this.auteurIN.Name = "auteurIN";
            this.auteurIN.Size = new System.Drawing.Size(100, 20);
            this.auteurIN.TabIndex = 2;
            // 
            // eersteRegelN
            // 
            this.eersteRegelN.Location = new System.Drawing.Point(131, 91);
            this.eersteRegelN.Name = "eersteRegelN";
            this.eersteRegelN.Size = new System.Drawing.Size(100, 20);
            this.eersteRegelN.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(131, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "in map?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "naam nummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "auteur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "eerste regel";
            // 
            // voegToeBtn
            // 
            this.voegToeBtn.Location = new System.Drawing.Point(131, 166);
            this.voegToeBtn.Name = "voegToeBtn";
            this.voegToeBtn.Size = new System.Drawing.Size(100, 23);
            this.voegToeBtn.TabIndex = 9;
            this.voegToeBtn.Text = "voeg toe";
            this.voegToeBtn.UseVisualStyleBackColor = true;
            this.voegToeBtn.Click += new System.EventHandler(this.voegToeBtn_Click);
            // 
            // zoekIN
            // 
            this.zoekIN.Location = new System.Drawing.Point(264, 35);
            this.zoekIN.Name = "zoekIN";
            this.zoekIN.Size = new System.Drawing.Size(240, 20);
            this.zoekIN.TabIndex = 11;
            // 
            // zoekBtn
            // 
            this.zoekBtn.Location = new System.Drawing.Point(510, 35);
            this.zoekBtn.Name = "zoekBtn";
            this.zoekBtn.Size = new System.Drawing.Size(91, 24);
            this.zoekBtn.TabIndex = 12;
            this.zoekBtn.Text = "zoek";
            this.zoekBtn.UseVisualStyleBackColor = true;
            this.zoekBtn.Click += new System.EventHandler(this.zoekBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "nummers";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "naam",
            "genre",
            "auteur",
            "eerste regel",
            "nummer",
            "in map"});
            this.comboBox1.Location = new System.Drawing.Point(510, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // nummersView
            // 
            this.nummersView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nummer,
            this.naam,
            this.genre,
            this.auteur});
            this.nummersView.GridLines = true;
            this.nummersView.Location = new System.Drawing.Point(264, 65);
            this.nummersView.Name = "nummersView";
            this.nummersView.Size = new System.Drawing.Size(337, 517);
            this.nummersView.TabIndex = 15;
            this.nummersView.UseCompatibleStateImageBehavior = false;
            this.nummersView.View = System.Windows.Forms.View.Details;
            // 
            // nummer
            // 
            this.nummer.Text = "nummer";
            this.nummer.Width = 53;
            // 
            // naam
            // 
            this.naam.Text = "naam";
            this.naam.Width = 110;
            // 
            // genre
            // 
            this.genre.Text = "genre";
            // 
            // auteur
            // 
            this.auteur.Text = "auteur";
            this.auteur.Width = 110;
            // 
            // letterIN
            // 
            this.letterIN.Location = new System.Drawing.Point(213, 117);
            this.letterIN.MaxLength = 1;
            this.letterIN.Name = "letterIN";
            this.letterIN.Size = new System.Drawing.Size(18, 20);
            this.letterIN.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "nummer + letter";
            // 
            // nummerIN
            // 
            this.nummerIN.Location = new System.Drawing.Point(131, 117);
            this.nummerIN.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nummerIN.Name = "nummerIN";
            this.nummerIN.Size = new System.Drawing.Size(76, 20);
            this.nummerIN.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 594);
            this.Controls.Add(this.nummerIN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.letterIN);
            this.Controls.Add(this.nummersView);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zoekBtn);
            this.Controls.Add(this.zoekIN);
            this.Controls.Add(this.voegToeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.eersteRegelN);
            this.Controls.Add(this.auteurIN);
            this.Controls.Add(this.genreIN);
            this.Controls.Add(this.naamIN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "nummers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nummerIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox naamIN;
        private System.Windows.Forms.TextBox genreIN;
        private System.Windows.Forms.TextBox auteurIN;
        private System.Windows.Forms.TextBox eersteRegelN;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button voegToeBtn;
        private System.Windows.Forms.TextBox zoekIN;
        private System.Windows.Forms.Button zoekBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView nummersView;
        private System.Windows.Forms.ColumnHeader naam;
        private System.Windows.Forms.ColumnHeader genre;
        private System.Windows.Forms.ColumnHeader auteur;
        private System.Windows.Forms.TextBox letterIN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nummerIN;
        private System.Windows.Forms.ColumnHeader nummer;
    }
}

