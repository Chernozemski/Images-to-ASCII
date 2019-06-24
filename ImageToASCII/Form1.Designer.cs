namespace ImageToASCII
{
    partial class Form1
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
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnImportImg = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnToASCII = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBox
            // 
            this.imgBox.BackColor = System.Drawing.Color.SlateGray;
            this.imgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBox.Location = new System.Drawing.Point(12, 12);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(255, 243);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBox.TabIndex = 0;
            this.imgBox.TabStop = false;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 258);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(35, 13);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "label1";
            this.lblPath.Visible = false;
            // 
            // btnImportImg
            // 
            this.btnImportImg.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnImportImg.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnImportImg.Location = new System.Drawing.Point(273, 12);
            this.btnImportImg.Name = "btnImportImg";
            this.btnImportImg.Size = new System.Drawing.Size(100, 50);
            this.btnImportImg.TabIndex = 3;
            this.btnImportImg.Text = "Import";
            this.btnImportImg.UseVisualStyleBackColor = false;
            this.btnImportImg.Click += new System.EventHandler(this.btnImportImg_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnFolder.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFolder.Location = new System.Drawing.Point(273, 205);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFolder.Size = new System.Drawing.Size(100, 50);
            this.btnFolder.TabIndex = 4;
            this.btnFolder.Text = "Goto Folder";
            this.btnFolder.UseVisualStyleBackColor = false;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnToASCII
            // 
            this.btnToASCII.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnToASCII.Enabled = false;
            this.btnToASCII.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnToASCII.Location = new System.Drawing.Point(273, 114);
            this.btnToASCII.Name = "btnToASCII";
            this.btnToASCII.Size = new System.Drawing.Size(100, 50);
            this.btnToASCII.TabIndex = 5;
            this.btnToASCII.Text = "To ASCII";
            this.btnToASCII.UseVisualStyleBackColor = false;
            this.btnToASCII.Click += new System.EventHandler(this.btnToASCII_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(383, 277);
            this.Controls.Add(this.btnToASCII);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnImportImg);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.imgBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Image To ASCII Converter";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnImportImg;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnToASCII;
    }
}

