using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Media;
using System.IO;

namespace RoboDog
{
    public class Cane
    {
        public Cane()
        {
            string percorso = Path.GetDirectoryName(Application.ExecutablePath);
            if (Directory.Exists(percorso + @"\rsc"))
            {
                dirImgs = percorso + @"\rsc";
            }
            else
            {
                MessageBox.Show("La cartella con le immagini dei cani non è presente, per favore reinstalla il programma!");
            }
        }
        private string dirImgs;
        public string DirImgs
        {
            get { return dirImgs; }
            set { dirImgs = value; }
        }
        private PictureBox picModificata;
        public PictureBox PicModificata
        {
            get { return picModificata; }
            set { picModificata = value; }
        }
        private int età;
        public int Età
        {
            get
            {
                return età;

            }
            set
            {
                età = value;
            }
        }
        private string nome;
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }     
        public virtual void Abbaio()
        {
            SoundPlayer sound = new SoundPlayer(Path.GetDirectoryName(Application.ExecutablePath) + @"\rsc\audio\cane_Generico.wav");
            sound.Play();
        }
        public virtual void Immagine(PictureBox picture)
        {

        }
        public void Inserimento(string nome,int età)
        {
            this.Nome=nome;
            this.Età=età;
        }
        public virtual string Razza()
        {
            string cane=" razza non selezionata";
            return cane;
        }
        public void AggPic(PictureBox _objPic)
        {
            PicModificata = _objPic;
        }
        public virtual void OrecchieLunghe(PictureBox picture)
        {

        }
        public virtual void CodaLunga(PictureBox picture)
        {

        }
        public virtual void Tutto(PictureBox picture)
        {

        }
        public virtual void Criniera(PictureBox picture)
        {

        }
        public virtual void CodeOl(PictureBox picture)
        {

        }
        public virtual void CodeCri(PictureBox picture)
        {

        }
        public virtual void OreCri(PictureBox picture)
        {

        }
        

    }
}
