using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace RoboDog
{
    public partial class CambiaColore : Form
    {
        Principale ObjPrincipale;
        public CambiaColore(Principale _principale)
        {
            InitializeComponent();
            ObjPrincipale = _principale;

        }

        private void SelectedColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            RedSelection.Value = colorDialog1.Color.R;
            GreenSelection.Value = colorDialog1.Color.G;
            BlueSelection.Value = colorDialog1.Color.B;
            SelectedColor.BackColor = Color.FromArgb(RedSelection.Value, GreenSelection.Value, BlueSelection.Value);
            ColorPictur();
        }

        private void CambiaColore_Load(object sender, EventArgs e)
        {
            picOriginal.BackgroundImage = ObjPrincipale.picDog.BackgroundImage;
            RedSelection.Value = 128;
            GreenSelection.Value = 128;
            BlueSelection.Value = 128;
            BrightnessSelection.Value = 264;
            SelectedColor.BackColor = Color.FromArgb(RedSelection.Value, GreenSelection.Value, BlueSelection.Value);
            ColorPictur();
        }
        private void scrColorComponent_Scroll(object sender, ScrollEventArgs e)
        {
            //redrawing & adjusting the selected color
            SelectedColor.BackColor = Color.FromArgb(RedSelection.Value, GreenSelection.Value, BlueSelection.Value);
            ColorPictur();
        }
        private void ColorPictur()
        {
            //applyig color
            picToned.BackgroundImage = ToColorTone(picOriginal.BackgroundImage, SelectedColor.BackColor);
        }
        private Bitmap ToColorTone(Image image, Color color)
        {
            //creating a new bitmap image with selected color.
            float scale = BrightnessSelection.Value / 128f;

            float r = color.R / 255f * scale;
            float g = color.G / 255f * scale;
            float b = color.B / 255f * scale;

            // Color Matrix
            ColorMatrix cm = new ColorMatrix(new float[][]
            {
                new float[] {r, 0, 0, 0, 0},
                new float[] {0, g, 0, 0, 0},
                new float[] {0, 0, b, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            });
            ImageAttributes ImAttribute = new ImageAttributes();
            ImAttribute.SetColorMatrix(cm);

            //Color Matrix on new bitmap image
            Point[] points =
            {
                new Point(0, 0),
                new Point(image.Width - 1, 0),
                new Point(0, image.Height - 1),
            };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            Bitmap myBitmap = new Bitmap(image.Width, image.Height);
            using (Graphics graphics = Graphics.FromImage(myBitmap))
            {
                graphics.DrawImage(image, points, rect, GraphicsUnit.Pixel, ImAttribute);
            }
            return myBitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObjPrincipale.ObjCane.AggPic(picToned);
            ObjPrincipale.picDog.BackgroundImage = ObjPrincipale.ObjCane.PicModificata.BackgroundImage;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                Controllo();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
                Controllo();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
                Controllo();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
                Controllo();
        }
        public void Controllo()
        {
            if ((chckBxCoda.Checked) && (chckBxOrecchie.Checked) && (chckBxCriniera.Checked))
            {
                ObjPrincipale.ObjCane.Tutto(picOriginal);
            }
            else
            {
                if (chckBxCoda.Checked && chckBxOrecchie.Checked)
                {
                    ObjPrincipale.ObjCane.CodeOl(picOriginal);
                }
                else
                {
                    if (chckBxCoda.Checked && chckBxCriniera.Checked)
                    {
                        ObjPrincipale.ObjCane.CodeCri(picOriginal);
                    }
                    else
                    {
                        if (chckBxOrecchie.Checked && chckBxCriniera.Checked)
                        {
                            ObjPrincipale.ObjCane.OreCri(picOriginal);
                        }
                        else
                        {
                            if (chckBxCoda.Checked)
                            {
                                ObjPrincipale.ObjCane.CodaLunga(picOriginal);
                            }
                            else
                            {
                                if (chckBxOrecchie.Checked)
                                {
                                    ObjPrincipale.ObjCane.OrecchieLunghe(picOriginal);
                                }
                                else
                                {
                                    if (chckBxCriniera.Checked)
                                    {
                                        ObjPrincipale.ObjCane.Criniera(picOriginal);
                                    }
                                    else
                                    {
                                        picOriginal.BackgroundImage = ObjPrincipale.picDog.BackgroundImage;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            SelectedColor.BackColor = Color.FromArgb(RedSelection.Value, GreenSelection.Value, BlueSelection.Value);
            ColorPictur();
        }
    }              
}
