using System.Windows.Forms;
using System.Media;
using System.Drawing;
using System.IO;
using System;

namespace LibRoboDogs
{
    public class Barboncino:Cane
    {
        public Barboncino()
        {

        }

        public override void Immagine(PictureBox picture)
        {
            try
            {
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\barboncino.png");
            }
            catch (Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }
        }

        public override string Razza()
        {
            string razza = "Barboncino";
            return razza;
        }

        public override void Abbaio()
        {
            try
            {
                SoundPlayer sound;
                switch (TipoAbbaio)
                {
                    case 1:
                        sound = new SoundPlayer(Path.GetDirectoryName(Application.ExecutablePath) + @"\rsc\audio\Barboncino1.wav");
                        sound.Play();
                        break;
                    case 2:
                        sound = new SoundPlayer(Path.GetDirectoryName(Application.ExecutablePath) + @"\rsc\audio\Barboncino2.wav");
                        sound.Play();
                        break;
                    case 3:
                        sound = new SoundPlayer(Path.GetDirectoryName(Application.ExecutablePath) + @"\rsc\audio\Barboncino3.wav");
                        sound.Play();
                        break;
                }
            }
            catch (Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }
        }

        public override void OrecchieLunghe(PictureBox picture)
        {
            try
            {
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BarboncinoOrecchieLunghe.png");
            }
            catch (Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }
        }

        public override void CodaLunga(PictureBox picture)
        {
            try
            {
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BarboncinoCodaLunga.png");
            }
            catch (Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }
        }

        public override void Tutto(PictureBox picture)
        {
            try
            {
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BarboncinoConTutto.png");
            }
            catch (Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }
        }

        public override void Criniera(PictureBox picture)
        {
            try
            {
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BarboncinoCriniera.png");
            }
            catch (Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }
        }

        public override void CodeOl(PictureBox picture)
        {
            try
            {
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BarboncinoCoda_Orecchie.png");
            }
            catch (Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }
        }

        public override void CodeCri(PictureBox picture)
        {
            try
            {
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BarboncinoCrin_Coda.png");
            }
            catch (Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }
        }

        public override void OreCri(PictureBox picture)
        {
            try
            {
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BarboncinoOrecchie_Criniera.png");
            }
            catch (Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }
        }
               
    }
}
