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
            this.nummersList = new System.Windows.Forms.ListBox();
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
            this.checkBox1.Location = new System.Drawing.Point(131, 117);
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
            this.voegToeBtn.Location = new System.Drawing.Point(131, 140);
            this.voegToeBtn.Name = "voegToeBtn";
            this.voegToeBtn.Size = new System.Drawing.Size(100, 23);
            this.voegToeBtn.TabIndex = 9;
            this.voegToeBtn.Text = "voeg toe";
            this.voegToeBtn.UseVisualStyleBackColor = true;
            this.voegToeBtn.Click += new System.EventHandler(this.voegToeBtn_Click);
            // 
            // nummersList
            // 
            this.nummersList.FormattingEnabled = true;
            this.nummersList.Location = new System.Drawing.Point(252, 12);
            this.nummersList.Name = "nummersList";
            this.nummersList.Size = new System.Drawing.Size(361, 576);
            this.nummersList.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 594);
            this.Controls.Add(this.nummersList);
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
            this.Name = "Form1";
            this.Text = "in map?";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ListBox nummersList;
    }
}

