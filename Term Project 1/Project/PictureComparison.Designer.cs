namespace Project
{
    partial class PictureComparison
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureComparison));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbCpaturedImg = new System.Windows.Forms.PictureBox();
            this.pbDBImage = new System.Windows.Forms.PictureBox();
            this.lblFound = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCpaturedImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbCpaturedImg
            // 
            this.pbCpaturedImg.Location = new System.Drawing.Point(218, 96);
            this.pbCpaturedImg.Name = "pbCpaturedImg";
            this.pbCpaturedImg.Size = new System.Drawing.Size(266, 220);
            this.pbCpaturedImg.TabIndex = 1;
            this.pbCpaturedImg.TabStop = false;

            this.pbCpaturedImg.Click += new System.EventHandler(this.pbCpaturedImg_Click);

            // 
            // pbDBImage
            // 
            this.pbDBImage.Location = new System.Drawing.Point(510, 96);
            this.pbDBImage.Name = "pbDBImage";
            this.pbDBImage.Size = new System.Drawing.Size(266, 220);
            this.pbDBImage.TabIndex = 2;
            this.pbDBImage.TabStop = false;
            this.pbDBImage.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.BackColor = System.Drawing.Color.Transparent;
            this.lblFound.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFound.Location = new System.Drawing.Point(232, 337);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(575, 32);
            this.lblFound.TabIndex = 3;
            this.lblFound.Text = "Match Found/ No Record Found";
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDetails.FlatAppearance.BorderSize = 2;
            this.btnDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDetails.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnDetails.Location = new System.Drawing.Point(442, 388);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(158, 48);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Text = "View Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // PictureComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(920, 487);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblFound);
            this.Controls.Add(this.pbDBImage);
            this.Controls.Add(this.pbCpaturedImg);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PictureComparison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureComparison";
            this.Load += new System.EventHandler(this.PictureComparison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCpaturedImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDBImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbCpaturedImg;
        private System.Windows.Forms.PictureBox pbDBImage;
        private System.Windows.Forms.Label lblFound;
        private System.Windows.Forms.Button btnDetails;
    }
}