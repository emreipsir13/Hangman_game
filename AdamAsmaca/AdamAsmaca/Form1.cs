using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class Form1 : Form
    {
        int kazanma = 0;
        int kaybetme = 0;
        int sayac = 0;
        int skor = 0;
        bool tuttu = false;
        char[] harfharf;
        List<string> tahmin = new List<string>();
        //Words are chosing from this list you can add or remove things from this list.
        List<string> kelimeler = new List<string> { "ARI", "AT", "AKREP", "ARMADILLO", "KÖSTEBEK", "KÖPEK", "KEDI", "KURBAĞA", "KAPLUMBAĞA", "BOĞA", "YILAN", "YUNUS", "KARTAL", "KARGA", "KUNDUZ", "KANARYA", "DEVE", "AĞAÇKAKAN" };
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            int tercih = rnd.Next(0, kelimeler.Count);
            label1.Text = "";
            for (int i=0;i<(kelimeler[tercih]).Length;i++)
            { label1.Text += "_ "; }
            harfharf = kelimeler[tercih].ToCharArray();
            for (int a=0;a<kelimeler[tercih].Length;a++)
            {
                tahmin.Add("");
            }
            label3.Text = ("   +---+   \n       |   \n       |   \n       |   \n       |   \n       |   \n===========\n");
        }
        private void buttonclick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
            for (int x=0;x<harfharf.Length;x++)
            {
                if (Convert.ToChar(btn.Text)==harfharf[x])
                { tahmin[x] = btn.Text; tuttu = true; skor++; }
            }
            if (tuttu == false)
            { sayac++; }
            if (sayac == 0)
            {
                label3.Text = ("   +---+   \n       |   \n       |   \n       |   \n       |   \n       |   \n===========\n");
            }
            else if (sayac == 1)
            {
                label3.Text = ("   +---+   \n   |   |   \n       |   \n       |   \n       |   \n       |   \n===========\n");
            }
            else if (sayac == 2)
            {
                label3.Text = ("   +---+   \n   |   |   \n   O  |   \n   |   |   \n       |   \n       |   \n===========\n");
            }
            else if (sayac == 3)
            {
                label3.Text = ("   +---+   \n   |   |   \n   O  |   \n  /|   |   \n       |   \n       |   \n===========\n");
            }
            else if (sayac == 4)
            {
                label3.Text = ("   +---+   \n   |   |   \n   O  |   \n  /|\\  |   \n       |   \n       |   \n===========\n");
            }
            else if (sayac == 5)
            { 
                label3.Text = ("   +---+   \n   |   |   \n   O  |   \n  /|\\  |   \n  /    |   \n       |   \n===========\n");
            }
            else if (sayac == 6)
            {
                label3.Text = ("   +---+   \n   |   |   \n   O  |   \n  /|\\  |   \n  / \\  |   \n       |   \n===========\n");
            }
            if (sayac==6)
            { label5.Text = "MAYBE NEXT TIME !!!";
                foreach (Button button in this.Controls.OfType<Button>())
                    button.Enabled = false;
                button21.Enabled = true;
                kaybetme++;
                label8.Text = Convert.ToString(kaybetme);
            }
            if(skor==harfharf.Length)
            { label5.Text = "CONGRATULATIONS !!!";
                foreach (Button button in this.Controls.OfType<Button>())
                    button.Enabled = false;
                button21.Enabled = true;
                kazanma++;
                label7.Text = Convert.ToString(kazanma);
            }
            label2.Text = "";
            for(int i=0;i<harfharf.Length;i++)
            {
                label2.Text += " " + tahmin[i];
                if (tahmin[i] == "")
                { label2.Text += "  "; }
            }
            tuttu = false;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            tahmin.Clear();
            foreach (Button button in this.Controls.OfType<Button>())
                button.Enabled = true;
            sayac = 0;
            skor = 0;
            Random rnd = new Random();
            int tercih = rnd.Next(0, kelimeler.Count);
            label1.Text = "";
            for (int i = 0; i < (kelimeler[tercih]).Length; i++)
            { label1.Text += "_ "; }
            harfharf = kelimeler[tercih].ToCharArray();
            for (int a = 0; a < kelimeler[tercih].Length; a++)
            {
                tahmin.Add("");
            }
            label3.Text = ("   +---+   \n       |   \n       |   \n       |   \n       |   \n       |   \n===========\n");
            label2.Text = "";
            label5.Text = "";
        }
    }
}