using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muziek_organisatie
{
    public partial class Form1 : Form
    {
        List<Nummer> nummers= new List<Nummer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void voegToeBtn_Click(object sender, EventArgs e)
        {
            string naam = naamIN.Text;
            string genre = genreIN.Text;
            string auteur = auteurIN.Text;
            Nummer N = new Nummer();
            N.name = naam;
            N.genre = genre;
            N.composer = auteur;
            N.inMap = checkBox1.Checked;
            nummers.Add(N);
            update(nummersList);

        }

        public void update(ListBox list)
        {
            list.Items.Clear();
            foreach (Nummer N in nummers)
            {
                string data = N.name + " - " + N.genre + " - " + N.composer;
                list.Items.Add(data);
            }
        }
    }
}
