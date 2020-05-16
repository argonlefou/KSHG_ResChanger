namespace KSHG_ResChanger
{
    partial class WndMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WndMain));
            this.Btn_Browse = new System.Windows.Forms.Button();
            this.Txt_FilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_ResX = new System.Windows.Forms.TextBox();
            this.Txt_ResY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Patch = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Chk_cursor = new System.Windows.Forms.CheckBox();
            this.Chk_Banner = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Browse
            // 
            this.Btn_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Browse.Location = new System.Drawing.Point(443, 27);
            this.Btn_Browse.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Browse.Name = "Btn_Browse";
            this.Btn_Browse.Size = new System.Drawing.Size(26, 26);
            this.Btn_Browse.TabIndex = 2;
            this.Btn_Browse.Text = "...";
            this.Btn_Browse.UseVisualStyleBackColor = true;
            this.Btn_Browse.Click += new System.EventHandler(this.Btn_Browse_Click);
            // 
            // Txt_FilePath
            // 
            this.Txt_FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_FilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FilePath.Location = new System.Drawing.Point(12, 31);
            this.Txt_FilePath.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_FilePath.Name = "Txt_FilePath";
            this.Txt_FilePath.Size = new System.Drawing.Size(419, 20);
            this.Txt_FilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select your \"KSHG.exe\" or \"KSHG_no_cursor.exe\" :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select your resolution :";
            // 
            // Txt_ResX
            // 
            this.Txt_ResX.Location = new System.Drawing.Point(12, 84);
            this.Txt_ResX.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_ResX.Name = "Txt_ResX";
            this.Txt_ResX.Size = new System.Drawing.Size(60, 22);
            this.Txt_ResX.TabIndex = 4;
            this.Txt_ResX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_ResY
            // 
            this.Txt_ResY.Location = new System.Drawing.Point(95, 84);
            this.Txt_ResY.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_ResY.Name = "Txt_ResY";
            this.Txt_ResY.Size = new System.Drawing.Size(60, 22);
            this.Txt_ResY.TabIndex = 5;
            this.Txt_ResY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "x";
            // 
            // Btn_Patch
            // 
            this.Btn_Patch.Location = new System.Drawing.Point(14, 232);
            this.Btn_Patch.Name = "Btn_Patch";
            this.Btn_Patch.Size = new System.Drawing.Size(456, 37);
            this.Btn_Patch.TabIndex = 7;
            this.Btn_Patch.Text = "Apply Patch";
            this.Btn_Patch.UseVisualStyleBackColor = true;
            this.Btn_Patch.Click += new System.EventHandler(this.Btn_Patch_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(201, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 56);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Chk_cursor);
            this.groupBox1.Controls.Add(this.Chk_Banner);
            this.groupBox1.Location = new System.Drawing.Point(16, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 80);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optionnal :";
            // 
            // Chk_cursor
            // 
            this.Chk_cursor.AutoSize = true;
            this.Chk_cursor.Location = new System.Drawing.Point(6, 47);
            this.Chk_cursor.Name = "Chk_cursor";
            this.Chk_cursor.Size = new System.Drawing.Size(355, 20);
            this.Chk_cursor.TabIndex = 7;
            this.Chk_cursor.Text = "Remove mouse cursor (may depend on your Windows)";
            this.Chk_cursor.UseVisualStyleBackColor = true;
            // 
            // Chk_Banner
            // 
            this.Chk_Banner.AutoSize = true;
            this.Chk_Banner.Location = new System.Drawing.Point(6, 21);
            this.Chk_Banner.Name = "Chk_Banner";
            this.Chk_Banner.Size = new System.Drawing.Size(315, 20);
            this.Chk_Banner.TabIndex = 6;
            this.Chk_Banner.Text = "Remove green message banner on Title Screen";
            this.Chk_Banner.UseVisualStyleBackColor = true;
            // 
            // WndMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Patch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_ResY);
            this.Controls.Add(this.Txt_ResX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_FilePath);
            this.Controls.Add(this.Btn_Browse);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WndMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Silent Hill: The Arcade - Resolution Changer - v2.3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Browse;
        private System.Windows.Forms.TextBox Txt_FilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_ResX;
        private System.Windows.Forms.TextBox Txt_ResY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Patch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Chk_Banner;
        private System.Windows.Forms.CheckBox Chk_cursor;
    }
}

