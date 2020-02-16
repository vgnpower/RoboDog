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
    class GoldenRetriever:Cane
    {
        public GoldenRetriever()
        {

        }

        public override void Immagine(PictureBox picture)
        {

            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\golden_retriever.png");

        }
        public override string Razza()
        {
            string razza = "Golden Retriever";
            return razza;
        }
        public override void Abbaio()
        {
            SoundPlayer sound = new SoundPlayer(Path.GetDirectoryName(Application.ExecutablePath) + @"\rsc\audio\GoldenRetriever.wav");
            sound.Play();
        }
        public override void OrecchieLunghe(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\GoldenRetrieverConOrecchieLunghe.png");
        }
        public override void CodaLunga(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\GoldenRetrieverConCodaLunga.png");
        }
        public override void Tutto(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\GoldenRetrieverConTutto.png");
        }
        public override void Criniera(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\GoldenRetrieverCriniera.png");
        }
        public override void CodeOl(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\GoldenRetrieverCod_Ore.png");
        }
        public override void CodeCri(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\GoldenRetrieverCod_Crin.png");
        }
        public override void OreCri(PictureBox picture)
        {
            picture.BackgroundImage = new Bitmap(DirImgs + @"\img\cane\GoldenRetrieverOre_Crin.png");
        }
        





    }
}
