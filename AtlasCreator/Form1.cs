using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            cbAtlasSize.SelectedValueChanged += (s, a) => { _AtlasSize = int.Parse(cbAtlasSize.SelectedItem.ToString()); CreateAtlasPicture(); };
            tsbAddPic.Click += TsbAddPic_Click;
            tmrRefresh.Start();

            #endregion
        }

        private void TsbAddPic_Click(object sender, EventArgs e)
        {
            if (cbLayoutImgPic.SelectedIndex != -1)
            PanelPictureAtlas.Controls.Add(new ManageSetting().MyNewControls(cbLayoutImgPic.SelectedIndex, ConvertSizeToAtlas(cbSizeBox.SelectedIndex)));

            Data.IDControl++;
        }

        Int32 ConvertSizeToAtlas(int index)
        {
            Int32 i = 0;
            switch(index)
            {
                case 0:
                    i = 420;
                    Data.AtlasTextureSize = 2048;
                    break;
                case 1:
                    i = 210;
                    Data.AtlasTextureSize = 1024;
                    break;
                case 2:
                    i = 100;
                    Data.AtlasTextureSize = 512;
                    break;
                case 3:
                    i = 50;
                    Data.AtlasTextureSize = 256;
                    break;
                case 4:
                    i = 25;
                    Data.AtlasTextureSize = 128;
                    break;
                case 5:
                    i = 18;
                    Data.AtlasTextureSize = 64;
                    break;
                case 6:
                    i = 10;
                    Data.AtlasTextureSize = 32;
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
            using (Bitmap bmp = new Bitmap(4096, 4096))
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

        private void bCreateAtlas_Click(object sender, EventArgs e)
        {
            CreateImage();
            MessageBox.Show("Texture created!");
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            grBoxControlSetting.Text = "Настройки контрола " + Data.NamePic;
            tbPicLocX.Text = Data.pX.ToString();
            tbPicLocY.Text = Data.pY.ToString();
            tbSzPicH.Text = Data.AtlasTextureSize.ToString();
            tbSzPicW.Text = Data.AtlasTextureSize.ToString();
        }
    }
}
