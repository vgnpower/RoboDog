using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace RoboDog
{
    public partial class Intro : Form
    {
        private string percorso = "";
        public Intro()
        {
            InitializeComponent();
        }
        int x;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x = x + 1;
                if (x == 1)
                {
                    pictureBox1.BackgroundImage = new Bitmap(percorso + @"\tmp-1.gif");
                }
                if (x == 2)
                {
                    pictureBox1.BackgroundImage = new Bitmap(percorso + @"\tmp-2.gif");
                }
                if (x == 3)
                {
                    pictureBox1.BackgroundImage = new Bitmap(percorso + @"\tmp-3.gif");
                }
                if (x == 4)
                {
                    pictureBox1.BackgroundImage = new Bitmap(percorso + @"\tmp-4.gif");
                }
                if (x == 5)
                {
                    pictureBox1.BackgroundImage = new Bitmap(percorso + @"\tmp-5.gif");
                }
                if (x == 6)
                {
                    pictureBox1.BackgroundImage = new Bitmap(percorso + @"\tmp-6.gif");
                }
                if (x == 7)
                {
                    pictureBox1.BackgroundImage = new Bitmap(percorso + @"\tmp-7.gif");
                }
                if (x == 8)
                {
                    pictureBox1.BackgroundImage = new Bitmap(percorso + @"\tmp-8.gif");
                }
                if (x == 9)
                {
                    pictureBox1.BackgroundImage = new Bitmap(percorso + @"\tmp-9.gif");
                }
                if (x == 10)
                {
                    pictureBox1.BackgroundImage = new Bitmap(percorso + @"\tmp-10.gif");
                }
                if (x == 11)
                {
                    pictureBox1.BackgroundImage = new Bitmap(percorso + @"\tmp-11.gif");
                }
                if (x == 12)
                {
                    pictureBox1.BackgroundImage = new Bitmap(percorso + @"\tmp-12.gif");
                }
                if (x == 13)
                {
                    pictureBox1.BackgroundImage = new Bitmap(percorso + @"\tmp-13.gif");
                }
                if (x == 14)
                {
                    pictureBox1.BackgroundImage = new Bitmap(percorso + @"\tmp-14.gif");
                }
                if (x == 15)
                {
                    pictureBox1.BackgroundImage = new Bitmap(percorso + @"\tmp-15.gif");
                    SoundPlayer sound = new SoundPlayer(Path.GetDirectoryName(Application.ExecutablePath) + @"\rsc\audio\bark.wav");
                    sound.Play();
                }
                if (x == 16)
                {
                    pictureBox1.BackgroundImage = new Bitmap(percorso + @"\tmp-16.gif");
                }
                if (x == 22)
                {
                    Principale Objprincipale = new Principale(this);
                    Objprincipale.Show();
                    this.Hide();
                    timer1.Stop();
                }
            }
            catch (Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            try
            {
                percorso = Path.GetDirectoryName(Application.ExecutablePath);
                if (Directory.Exists(percorso + @"\rsc\img\intro"))
                {
                    percorso = percorso + @"\rsc\img\intro";
                }
                else
                {
                    MessageBox.Show("La cartella con le immagini non è presente, per favore reinstalla il programma!");
                }
            }
            catch(Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }
        }
    }
}
