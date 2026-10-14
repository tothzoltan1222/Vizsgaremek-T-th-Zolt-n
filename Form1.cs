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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // Segédfüggsjvény a ListBox feltöltésére
        private void ListahozAd(List<Auto> lista)
        {
            ListBox1.Items.Clear();
            foreach (var auto in lista)
            {
                ListBox1.Items.Add(auto);
            }
        }

        // 1. Beolvasás gomb
        private void btnBeolvas_Click(object sender, EventArgs e)
        {
            try
            {
                string fajl = Path.Combine(AppContext.BaseDirectory, "adat.txt");
                if (!File.Exists(fajl))
                {
                    MessageBox.Show("Az adat.txt fájl nem található!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                autok.Clear();
                ListBox1.Items.Clear();

                foreach (string sor in File.ReadAllLines(fajl))
                {
                    if (string.IsNullOrWhiteSpace(sor)) continue;
                    string[] adat = sor.Split(',');
                    if (adat.Length == 2 && int.TryParse(adat[1].Trim(), out int ev))
                    {
                        Auto auto = new Auto(adat[0].Trim(), ev);
                        autok.Add(auto);
                    }
                }

                ListahozAd(autok);
                lblEredmeny.Text = "Beolvasva: " + autok.Count + " autó";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba a fájl beolvasásakor: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Rendezés gomb (növekvő: legrégebbi -> legújabb)
        private void btnRendez_Click(object sender, EventArgs e)
        {
            if (autok.Count == 0)
            {
                MessageBox.Show("Nincs beolvasott adat!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            autok = autok.OrderBy(a => a.Evszam).ToList();
            ListahozAd(autok);
            lblEredmeny.Text = "Autók rendezve évszám szerint.";
        }

        // 3. Legrégebbi autó gomb
        private void btnLegregebbi_Click(object sender, EventArgs e)
        {
            if (autok.Count == 0)
            {
                MessageBox.Show("Nincs beolvasott adat!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var legregebbi = autok.OrderBy(a => a.Evszam).First();
            lblEredmeny.Text = $"Legrégebbi: {legregebbi.Marka} ({legregebbi.Evszam})";
        }

        // 4. Legújabb autó gomb
        private void btnLegujabb_Click(object sender, EventArgs e)
        {
            if (autok.Count == 0)
            {
                MessageBox.Show("Nincs beolvasott adat!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var legujabb = autok.OrderByDescending(a => a.Evszam).First();
            lblEredmeny.Text = $"Legújabb: {legujabb.Marka} ({legujabb.Evszam})";
        }

        // 5. Keresés gomb (megadott évszám feletti autók)
        private void btnKeres_Click(object sender, EventArgs e)
        {
            if (autok.Count == 0)
            {
                MessageBox.Show("Nincs beolvasott adat!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtEv.Text.Trim(), out int megadottEv))
            {
                MessageBox.Show("Kérlek adj meg egy érvényes évszámot a mezőben!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var szurtAutok = autok.Where(a => a.Evszam > megadottEv).ToList();
            ListahozAd(szurtAutok);
            lblEredmeny.Text = $"Találat: {szurtAutok.Count} db autó";
        }

        private void lblEredmeny_Click(object sender, EventArgs e)
        {
        }

        private void txtEv_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEv_TextChanged_1(object sender, EventArgs e)
        {

        }
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
}