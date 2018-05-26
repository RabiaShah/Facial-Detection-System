namespace Project
{
    partial class LiveVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiveVideo));
            this.pbVideo = new System.Windows.Forms.PictureBox();
            this.cmbVideoDevices = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.pbCapturedImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturedImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbVideo
            // 
            this.pbVideo.Location = new System.Drawing.Point(208, 79);
            this.pbVideo.Name = "pbVideo";
            this.pbVideo.Size = new System.Drawing.Size(505, 307);
            this.pbVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVideo.TabIndex = 0;
            this.pbVideo.TabStop = false;
            this.pbVideo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmbVideoDevices
            // 
            this.cmbVideoDevices.BackColor = System.Drawing.SystemColors.MenuText;
            this.cmbVideoDevices.ForeColor = System.Drawing.Color.Aqua;
            this.cmbVideoDevices.FormattingEnabled = true;
            this.cmbVideoDevices.Location = new System.Drawing.Point(226, 392);
            this.cmbVideoDevices.Name = "cmbVideoDevices";
            this.cmbVideoDevices.Size = new System.Drawing.Size(212, 21);
            this.cmbVideoDevices.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnStart.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnStart.Location = new System.Drawing.Point(542, 387);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 32);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCapture.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCapture.FlatAppearance.BorderSize = 2;
            this.btnCapture.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCapture.Location = new System.Drawing.Point(629, 388);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(84, 31);
            this.btnCapture.TabIndex = 4;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheck.FlatAppearance.BorderSize = 2;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCheck.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnCheck.Location = new System.Drawing.Point(839, 272);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(81, 32);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // pbCapturedImg
            // 
            this.pbCapturedImg.Location = new System.Drawing.Point(789, 79);
            this.pbCapturedImg.Name = "pbCapturedImg";
            this.pbCapturedImg.Size = new System.Drawing.Size(160, 171);
            this.pbCapturedImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCapturedImg.TabIndex = 3;
            this.pbCapturedImg.TabStop = false;
            // 
            // LiveVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(978, 473);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.pbCapturedImg);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbVideoDevices);
            this.Controls.Add(this.pbVideo);
            this.Name = "LiveVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturedImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbVideo;
        private System.Windows.Forms.ComboBox cmbVideoDevices;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.PictureBox pbCapturedImg;
    }
}

