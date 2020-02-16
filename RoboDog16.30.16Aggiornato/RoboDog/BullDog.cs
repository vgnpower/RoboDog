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
    class Bulldog:Cane
    {
        public Bulldog()
        {

        }

        public override void Immagine(PictureBox picture)
        {

            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\Bulldog.png");  
            
        }
        public override string Razza()
        {   
             string razza="Bull Dog";
             return razza;
        }
        public override void Abbaio()
        {
            SoundPlayer sound = new SoundPlayer(Path.GetDirectoryName(Application.ExecutablePath) + @"\rsc\audio\Bulldog.wav");
            sound.Play();
        }
        public override void OrecchieLunghe(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BullDogOrecchieGrandi.png");
        }
        public override void CodaLunga(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BullDogCodaLunga.png");
        }
        public override void Tutto(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BullDogConTutto.png");
        }
        public override void Criniera(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BullDogCriniera.png");
        }
        public override void CodeOl(PictureBox picture)
        {
             picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BullDogCoda_Ore.png");
        }
       
        public override void CodeCri(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BullDogCod_crin.png");
        }
        public override void OreCri(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\BullDogOre_Crin.png");
        }
       
    }
}


