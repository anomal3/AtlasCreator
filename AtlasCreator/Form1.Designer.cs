namespace AtlasCreator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPicZoom = new System.Windows.Forms.RadioButton();
            this.rbPicStretch = new System.Windows.Forms.RadioButton();
            this.rbPicCenter = new System.Windows.Forms.RadioButton();
            this.rbPicTile = new System.Windows.Forms.RadioButton();
            this.rbPicNone = new System.Windows.Forms.RadioButton();
            this.PanelPictureAtlas = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddPic = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteOnePic = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteAllPic = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAnchor = new System.Windows.Forms.ToolStripButton();
            this.cbLayoutImgPic = new System.Windows.Forms.ComboBox();
            this.grBoxControlSetting = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSzPicW = new System.Windows.Forms.TextBox();
            this.tbPicLocY = new System.Windows.Forms.TextBox();
            this.tbSzPicH = new System.Windows.Forms.TextBox();
            this.tbPicLocX = new System.Windows.Forms.TextBox();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.cbSizeBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grBoxControlSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPicZoom);
            this.groupBox1.Controls.Add(this.rbPicStretch);
            this.groupBox1.Controls.Add(this.rbPicCenter);
            this.groupBox1.Controls.Add(this.rbPicTile);
            this.groupBox1.Controls.Add(this.rbPicNone);
            this.groupBox1.Location = new System.Drawing.Point(872, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 154);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки отображения PicBox";
            // 
            // rbPicZoom
            // 
            this.rbPicZoom.AutoSize = true;
            this.rbPicZoom.Location = new System.Drawing.Point(7, 112);
            this.rbPicZoom.Name = "rbPicZoom";
            this.rbPicZoom.Size = new System.Drawing.Size(145, 30);
            this.rbPicZoom.TabIndex = 0;
            this.rbPicZoom.TabStop = true;
            this.rbPicZoom.Tag = "zoom";
            this.rbPicZoom.Text = "Подогнать под размер\r\n(Zoom) - рекомендуется";
            this.rbPicZoom.UseVisualStyleBackColor = true;
            // 
            // rbPicStretch
            // 
            this.rbPicStretch.AutoSize = true;
            this.rbPicStretch.Location = new System.Drawing.Point(6, 89);
            this.rbPicStretch.Name = "rbPicStretch";
            this.rbPicStretch.Size = new System.Drawing.Size(77, 17);
            this.rbPicStretch.TabIndex = 0;
            this.rbPicStretch.TabStop = true;
            this.rbPicStretch.Tag = "stretch";
            this.rbPicStretch.Text = "Растянуть";
            this.rbPicStretch.UseVisualStyleBackColor = true;
            // 
            // rbPicCenter
            // 
            this.rbPicCenter.AutoSize = true;
            this.rbPicCenter.Location = new System.Drawing.Point(7, 66);
            this.rbPicCenter.Name = "rbPicCenter";
            this.rbPicCenter.Size = new System.Drawing.Size(97, 17);
            this.rbPicCenter.TabIndex = 0;
            this.rbPicCenter.TabStop = true;
            this.rbPicCenter.Tag = "center";
            this.rbPicCenter.Text = "Центрировать";
            this.rbPicCenter.UseVisualStyleBackColor = true;
            // 
            // rbPicTile
            // 
            this.rbPicTile.AutoSize = true;
            this.rbPicTile.Location = new System.Drawing.Point(7, 43);
            this.rbPicTile.Name = "rbPicTile";
            this.rbPicTile.Size = new System.Drawing.Size(106, 17);
            this.rbPicTile.TabIndex = 0;
            this.rbPicTile.TabStop = true;
            this.rbPicTile.Tag = "tile";
            this.rbPicTile.Text = "Замостить (Tile)";
            this.rbPicTile.UseVisualStyleBackColor = true;
            // 
            // rbPicNone
            // 
            this.rbPicNone.AutoSize = true;
            this.rbPicNone.Location = new System.Drawing.Point(7, 20);
            this.rbPicNone.Name = "rbPicNone";
            this.rbPicNone.Size = new System.Drawing.Size(56, 17);
            this.rbPicNone.TabIndex = 0;
            this.rbPicNone.TabStop = true;
            this.rbPicNone.Tag = "none";
            this.rbPicNone.Text = "NONE";
            this.rbPicNone.UseVisualStyleBackColor = true;
            // 
            // PanelPictureAtlas
            // 
            this.PanelPictureAtlas.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PanelPictureAtlas.Location = new System.Drawing.Point(0, 34);
            this.PanelPictureAtlas.Name = "PanelPictureAtlas";
            this.PanelPictureAtlas.Size = new System.Drawing.Size(860, 860);
            this.PanelPictureAtlas.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddPic,
            this.tsbDeleteOnePic,
            this.tsbDeleteAllPic,
            this.toolStripSeparator1,
            this.tsbAnchor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1259, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddPic
            // 
            this.tsbAddPic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddPic.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddPic.Image")));
            this.tsbAddPic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddPic.Name = "tsbAddPic";
            this.tsbAddPic.Size = new System.Drawing.Size(23, 22);
            this.tsbAddPic.Text = "toolStripButton1";
            this.tsbAddPic.ToolTipText = "Добавить картинку";
            // 
            // tsbDeleteOnePic
            // 
            this.tsbDeleteOnePic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteOnePic.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteOnePic.Image")));
            this.tsbDeleteOnePic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteOnePic.Name = "tsbDeleteOnePic";
            this.tsbDeleteOnePic.Size = new System.Drawing.Size(23, 22);
            this.tsbDeleteOnePic.Text = "toolStripButton1";
            this.tsbDeleteOnePic.ToolTipText = "Удалить последний элемент";
            // 
            // tsbDeleteAllPic
            // 
            this.tsbDeleteAllPic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteAllPic.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteAllPic.Image")));
            this.tsbDeleteAllPic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteAllPic.Name = "tsbDeleteAllPic";
            this.tsbDeleteAllPic.Size = new System.Drawing.Size(23, 22);
            this.tsbDeleteAllPic.Text = "toolStripButton2";
            this.tsbDeleteAllPic.ToolTipText = "Удалить все элементы";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAnchor
            // 
            this.tsbAnchor.AutoSize = false;
            this.tsbAnchor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAnchor.Image = ((System.Drawing.Image)(resources.GetObject("tsbAnchor.Image")));
            this.tsbAnchor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnchor.Name = "tsbAnchor";
            this.tsbAnchor.RightToLeftAutoMirrorImage = true;
            this.tsbAnchor.Size = new System.Drawing.Size(23, 22);
            this.tsbAnchor.Text = "toolStripButton1";
            this.tsbAnchor.ToolTipText = "Выровнять все элементы \r\nпо отношению к последнему";
            // 
            // cbLayoutImgPic
            // 
            this.cbLayoutImgPic.FormattingEnabled = true;
            this.cbLayoutImgPic.Items.AddRange(new object[] {
            "NONE",
            "Замостить (Tile)",
            "Центрировать",
            "Растянуть",
            "Zoom"});
            this.cbLayoutImgPic.Location = new System.Drawing.Point(869, 69);
            this.cbLayoutImgPic.Name = "cbLayoutImgPic";
            this.cbLayoutImgPic.Size = new System.Drawing.Size(201, 21);
            this.cbLayoutImgPic.TabIndex = 6;
            // 
            // grBoxControlSetting
            // 
            this.grBoxControlSetting.Controls.Add(this.label6);
            this.grBoxControlSetting.Controls.Add(this.label5);
            this.grBoxControlSetting.Controls.Add(this.label4);
            this.grBoxControlSetting.Controls.Add(this.label3);
            this.grBoxControlSetting.Controls.Add(this.label2);
            this.grBoxControlSetting.Controls.Add(this.label1);
            this.grBoxControlSetting.Controls.Add(this.tbSzPicW);
            this.grBoxControlSetting.Controls.Add(this.tbPicLocY);
            this.grBoxControlSetting.Controls.Add(this.tbSzPicH);
            this.grBoxControlSetting.Controls.Add(this.tbPicLocX);
            this.grBoxControlSetting.Location = new System.Drawing.Point(869, 96);
            this.grBoxControlSetting.Name = "grBoxControlSetting";
            this.grBoxControlSetting.Size = new System.Drawing.Size(360, 115);
            this.grBoxControlSetting.TabIndex = 7;
            this.grBoxControlSetting.TabStop = false;
            this.grBoxControlSetting.Text = "Настройки контрола";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "w";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Размер в окне";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Координаты";
            // 
            // tbSzPicW
            // 
            this.tbSzPicW.Location = new System.Drawing.Point(207, 45);
            this.tbSzPicW.Name = "tbSzPicW";
            this.tbSzPicW.Size = new System.Drawing.Size(67, 20);
            this.tbSzPicW.TabIndex = 0;
            // 
            // tbPicLocY
            // 
            this.tbPicLocY.Location = new System.Drawing.Point(207, 23);
            this.tbPicLocY.Name = "tbPicLocY";
            this.tbPicLocY.Size = new System.Drawing.Size(67, 20);
            this.tbPicLocY.TabIndex = 0;
            // 
            // tbSzPicH
            // 
            this.tbSzPicH.Location = new System.Drawing.Point(105, 45);
            this.tbSzPicH.Name = "tbSzPicH";
            this.tbSzPicH.Size = new System.Drawing.Size(67, 20);
            this.tbSzPicH.TabIndex = 0;
            // 
            // tbPicLocX
            // 
            this.tbPicLocX.Location = new System.Drawing.Point(105, 23);
            this.tbPicLocX.Name = "tbPicLocX";
            this.tbPicLocX.Size = new System.Drawing.Size(67, 20);
            this.tbPicLocX.TabIndex = 0;
            this.tbPicLocX.Tag = "tbPicLocX";
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // cbSizeBox
            // 
            this.cbSizeBox.FormattingEnabled = true;
            this.cbSizeBox.Items.AddRange(new object[] {
            "2048",
            "1024",
            "512",
            "256",
            "128",
            "64",
            "32"});
            this.cbSizeBox.Location = new System.Drawing.Point(1096, 69);
            this.cbSizeBox.Name = "cbSizeBox";
            this.cbSizeBox.Size = new System.Drawing.Size(133, 21);
            this.cbSizeBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(866, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Положение текущей текстуры";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1093, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Размер текстур";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 906);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbSizeBox);
            this.Controls.Add(this.grBoxControlSetting);
            this.Controls.Add(this.cbLayoutImgPic);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PanelPictureAtlas);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1275, 945);
            this.MinimumSize = new System.Drawing.Size(1275, 945);
            this.Name = "Form1";
            this.Text = "Texture atlas creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grBoxControlSetting.ResumeLayout(false);
            this.grBoxControlSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPicZoom;
        private System.Windows.Forms.RadioButton rbPicStretch;
        private System.Windows.Forms.RadioButton rbPicCenter;
        private System.Windows.Forms.RadioButton rbPicTile;
        private System.Windows.Forms.RadioButton rbPicNone;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddPic;
        private System.Windows.Forms.ComboBox cbLayoutImgPic;
        private System.Windows.Forms.GroupBox grBoxControlSetting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSzPicW;
        private System.Windows.Forms.TextBox tbPicLocY;
        private System.Windows.Forms.TextBox tbSzPicH;
        public System.Windows.Forms.TextBox tbPicLocX;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.ComboBox cbSizeBox;
        public System.Windows.Forms.Panel PanelPictureAtlas;
        private System.Windows.Forms.ToolStripButton tsbDeleteOnePic;
        private System.Windows.Forms.ToolStripButton tsbDeleteAllPic;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAnchor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

