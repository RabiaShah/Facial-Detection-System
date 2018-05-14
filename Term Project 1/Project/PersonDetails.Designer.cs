namespace Project
{
    partial class PersonDetails
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
            this.pbFace = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.grpBoxDetails = new System.Windows.Forms.GroupBox();
            this.lblCrime = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFace)).BeginInit();
            this.grpBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFace
            // 
            this.pbFace.Location = new System.Drawing.Point(225, 108);
            this.pbFace.Name = "pbFace";
            this.pbFace.Size = new System.Drawing.Size(266, 220);
            this.pbFace.TabIndex = 3;
            this.pbFace.TabStop = false;
            this.pbFace.Click += new System.EventHandler(this.pbFace_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Aqua;
            this.lblName.Location = new System.Drawing.Point(20, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 24);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name: ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGender.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Aqua;
            this.lblGender.Location = new System.Drawing.Point(20, 65);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(98, 22);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender: ";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAge.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Aqua;
            this.lblAge.Location = new System.Drawing.Point(20, 106);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(65, 22);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age: ";
            this.lblAge.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNationality.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationality.ForeColor = System.Drawing.Color.Aqua;
            this.lblNationality.Location = new System.Drawing.Point(20, 146);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(153, 22);
            this.lblNationality.TabIndex = 7;
            this.lblNationality.Text = "Nationality: ";
            // 
            // grpBoxDetails
            // 
            this.grpBoxDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxDetails.Controls.Add(this.lblCrime);
            this.grpBoxDetails.Controls.Add(this.lblNationality);
            this.grpBoxDetails.Controls.Add(this.lblName);
            this.grpBoxDetails.Controls.Add(this.lblAge);
            this.grpBoxDetails.Controls.Add(this.lblGender);
            this.grpBoxDetails.Location = new System.Drawing.Point(511, 108);
            this.grpBoxDetails.Name = "grpBoxDetails";
            this.grpBoxDetails.Size = new System.Drawing.Size(268, 240);
            this.grpBoxDetails.TabIndex = 8;
            this.grpBoxDetails.TabStop = false;
            this.grpBoxDetails.Text = "Criminal Details";
            this.grpBoxDetails.Enter += new System.EventHandler(this.grpBoxDetails_Enter);
            // 
            // lblCrime
            // 
            this.lblCrime.AutoSize = true;
            this.lblCrime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCrime.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrime.ForeColor = System.Drawing.Color.Aqua;
            this.lblCrime.Location = new System.Drawing.Point(20, 184);
            this.lblCrime.Name = "lblCrime";
            this.lblCrime.Size = new System.Drawing.Size(87, 22);
            this.lblCrime.TabIndex = 8;
            this.lblCrime.Text = "Crime: ";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMainMenu.FlatAppearance.BorderSize = 2;
            this.btnMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMainMenu.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnMainMenu.Location = new System.Drawing.Point(333, 377);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(158, 48);
            this.btnMainMenu.TabIndex = 9;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnExit.Location = new System.Drawing.Point(497, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 48);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources._31061468_976249289209152_3606521597940203520_n__1_;
            this.ClientSize = new System.Drawing.Size(920, 487);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.grpBoxDetails);
            this.Controls.Add(this.pbFace);
            this.Name = "PersonDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonDetails";
            this.Load += new System.EventHandler(this.PersonDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFace)).EndInit();
            this.grpBoxDetails.ResumeLayout(false);
            this.grpBoxDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFace;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.GroupBox grpBoxDetails;
        private System.Windows.Forms.Label lblCrime;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnExit;
    }
}