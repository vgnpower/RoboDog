using System.Windows.Forms;
using System.Media;
using System.Drawing;
using System.IO;
using System;

namespace LibRoboDogs
{
    public class Bulldog:Cane
    {
        public Bulldog()
        {

        }

        public override void Immagine(PictureBox picture)
        {
            try
            {
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\Bulldog.png");
            }
            catch (Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }           
        }

        public override string Razza()
        {   
             string razza="Bull Dog";
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
                        sound = new SoundPlayer(Path.GetDirectoryName(Application.ExecutablePath) + @"\rsc\audio\Bulldog1.wav");
                        sound.Play();
                        break;
                    case 2:
                        sound = new SoundPlayer(Path.GetDirectoryName(Application.ExecutablePath) + @"\rsc\audio\Bulldog2.wav");
                        sound.Play();
                        break;
                    case 3:
                        sound = new SoundPlayer(Path.GetDirectoryName(Application.ExecutablePath) + @"\rsc\audio\Bulldog3.wav");
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
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BullDogOrecchieGrandi.png");
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
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BullDogCodaLunga.png");
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
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BullDogConTutto.png");
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
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BullDogCriniera.png");
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
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BullDogCoda_Ore.png");
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
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BullDogCod_crin.png");
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
                picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BullDogOre_Crin.png");
            }
            catch (Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }
        }
       
    }
}


