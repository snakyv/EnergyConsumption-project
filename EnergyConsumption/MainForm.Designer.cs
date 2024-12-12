namespace EnergyConsumption
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.apartmentRegisterButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.apartmentSearchButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Energy Consumption Platform";
            // 
            // apartmentRegisterButton
            // 
            this.apartmentRegisterButton.BackColor = System.Drawing.SystemColors.Window;
            this.apartmentRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.apartmentRegisterButton.Location = new System.Drawing.Point(151, 70);
            this.apartmentRegisterButton.Name = "apartmentRegisterButton";
            this.apartmentRegisterButton.Size = new System.Drawing.Size(216, 41);
            this.apartmentRegisterButton.TabIndex = 1;
            this.apartmentRegisterButton.Text = "Apartment Register";
            this.apartmentRegisterButton.UseVisualStyleBackColor = false;
            this.apartmentRegisterButton.Click += new System.EventHandler(this.apartmentRegisterButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.exitButton.Location = new System.Drawing.Point(388, 163);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(92, 34);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // apartmentSearchButton
            // 
            this.apartmentSearchButton.BackColor = System.Drawing.SystemColors.Window;
            this.apartmentSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.apartmentSearchButton.Location = new System.Drawing.Point(151, 117);
            this.apartmentSearchButton.Name = "apartmentSearchButton";
            this.apartmentSearchButton.Size = new System.Drawing.Size(216, 37);
            this.apartmentSearchButton.TabIndex = 6;
            this.apartmentSearchButton.Text = "Apartment Search";
            this.apartmentSearchButton.UseVisualStyleBackColor = false;
            this.apartmentSearchButton.Click += new System.EventHandler(this.apartmentSearchButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.SystemColors.Window;
            this.exportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.exportButton.Location = new System.Drawing.Point(151, 160);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(216, 37);
            this.exportButton.TabIndex = 7;
            this.exportButton.Text = "Export Data to Docx";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 230);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.apartmentSearchButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.apartmentRegisterButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apartmentRegisterButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button apartmentSearchButton;
        private System.Windows.Forms.Button exportButton;
    }
}

