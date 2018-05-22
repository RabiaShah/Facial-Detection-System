namespace Project
{
    partial class LoadImg
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblFacesDetected = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.pbBrowsedImage = new Emgu.CV.UI.ImageBox();
            this.pbDetectedFace = new Emgu.CV.UI.ImageBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrowsedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetectedFace)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBrowse.FlatAppearance.BorderSize = 2;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBrowse.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnBrowse.Location = new System.Drawing.Point(231, 356);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(95, 30);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // lblFacesDetected
            // 
            this.lblFacesDetected.AutoSize = true;
            this.lblFacesDetected.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFacesDetected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFacesDetected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFacesDetected.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacesDetected.ForeColor = System.Drawing.Color.Aqua;
            this.lblFacesDetected.Location = new System.Drawing.Point(550, 105);
            this.lblFacesDetected.Name = "lblFacesDetected";
            this.lblFacesDetected.Size = new System.Drawing.Size(155, 24);
            this.lblFacesDetected.TabIndex = 6;
            this.lblFacesDetected.Text = "Face Detected";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheck.FlatAppearance.BorderSize = 2;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCheck.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCheck.Location = new System.Drawing.Point(469, 397);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(154, 46);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Check Record";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbBrowsedImage
            // 
            this.pbBrowsedImage.Location = new System.Drawing.Point(231, 106);
            this.pbBrowsedImage.Name = "pbBrowsedImage";
            this.pbBrowsedImage.Size = new System.Drawing.Size(284, 244);
            this.pbBrowsedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBrowsedImage.TabIndex = 2;
            this.pbBrowsedImage.TabStop = false;
            // 
            // pbDetectedFace
            // 
            this.pbDetectedFace.Location = new System.Drawing.Point(550, 132);
            this.pbDetectedFace.Name = "pbDetectedFace";
            this.pbDetectedFace.Size = new System.Drawing.Size(155, 162);
            this.pbDetectedFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDetectedFace.TabIndex = 2;
            this.pbDetectedFace.TabStop = false;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrev.FlatAppearance.BorderSize = 2;
            this.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPrev.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnPrev.Location = new System.Drawing.Point(550, 300);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(49, 30);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnNext.Location = new System.Drawing.Point(656, 300);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(49, 30);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // LoadImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources._31061468_976249289209152_3606521597940203520_n__1_;
            this.ClientSize = new System.Drawing.Size(947, 487);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.pbDetectedFace);
            this.Controls.Add(this.pbBrowsedImage);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblFacesDetected);
            this.Controls.Add(this.btnBrowse);
            this.Name = "LoadImg";
            this.Text = "Check Record";
            this.Load += new System.EventHandler(this.LoadImg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBrowsedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetectedFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblFacesDetected;
        private System.Windows.Forms.Button btnCheck;
        private Emgu.CV.UI.ImageBox pbBrowsedImage;
        private Emgu.CV.UI.ImageBox pbDetectedFace;

        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;

    }
}