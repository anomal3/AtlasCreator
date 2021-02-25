using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtlasCreator
{
    public  class ManageSetting
    {

         public  void PictureBoxLoadImage(object sender, EventArgs e)
        {
            (sender as PictureBox).BackgroundImage = Texture();
        }

        public Image Texture()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|jpeg files (*.jpeg)|*.jpeg|TGA files (*.tga)|*.tga|All files (*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return Image.FromFile(ofd.FileName);
                }
                else { MessageBox.Show("Texture not target!"); return null; };
            }
        }

        private void CreateImage4k(int AtlasSize, int PicImgSize)
        {
            using (Bitmap bmp = new Bitmap(AtlasSize, AtlasSize))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {

                    //g.DrawImage(pic1.Image, 0, 0, 2048, 2048);
                    //g.DrawImage(pic2.Image, 2048, 0, 2048, 2048);
                    //g.DrawImage(pic3.Image, 0, 2048, 2048, 2048);
                    //g.DrawImage(pic4.Image, 2048, 2048, 2048, 2048);
                    //bmp.Save(@"test.png");
                }
            }
        }

        public static IEnumerable<T> GetControlsOfType<T>(Control root) where T : Control
        {
            var t = root as T;
            if (t != null)
                yield return t;

            var container = root as ContainerControl;
            if (container != null)
                foreach (Control c in container.Controls)
                    foreach (var i in GetControlsOfType<T>(c))
                        yield return i;
        }


        void PictureBoxImageLayout(ImageLayout layout)
        {
            int ArrayPics = new Form1().Controls.OfType<PictureBox>().Count();

            List<PictureBox> pics = new List<PictureBox>();

            //(Application.OpenForms[0] as Form1).someMethod();

            foreach (var pb in Application.OpenForms[0].Controls.OfType<PictureBox>())
            {
                pics.Add(pb);
            }

            for (int i = 0; i < ArrayPics; i++)
                pics[i].BackgroundImageLayout = layout;
        }


        public void RadioButtonCheaked(object sender, EventArgs e)
        {
            

            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                switch (radioButton.Tag)
                {
                    case "none":
                        PictureBoxImageLayout(ImageLayout.None);
                        break;
                    case "tile":
                        PictureBoxImageLayout(ImageLayout.Tile);
                        break;
                    case "center":
                        PictureBoxImageLayout(ImageLayout.Center);
                        break;
                    case "stretch":
                        PictureBoxImageLayout(ImageLayout.Stretch);
                        break;
                    case "zoom":
                        PictureBoxImageLayout(ImageLayout.Zoom);
                        break;
                    default: break;
                }
            }
        }

    }
}
