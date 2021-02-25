﻿using AtlasCreator.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtlasCreator
{
    /// <summary>
    /// Публичный класс для манипуляций переменных между формами
    /// </summary>
    public static class Data
    {
        public static string NamePic { get; set; }
        public static int IDControl { get; set; } = 0;
        public static int pX { get; set; }
        public static int pY { get; set; }

        public static int AtlasTextureSize { get; set; }

    }
    public  class ManageSetting
    {
        /// <summary>
        /// Метод который помещает в PictureBox Выбранную картинку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PictureBoxLoadImage(object sender, EventArgs e)
        {
            (sender as PictureBox).BackgroundImage = Texture();
        }

        /// <summary>
        /// Текстура которую мы выбираем при открытии
        /// </summary>
        /// <returns>Возвращаем текстуру которую выбрали</returns>
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


        /// <summary>
        /// Метод создания 4К текстуры
        /// </summary>
        /// <param name="AtlasSize"></param>
        /// <param name="PicImgSize"></param>
        private void CreateImage4k(int AtlasSize, int PicImgSize)
        {
            using (Bitmap bmp = new Bitmap(AtlasSize, AtlasSize))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    //TODO : доделать входные параметры, а так же доделать метод до реализации
                    //g.DrawImage(pic1.Image, 0, 0, 2048, 2048);
                    //g.DrawImage(pic2.Image, 2048, 0, 2048, 2048);
                    //g.DrawImage(pic3.Image, 0, 2048, 2048, 2048);
                    //g.DrawImage(pic4.Image, 2048, 2048, 2048, 2048);
                    //bmp.Save(@"test.png");
                }
            }
        }

        #region Устаревший метод который искал на Form1 все контролы PicBox и выполнял действия
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
        #endregion

        #region Устаревший метод который делал манипуляции со всеми PicBox сразу
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

        #endregion

        /// <summary>
        /// Сам Динамический контрол. Возвращаемы метод который создаёт контрол с выбранным положением Image и размером
        /// </summary>
        /// <param name="Layout"></param>
        /// <param name="SizeBox"></param>
        /// <returns>Готовый контрол</returns>
        public Control MyNewControls(int Layout, int SizeBox)
        {
            PictureBox pic = new PictureBox();
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.Location = new Point(10, 10);
            pic.Size = new Size(SizeBox, SizeBox);
            pic.BackgroundImage = Resources.NoTexture;
            pic.Name = "PicBox_" + Data.IDControl;
            
            //События динамического контрола
            pic.MouseDown += Pic_MouseDown;
            pic.MouseUp += Pic_MouseUp;
            pic.MouseMove += Pic_MouseMove;
            pic.MouseClick += Pic_MouseClick;
            pic.DoubleClick += PictureBoxLoadImage;
            pic.BackgroundImageLayout = iLayout(Layout);

            return pic;
        }

        /// <summary>
        /// Вызов контекстного меню при нажатии правой клавиши мыши на контроле
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip cms = new ContextMenuStrip();
                cms.Items.Add("Удалить элемент");
                cms.Items[0].Click += ManageSetting_Click;
                cms.Show((sender as PictureBox), new Point(0 , 10));
            }
        }

        /// <summary>
        /// метод при клике на контекстное меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageSetting_Click(object sender, EventArgs e)
        {
            foreach (var panel in new Form1().Controls.OfType<Panel>())
            {
                MessageBox.Show(panel.Name);
                foreach (var pb in panel.Controls.OfType<PictureBox>())
                    MessageBox.Show(pb.Name);
            }
        }

        /// <summary>
        /// из ImageLayout в INTEGER
        /// </summary>
        /// <param name="Layout"></param>
        /// <returns>Возвратим положение картинки в PictureBox</returns>
        public ImageLayout iLayout(int Layout)
        {
              return (ImageLayout)Layout;
        }


        #region Манипуляции PictureBox при перетаскивании
        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked)
            {
                Point p = new Point(); // New Coordinate
                p.X = e.X + (sender as PictureBox).Left;
                p.Y = e.Y + (sender as PictureBox).Top;
                (sender as PictureBox).Left = p.X;
                (sender as PictureBox).Top = p.Y;
                Data.pX = p.X;
                Data.pY = p.Y;
                Data.AtlasTextureSize = (sender as PictureBox).Width;
                Data.NamePic = (sender as PictureBox).Name;
            }
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Point p = ConvertFromChildToForm(e.X, e.Y, (sender as PictureBox));
                //(sender as PictureBox).Left = p.X;
                //(sender as PictureBox).Top = p.Y;
                //(sender as PictureBox).Left = e.X;
                //(sender as PictureBox).Top = e.Y;
                clicked = true;
            }
        }

        private bool clicked;

        private Point ConvertFromChildToForm(int x, int y, Control control)
        {
            Point p = new Point(x, y);
            control.Location = p;
            return p;
        }
        #endregion
    }
}
