using System;
using System.Windows.Forms;
using LibRoboDogs;

namespace RoboDog
{
    public partial class Principale : Form
    {
        public Cane ObjCane = new Cane();
        Form Intro;
        public Principale(Form _intro)
        {
            InitializeComponent();
            Intro = _intro;
        }

        private void barboncino_CheckedChanged(object sender, EventArgs e)
        {
            ObjCane = new Barboncino();
            ObjCane.Immagine(picDog);
        }

        private void bulldog_CheckedChanged(object sender, EventArgs e)
        {
            ObjCane = new Bulldog();
            ObjCane.Immagine(picDog);
        }

        private void goldenretriever_CheckedChanged(object sender, EventArgs e)
        {
            ObjCane = new GoldenRetriever();
            ObjCane.Immagine(picDog);
        }

        private void button1_Click(object sender, EventArgs e)
        {         
        	if((textBox1.Text == "") || (textBox2.Text == ""))
        	{
            	MessageBox.Show("Fill the boxes!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        	}
            else
            {
                try
                {
                    ObjCane.Inserimento(textBox1.Text, Convert.ToInt16(textBox2.Text));
                }
                catch(Exception ecc)
                {
                    MessageBox.Show(ecc.ToString(), "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            	textBox1.Clear();
            	textBox2.Clear();
            }                 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nome.Text = ObjCane.Nome;
            età.Text = Convert.ToString(ObjCane.Età);
            razza.Text = ObjCane.Razza();
            
            ObjCane.Abbaio(); 
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Focus();
            textBox1.Focus();
            barboncino.Select();
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CambiaColore ObjCambiaCOlore = new CambiaColore(this);
            ObjCambiaCOlore.Show();
        }

        private void picDog_Click(object sender, EventArgs e)
        {   

        }

        private void Principale_FormClosed(object sender, FormClosedEventArgs e)
        {
            Intro.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                ObjCane.TipoAbbaio = 1;
            }
            if(comboBox1.SelectedIndex == 1)
            {
                ObjCane.TipoAbbaio = 2;
            }
            if(comboBox1.SelectedIndex == 2)
            {
                ObjCane.TipoAbbaio = 3;
            }
        }
    }
}
