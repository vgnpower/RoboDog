using System.Windows.Forms;
using System.Media;
using System.IO;
using System;

namespace LibRoboDogs
{
    public class Cane
    {
        private string dirImgs;
        private string nome;
        private int età;
        private int tipoAbbaio;
        private PictureBox picModificata;

        public string DirImgs
        {
            get { return dirImgs; }
            set { dirImgs = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Età
        {
            get { return età; }
            set { età = value; }
        }
        public int TipoAbbaio
        {
            get { return tipoAbbaio; }
            set { tipoAbbaio = value; }
        }
            
        public PictureBox PicModificata
        {
            get { return picModificata; }
            set { picModificata = value; }
        }

        public Cane()
        {
            nome = "";
            età = 0;
            tipoAbbaio = 1;
            try
            {
                dirImgs = Path.GetDirectoryName(Application.ExecutablePath);
                if (Directory.Exists(dirImgs + @"\rsc"))
                {
                    dirImgs = dirImgs + @"\rsc";
                }
                else
                {
                    MessageBox.Show("La cartella con le immagini dei cani non è presente, per favore reinstalla il programma!");
                }
            }
            catch(Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }
        }

        public virtual void Abbaio()
        {
            try
            {
                SoundPlayer sound = new SoundPlayer(Path.GetDirectoryName(Application.ExecutablePath) + @"\rsc\audio\cane_Generico.wav");
                sound.Play();
            }
            catch (Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }
        }

        public virtual void Immagine(PictureBox picture)
        {

        }

        public void Inserimento(string nome,int età)
        {
            this.Nome = nome;
            this.Età = età;
        }

        public virtual string Razza()
        {
            string cane = " razza non selezionata";
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
