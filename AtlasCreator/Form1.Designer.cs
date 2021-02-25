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
            this.bCreateAtlas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPicZoom = new System.Windows.Forms.RadioButton();
            this.rbPicStretch = new System.Windows.Forms.RadioButton();
            this.rbPicCenter = new System.Windows.Forms.RadioButton();
            this.rbPicTile = new System.Windows.Forms.RadioButton();
            this.rbPicNone = new System.Windows.Forms.RadioButton();
            this.PanelPictureAtlas = new System.Windows.Forms.Panel();
            this.cbAtlasSize = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCreateAtlas
            // 
            this.bCreateAtlas.Location = new System.Drawing.Point(1111, 24);
            this.bCreateAtlas.Name = "bCreateAtlas";
            this.bCreateAtlas.Size = new System.Drawing.Size(261, 33);
            this.bCreateAtlas.TabIndex = 1;
            this.bCreateAtlas.Text = "Create_Atlas";
            this.bCreateAtlas.UseVisualStyleBackColor = true;
            this.bCreateAtlas.Click += new System.EventHandler(this.bCreateAtlas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPicZoom);
            this.groupBox1.Controls.Add(this.rbPicStretch);
            this.groupBox1.Controls.Add(this.rbPicCenter);
            this.groupBox1.Controls.Add(this.rbPicTile);
            this.groupBox1.Controls.Add(this.rbPicNone);
            this.groupBox1.Location = new System.Drawing.Point(904, 12);
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
            this.PanelPictureAtlas.Location = new System.Drawing.Point(12, 12);
            this.PanelPictureAtlas.Name = "PanelPictureAtlas";
            this.PanelPictureAtlas.Size = new System.Drawing.Size(880, 880);
            this.PanelPictureAtlas.TabIndex = 3;
            // 
            // cbAtlasSize
            // 
            this.cbAtlasSize.DropDownWidth = 150;
            this.cbAtlasSize.FormattingEnabled = true;
            this.cbAtlasSize.Items.AddRange(new object[] {
            "2048",
            "1024",
            "512",
            "256"});
            this.cbAtlasSize.Location = new System.Drawing.Point(905, 324);
            this.cbAtlasSize.Name = "cbAtlasSize";
            this.cbAtlasSize.Size = new System.Drawing.Size(169, 21);
            this.cbAtlasSize.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 906);
            this.Controls.Add(this.cbAtlasSize);
            this.Controls.Add(this.PanelPictureAtlas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bCreateAtlas);
            this.Name = "Form1";
            this.Text = "Texture atlas creator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bCreateAtlas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPicZoom;
        private System.Windows.Forms.RadioButton rbPicStretch;
        private System.Windows.Forms.RadioButton rbPicCenter;
        private System.Windows.Forms.RadioButton rbPicTile;
        private System.Windows.Forms.RadioButton rbPicNone;
        private System.Windows.Forms.Panel PanelPictureAtlas;
        private System.Windows.Forms.ComboBox cbAtlasSize;
    }
}

