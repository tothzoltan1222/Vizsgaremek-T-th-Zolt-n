using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace autok
{
    public partial class Form1 : Form
    {
        private List<Auto> autok = new List<Auto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnBeolvas_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("adat.txt"))
                {
                    MessageBox.Show("Az adat.txt fájl nem található !", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                autok.Clear();
                string[] sorok = File.ReadAllLines("adat.txt");

                foreach (var sor in sorok)
                {
                    if (string.IsNullOrWhiteSpace(sor)) continue;

                    string[] adatok = sor.Split(',');
                    if (adatok.Length == 2)
                    {
                        string marka = adatok[0].Trim();
                        if (int.TryParse(adatok[1].Trim(), out int evszam))
                        {
                            autok.Add(new Auto(marka, evszam));
                        }
                    }
                }

                ListahozAd(autok);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba a fájl beolvasá: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ListahozAd(List<Auto> lista)
        {
            listBox1.Items.Clear();
            foreach (var auto in lista)
            {
                listBox1.Items.Add(auto);
            }
        }

        private void btnRendez_Click(object sender, EventArgs e)
        {
            if (autok.Count == 0)
            {
                MessageBox.Show("Nincs beolvasott adat!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            autok = autok.OrderBy(a => a.Evszam).ToList();
            ListahozAd(autok);
        }

        private void btnLegregebbi_Click(object sender, EventArgs e)
        {
            if (autok.Count == 0)
            {
                MessageBox.Show("Nincs beolvasott adat !", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var legregebbi = autok.OrderBy(a => a.Evszam).First();
            lblEredmeny.Text = $"Legrégebbi: {legregebbi.Marka} ({legregebbi.Evszam})";
        }

        private void btnLegujabb_Click(object sender, EventArgs e)
        {
            if (autok.Count == 0)
            {
                MessageBox.Show("Nincs beolvasott adat!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var legujabb = autok.OrderByDescending(a => a.Evszam).First();
            lblEredmeny.Text = $"Legújabb: {legujabb.Marka} ({legujabb.Evszam})";
        }

        private void btnKeres_Click(object sender, EventArgs e)
        {
            if (autok.Count == 0)
            {
                MessageBox.Show("Nincs beolvasott adat!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtEv.Text.Trim(), out int megadottEv))
            {
                MessageBox.Show("Hibás évszám!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var szurtAutok = autok.Where(a => a.Evszam > megadottEv).ToList();
            ListahozAd(szurtAutok);
        }

        private void lblEredmeny_Click(object sender, EventArgs e)
        {
        }

        private void txtEv_TextChanged(object sender, EventArgs e)
        {
        }

        public class Auto
        {
            public string Marka { get; set; }
            public int Evszam { get; set; }


            public Auto(string marka, int evszam)
            {
                Marka = marka;
                Evszam = evszam;
            }


            public override string ToString()
            {
                return $"{Marka} - {Evszam}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}