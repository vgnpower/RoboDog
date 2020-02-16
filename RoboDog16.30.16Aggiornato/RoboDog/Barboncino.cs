using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing;
using System.IO;

namespace RoboDog
{
    class Barboncino:Cane
    {

        public Barboncino()
        {

        }

        public override void Immagine(PictureBox picture)
        {
         
          picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\barboncino.png");
                     
        }
        public override string Razza()
        {
            string razza = "Barboncino";
            return razza;
        }
        public override void Abbaio()
        {
            SoundPlayer sound = new SoundPlayer(Path.GetDirectoryName(Application.ExecutablePath) + @"\rsc\audio\Barboncino.wav");
            sound.Play();
        }
        //da aggiundere
        public override void OrecchieLunghe(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BarboncinoOrecchieLunghe.png");
        }
        public override void CodaLunga(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BarboncinoCodaLunga.png");
        }
        public override void Tutto(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BarboncinoConTutto.png");
        }
        public override void Criniera(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BarboncinoCriniera.png");
        }

        public override void CodeOl(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BarboncinoCoda_Orecchie.png");
        }
        public override void CodeCri(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BarboncinoCrin_Coda.png");
        }
        public override void OreCri(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BarboncinoOrecchie_Criniera.png");
        }
       
    }

}
