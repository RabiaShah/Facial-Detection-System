namespace Project
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnLiveVideo = new System.Windows.Forms.Button();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.DummyPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DummyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoadImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLoadImage.FlatAppearance.BorderSize = 2;
            this.btnLoadImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLoadImage.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImage.ForeColor = System.Drawing.Color.Aqua;
            this.btnLoadImage.Location = new System.Drawing.Point(267, 381);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(228, 70);
            this.btnLoadImage.TabIndex = 5;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnLiveVideo
            // 
            this.btnLiveVideo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLiveVideo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLiveVideo.FlatAppearance.BorderSize = 2;
            this.btnLiveVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLiveVideo.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiveVideo.ForeColor = System.Drawing.Color.Aqua;
            this.btnLiveVideo.Location = new System.Drawing.Point(544, 381);
            this.btnLiveVideo.Name = "btnLiveVideo";
            this.btnLiveVideo.Size = new System.Drawing.Size(228, 70);
            this.btnLiveVideo.TabIndex = 6;
            this.btnLiveVideo.Text = "Live Video";
            this.btnLiveVideo.UseVisualStyleBackColor = false;
            this.btnLiveVideo.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.BackColor = System.Drawing.Color.Transparent;
            this.DisplayLabel.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLabel.Location = new System.Drawing.Point(251, 104);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(521, 35);
            this.DisplayLabel.TabIndex = 7;
            this.DisplayLabel.Text = "Criminal Face Detection";
            // 
            // DummyPicture
            // 
            this.DummyPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DummyPicture.Image = global::Project.Properties.Resources._104028037688336231789594147054147510527188n;
            this.DummyPicture.Location = new System.Drawing.Point(329, 155);
            this.DummyPicture.Name = "DummyPicture";
            this.DummyPicture.Size = new System.Drawing.Size(359, 202);
            this.DummyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DummyPicture.TabIndex = 8;
            this.DummyPicture.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources._31061468_976249289209152_3606521597940203520_n__1_;
            this.ClientSize = new System.Drawing.Size(920, 487);
            this.Controls.Add(this.DummyPicture);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.btnLiveVideo);
            this.Controls.Add(this.btnLoadImage);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DummyPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnLiveVideo;
        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.PictureBox DummyPicture;
    }
}