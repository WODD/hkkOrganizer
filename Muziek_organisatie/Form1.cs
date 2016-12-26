using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Muziek_organisatie
{
    public partial class Form1 : Form
    {
        public static bool debug = true;
        List<Nummer> nummers = new List<Nummer>();
        string[] ja = new string[6]{ "jawel", "yes","ja", "jawel", "juist", "welzeker"};
        string path = Application.StartupPath + @"\save.hkk";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            load();
            
        }

        private void voegToeBtn_Click(object sender, EventArgs e)
        {
            string naam = naamIN.Text;
            string genre = genreIN.Text;
            string auteur = auteurIN.Text;
            string nummer = nummerIN.Value.ToString() + letterIN.Text.ToUpper();
            string eersteRegel = eersteRegelN.Text;
            Nummer N = new Nummer();
            N.naam = naam;
            N.genre = genre;
            N.auteur = auteur;
            N.inMap = checkBox1.Checked;
            N.nummer = nummer;
            N.eersteRegel = eersteRegel;
            N.gespeeld = new List<Plaats>();
            for(int i = 0; i <= 3; i++)
            {
                N.gespeeld.Add(createPlaats(i));
            }
            nummers.Add(N);
            updateList(nummersView);

        }
        public Plaats createPlaats(int i)
        {
            Plaats p = new Plaats();
            p.datum = i.ToString() + "D";
            p.stadNaam = i.ToString() + "P";
            p.kerknaam = i.ToString() + "k";
            return p;
        }
        public void search(string item)
        {
            /*
             naam
            genre
            auteur  
            eerste regel
            nummer
            in map
             */
            string input = zoekIN.Text;
            nummersView.Items.Clear();
            if (item == "naam")
            {
                foreach (Nummer n in nummers)
                {
                    if (n.naam.Contains(input.ToLower()))
                    {
                        
                        AddOneList(n, nummersView);
                    }
                }
            }
            if (item == "genre")
            {
                foreach (Nummer n in nummers)
                {
                    if (n.genre.Contains(input.ToLower()))
                    {
                        AddOneList(n, nummersView);
                    }
                }
            }
            if (item == "auteur")
            {
                foreach (Nummer n in nummers)
                {
                    if (n.auteur.Contains(input.ToLower()))
                    {
                        AddOneList(n, nummersView);
                    }
                }
            }
            if (item == "eerste regel")
            {
                foreach (Nummer n in nummers)
                {
                    if (n.eersteRegel.Contains(input.ToLower()))
                    {
                        AddOneList(n, nummersView);
                    }
                }
            }
            if (item == "nummer")
            {
                foreach (Nummer n in nummers)
                {
                    if (n.nummer.Contains(input.ToLower()))
                    {
                        AddOneList(n, nummersView);
                    }
                }
            }
            if (item == "in map")
            {
                bool map = input.ToLower() == "ja" || input.ToLower() == "juist";
                
                foreach (Nummer n in nummers)
                {
                    if (map && n.inMap)
                    {
                        AddOneList(n, nummersView);
                        
                    }
                    else if(!map && !n.inMap)
                    {
                        AddOneList(n, nummersView);
                    }
                }
            }
        }
        public void AddOneList(Nummer Nummer, ListView list)
        {
            
            try
            {
                ListViewItem item = new ListViewItem(Nummer.nummer);
                item.SubItems.Add(Nummer.naam);
                item.SubItems.Add(Nummer.genre);
                item.SubItems.Add(Nummer.auteur);
                list.Items.Add(item);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void updateList(ListView list)
        {
            list.Items.Clear();
            foreach (Nummer N in nummers)
            {
                try
                {
                    ListViewItem item = new ListViewItem(N.nummer);
                    item.SubItems.Add(N.naam);
                    item.SubItems.Add(N.genre);
                    item.SubItems.Add(N.auteur);
                    list.Items.Add(item);

                }
                catch (Exception)
                {
                    
                    throw; //table
                }
            }
            updateFile();
        }

        public static string Base64Encode(string plainText)
        {
            if (debug) return plainText;
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            if (debug) return base64EncodedData;
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public void load()
        {

            string json = Base64Decode(File.ReadAllText(path));
            if (json.Length < 0 || json == null || json == "") return;
            
            Console.WriteLine(json);
            nummers = JsonConvert.DeserializeObject<List<Nummer>>(json);
            updateList(nummersView);

        }

        public void updateFile()
        {
            File.WriteAllText(path, string.Empty);
            string json = JsonConvert.SerializeObject(nummers, Formatting.Indented);
            File.WriteAllText(path, Base64Encode(json));
        }

        private void zoekBtn_Click(object sender, EventArgs e)
        {
            
            search(comboBox1.SelectedItem.ToString());
        }
        
    }
}
