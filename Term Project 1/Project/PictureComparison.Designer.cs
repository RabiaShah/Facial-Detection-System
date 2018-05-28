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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureComparison));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFound = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.pbCapturedImg = new Emgu.CV.UI.ImageBox();
            this.pbDBImg = new Emgu.CV.UI.ImageBox();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
            this.timerForColor = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturedImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDBImg)).BeginInit();
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
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.BackColor = System.Drawing.Color.Transparent;
            this.lblFound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFound.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFound.ForeColor = System.Drawing.Color.Turquoise;
            this.lblFound.Location = new System.Drawing.Point(331, 20);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(577, 34);
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
            this.btnDetails.Location = new System.Drawing.Point(395, 519);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(158, 48);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Text = "View Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // pbCapturedImg
            // 
            this.pbCapturedImg.Location = new System.Drawing.Point(219, 82);
            this.pbCapturedImg.Name = "pbCapturedImg";
            this.pbCapturedImg.Size = new System.Drawing.Size(266, 204);
            this.pbCapturedImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCapturedImg.TabIndex = 2;
            this.pbCapturedImg.TabStop = false;
            // 
            // pbDBImg
            // 
            this.pbDBImg.Location = new System.Drawing.Point(491, 82);
            this.pbDBImg.Name = "pbDBImg";
            this.pbDBImg.Size = new System.Drawing.Size(266, 204);
            this.pbDBImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDBImg.TabIndex = 6;
            this.pbDBImg.TabStop = false;
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(219, 292);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(270, 174);
            this.histogramBox1.TabIndex = 7;
            // 
            // histogramBox2
            // 
            this.histogramBox2.Location = new System.Drawing.Point(495, 292);
            this.histogramBox2.Name = "histogramBox2";
            this.histogramBox2.Size = new System.Drawing.Size(270, 174);
            this.histogramBox2.TabIndex = 8;
            // 
            // timerForColor
            // 
            this.timerForColor.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PictureComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(920, 579);
            this.Controls.Add(this.histogramBox2);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.pbDBImg);
            this.Controls.Add(this.pbCapturedImg);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblFound);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PictureComparison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureComparison";
            this.Load += new System.EventHandler(this.PictureComparison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturedImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDBImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFound;
        private System.Windows.Forms.Button btnDetails;
        private Emgu.CV.UI.ImageBox pbCapturedImg;
        private Emgu.CV.UI.ImageBox pbDBImg;
        public Emgu.CV.UI.HistogramBox histogramBox1;
        public Emgu.CV.UI.HistogramBox histogramBox2;
        private System.Windows.Forms.Timer timerForColor;
    }
}