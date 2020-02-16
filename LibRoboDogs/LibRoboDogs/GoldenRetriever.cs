using System.Windows.Forms;
using System.Media;
using System.Drawing;
using System.IO;
using System;

namespace LibRoboDogs
{
    public class GoldenRetriever:Cane
    {
        public GoldenRetriever()
        {

        }

        public override void Immagine(PictureBox picture)
        {
            try
            {
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\golden_retriever.png");
            }
            catch (Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }
        }

        public override string Razza()
        {
            string razza = "Golden Retriever";
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
                        sound = new SoundPlayer(Path.GetDirectoryName(Application.ExecutablePath) + @"\rsc\audio\GoldenRetriever1.wav");
                        sound.Play();
                        break;
                    case 2:
                        sound = new SoundPlayer(Path.GetDirectoryName(Application.ExecutablePath) + @"\rsc\audio\GoldenRetriever2.wav");
                        sound.Play();
                        break;
                    case 3:
                        sound = new SoundPlayer(Path.GetDirectoryName(Application.ExecutablePath) + @"\rsc\audio\GoldenRetriever3.wav");
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
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\GoldenRetrieverConOrecchieLunghe.png");
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
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\GoldenRetrieverConCodaLunga.png");
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
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\GoldenRetrieverConTutto.png");
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
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\GoldenRetrieverCriniera.png");
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
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\GoldenRetrieverCod_Ore.png");
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
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\GoldenRetrieverCod_Crin.png");
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
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\GoldenRetrieverOre_Crin.png");
            }
            catch (Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }
        }

    }
}
