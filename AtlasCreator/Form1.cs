using AtlasCreator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtlasCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region EventHandler UI elements
            //this.pic1.DoubleClick += new System.EventHandler(@ManageSetting.PictureBoxLoadImage);
            //this.pic2.DoubleClick += new System.EventHandler(@ManageSetting.PictureBoxLoadImage);
            //this.pic3.DoubleClick += new System.EventHandler(@ManageSetting.PictureBoxLoadImage);
            //this.pic4.DoubleClick += new System.EventHandler(@ManageSetting.PictureBoxLoadImage);

            this.rbPicNone.CheckedChanged += new System.EventHandler(@ManageSetting.RadioButtonCheaked);
            this.rbPicTile.CheckedChanged += new System.EventHandler(@ManageSetting.RadioButtonCheaked);
            this.rbPicCenter.CheckedChanged += new System.EventHandler(@ManageSetting.RadioButtonCheaked);
            this.rbPicStretch.CheckedChanged += new System.EventHandler(@ManageSetting.RadioButtonCheaked);
            this.rbPicZoom.CheckedChanged += new System.EventHandler(@ManageSetting.RadioButtonCheaked);

            //cbAtlasSize.SelectedValueChanged += (s, a) => { _AtlasSize = int.Parse(cbAtlasSize.SelectedItem.ToString()); CreateAtlasPicture();};

            tsbAddPic.Click += TsbAddPic_Click;
            tsbDeleteAllPic.Click += TsbDeleteAllPic_Click;
            tsbDeleteOnePic.Click += TsbDeleteOnePic_Click;
            tsbAnchor.Click += TsbAnchor_Click;

            tmrRefresh.Start();

            #endregion
        }


        private int CountTexture = 0;

        private void TsbAnchor_Click(object sender, EventArgs e)
        {
            int CountElements = PanelPictureAtlas.Controls.OfType<Control>().Count();
            int WidthElements = 0;  //Ширина элементов
            int HeightElements = 0; //высота элементов


            for (int i = 0; i < PanelPictureAtlas.Controls.OfType<Control>().Count(); i++)
            {
                WidthElements += PanelPictureAtlas.Controls.OfType<Control>().ElementAt(i).Width;

                var CurrentElement = PanelPictureAtlas.Controls.OfType<Control>().ElementAt(i); //текущий элемент

                if (i != 0)
                {
                    if (WidthElements < PanelPictureAtlas.Size.Width) //Пока ширина всех элементов меньше размера панели то добавляем элементы в линию
                    {
                        var PreElement = PanelPictureAtlas.Controls.OfType<Control>().ElementAt(i - 1); //Предыдущий элемент

                        HeightElements = PreElement.Location.Y; 
                        
                        CurrentElement.Location = new Point(PreElement.Location.X + PreElement.Width, HeightElements);

                    }
                    else
                    {
                        WidthElements = CurrentElement.Width;

                        HeightElements = PanelPictureAtlas.Controls.OfType<Control>().ElementAt(i - 1).Location.Y + PanelPictureAtlas.Controls.OfType<Control>().ElementAt(i - 1).Height;
                        CurrentElement.Location = new Point(0, HeightElements);
                    }
                    
                }
                else
                {
                    PanelPictureAtlas.Controls.OfType<Control>().ElementAt(i).Location = new Point(0, 0);
                }

                


                #region Устаревший блок кода "Содержит ошибки"
                //foreach (Control item in PanelPictureAtlas.Controls.OfType<Control>())
                //{
                //    WidthElements += item.Width;


                //   if (item.Name == "PicBox_0" && item.Location != new Point(0, 0))
                //    {
                //        item.Location = new Point(0, 0);
                //        PreLocationX = 0;
                //        PreLocationY = 0;
                //    }
                //   else
                //    {
                //        //Проверяем сколько у нас есть ещё PicBox и ставим каждую к краю другой

                //        //var PreElement = PanelPictureAtlas.Controls.OfType<Control>().ElementAt(Data.IDControl - 2);
                //        //var curElement = PanelPictureAtlas.Controls.OfType<Control>().ElementAt(Data.IDControl - 1);

                //        //if (PanelPictureAtlas.Size.Width > WidthElements)
                //        //{
                //        //    curElement.Location = new Point(PreElement.Location.X + PreElement.Width, HeightElements);
                //        //}
                //        //else
                //        //{
                //        //    HeightElements = PanelPictureAtlas.Controls.OfType<Control>().FirstOrDefault().Height;
                //        //    curElement.Location = new Point(PanelPictureAtlas.Controls.OfType<Control>().FirstOrDefault().Location.X, HeightElements);
                //        //}
                //        //item.Location = new Point(PreElement.Location.X + PreElement.Width, PreElement.Location.Y + PreElement.Height);
                //        //}
                //    }
                //if (item.Name == "PicBox_" + (Data.IDControl - 1))
                //{

                //}
                #endregion
            }
            
        }

        private void TsbDeleteOnePic_Click(object sender, EventArgs e)
        {
            CountTexture--;
            foreach (Control item in PanelPictureAtlas.Controls.OfType<Control>())
            {
                if (item.Name == "PicBox_" + (Data.IDControl - 1))
                {
                    PanelPictureAtlas.Controls.Remove(item);
                    Data.IDControl--;
                }
            }
            
        }

        private void TsbDeleteAllPic_Click(object sender, EventArgs e)
        {
            CountTexture = 0;
            cbSizeBox.Enabled = true;
            PanelPictureAtlas.Controls.Clear();
            Data.IDControl = 0;
        }

        /// <summary>
        /// Добавление Нового контрола
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsbAddPic_Click(object sender, EventArgs e)
        {
            CountTexture++;

            if (cbLayoutImgPic.SelectedIndex != -1)
            {
                cbSizeBox.Enabled = false;
                if (PanelPictureAtlas.Controls.OfType<Control>().Count() == 0)
                {
                    PanelPictureAtlas.Controls.Add(new ManageSetting().MyNewControls(cbLayoutImgPic.SelectedIndex, ConvertSizeToAtlas(cbSizeBox.SelectedIndex), 10, 10));
                }

                else
                {
                    PanelPictureAtlas.Controls.Add(new ManageSetting().MyNewControls(cbLayoutImgPic.SelectedIndex, ConvertSizeToAtlas(cbSizeBox.SelectedIndex), +10, +10));
                    //TODO : Сделать добавление координат новых текстур со сдвигом в +10 от предыдущего
                }

                Data.IDControl++;
            }
            else { MessageBox.Show("Сначала укажите положение текстуры и размер текстур", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        /// <summary>
        /// Конвертируем размер PicBox чтобы влезло в экран
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        Int32 ConvertSizeToAtlas(int index)
        {
            Int32 i = 0;
            switch(index)
            {
                case 0:
                    i = 420;
                    Data.AtlasTextureSize = 2048;
                    Data.NevelirSeizeKostil = Data.AtlasTextureSize - i;
                    Data.LimitTextures = 4096 / 2048;
                    break;
                case 1:
                    i = 210;
                    Data.AtlasTextureSize = 1024;
                    Data.NevelirSeizeKostil = Data.AtlasTextureSize - i;
                    Data.LimitTextures = 4096 / 1024;
                    break;
                case 2:
                    i = 100;
                    Data.AtlasTextureSize = 512;
                    Data.NevelirSeizeKostil = Data.AtlasTextureSize - i;
                    Data.LimitTextures = 4096 / 512;
                    break;
                case 3:
                    i = 50;
                    Data.AtlasTextureSize = 256;
                    Data.NevelirSeizeKostil = Data.AtlasTextureSize - i;
                    Data.LimitTextures = 4096 / 256;
                    break;
                case 4:
                    i = 25;
                    Data.AtlasTextureSize = 128;
                    Data.NevelirSeizeKostil = Data.AtlasTextureSize - i;
                    Data.LimitTextures = 4096 / 128;
                    break;
                case 5:
                    i = 18;
                    Data.AtlasTextureSize = 64;
                    Data.NevelirSeizeKostil = Data.AtlasTextureSize - i;
                    Data.LimitTextures = 4096 / 64;
                    break;
                case 6:
                    i = 10;
                    Data.AtlasTextureSize = 32;
                    Data.NevelirSeizeKostil = Data.AtlasTextureSize - i;
                    Data.LimitTextures = 4096 / 32;
                    break;
            }
            return i;
        }

        private int _AtlasSize = 0;
        int m_PictureCount = 0;
        int m_step = 8;

        private ManageSetting @ManageSetting { get; set; } = new ManageSetting();


      
        private void CreateImage()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PNG Image|*.png";
            saveFileDialog1.Title = "Укажите название файла";
            saveFileDialog1.ShowDialog();
            int j = 0;
            int k = 0;

            int WidthElements = 0;

            using (Bitmap bmp = new Bitmap(4096, 4096))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    int LocX = 0;
                    int LocY = 0;
                    //узнаём сколько элементов и подставляем значения
                    for (int i = 0; i < PanelPictureAtlas.Controls.OfType<Control>().Count(); i++)
                    {
                        WidthElements += (PanelPictureAtlas.Controls.OfType<Control>().ElementAt(i).Width + Data.NevelirSeizeKostil);
                        //TODO : Сделать правильный подсчёт для текстур в 1к и менее
                        var CurrentsElement = PanelPictureAtlas.Controls.OfType<Control>().ElementAt(i);
                        var PresElement = PanelPictureAtlas.Controls.OfType<Control>().ElementAt(Data.IDControl - 2);

                       

                        if (WidthElements <= 4096)
                        {
                            if (CurrentsElement.Location.X != 0) LocX = CurrentsElement.Location.X + (Data.NevelirSeizeKostil * j);
                            else LocX = CurrentsElement.Location.X;

                            if (CurrentsElement.Location.Y == 0) LocY = 0; //тут ставим в позицию 0

                            j++;
                            
                        }

                        else {
                           
                            k += 1;
                           
                            WidthElements = (PanelPictureAtlas.Controls.OfType<Control>().ElementAt(i).Width + Data.NevelirSeizeKostil);

                            LocX = CurrentsElement.Location.X;
                            
                            LocY = (PresElement.Height + Data.NevelirSeizeKostil) * k;
                            
                            j = 1;
                        }
                       
                        g.DrawImage(CurrentsElement.BackgroundImage, LocX, LocY, Data.AtlasTextureSize, Data.AtlasTextureSize);

                    }

                    try
                    {
                        System.IO.FileStream fs = (FileStream)saveFileDialog1.OpenFile();
                        fs.Close();
                        bmp.Save(fs.Name);
                        MessageBox.Show("Texture created!");
                    }
                    catch { }
                }
            }
        }

        #region Старый метод создания массива контролов
        void CreateAtlasPicture()
        {
            int line = 4096 / _AtlasSize;
            int StepOutLine = line - 1;

            m_PictureCount = line * 2;

            int WHSizeFloor = (int)Math.Floor((double)(PanelPictureAtlas.Width / line) - ((double)(PanelPictureAtlas.Width / line) / 100));
            int WHSizeRound = (int)Math.Round((double)(PanelPictureAtlas.Width / line) - ((double)(PanelPictureAtlas.Width / line) / 100));

            PictureBox[] pb = new PictureBox[m_PictureCount];
            switch(line)
            {
                case 2:
                    for (int p = 0; p < pb.Length; p++ )
                    {
                        if(p != 0)
                        {
                            pb[p] = new PictureBox();
                            pb[p].BorderStyle = BorderStyle.FixedSingle;
                            pb[p].Size = new Size(WHSizeRound, WHSizeRound);

                            if (p > line / 2)
                            {
                                //пока p больше половины
                                pb[p].Location = new Point(m_step + pb[p - 1].Width, 0);
                                PanelPictureAtlas.Controls.Add(pb[p]);
                            }
                            else
                            {
                                pb[p].Location = new Point(m_step + pb[p-1].Width, m_step + pb[p - 1].Width);
                                PanelPictureAtlas.Controls.Add(pb[p]);
                            }
                            //Прибавляем

                        }
                        else
                        {
                            pb[p] = new PictureBox();
                            pb[p].BorderStyle = BorderStyle.FixedSingle;
                            pb[p].Size = new Size(WHSizeRound, WHSizeRound);
                            pb[p].Location = new Point(0,0);
                            PanelPictureAtlas.Controls.Add(pb[p]);
                            //инстим первый pb
                        }
                    }
                    break;
                case 4:
                    break;
                case 8:
                    break;
                case 16:
                    break;
            }
            
        }
        #endregion

        private void bCreateAtlas_Click(object sender, EventArgs e)
        {
            CreateImage();
        }

        /// <summary>
        /// Обновление таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            lCountTexture.Text = $"Количество добавленных текстур : {CountTexture}";
            grBoxControlSetting.Text = "Настройки контрола " + Data.NamePic;
            tbPicLocX.Text = Data.pX.ToString();
            tbPicLocY.Text = Data.pY.ToString();
            tbSzPicH.Text = Data.AtlasTextureSize.ToString();
            tbSzPicW.Text = Data.AtlasTextureSize.ToString();
        }

        public void DeleteControlInPanel(object sender, EventArgs e)
        {
            PanelPictureAtlas.Controls.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Texture atlas creator v" + Assembly.GetExecutingAssembly().GetName().Version;
            #region Создадим свою кнопку на ToolStrip
            Button button = new Button();
            button.Text = "Создать атлас";
            button.Click += bCreateAtlas_Click;
            button.Image= Resources.image_instagram; button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextAlign = ContentAlignment.MiddleRight; button.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolStrip1.Items.Add(new ToolStripControlHost(button));
            #endregion
        }

    }
}
