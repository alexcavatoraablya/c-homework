namespace LoadingImageURL
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbImage = new PictureBox();
            btnLoadUrl = new Button();
            txtbCount = new TextBox();
            btnToFolder = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.Location = new Point(38, 85);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(246, 270);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // btnLoadUrl
            // 
            btnLoadUrl.Location = new Point(305, 124);
            btnLoadUrl.Name = "btnLoadUrl";
            btnLoadUrl.Size = new Size(124, 55);
            btnLoadUrl.TabIndex = 1;
            btnLoadUrl.Text = "button1";
            btnLoadUrl.UseVisualStyleBackColor = true;
            btnLoadUrl.Click += btnLoadUrl_Click;
            // 
            // txtbCount
            // 
            txtbCount.Location = new Point(305, 85);
            txtbCount.Name = "txtbCount";
            txtbCount.Size = new Size(124, 23);
            txtbCount.TabIndex = 2;
            txtbCount.Click += txtbCount_Click;
            // 
            // btnToFolder
            // 
            btnToFolder.Location = new Point(305, 12);
            btnToFolder.Name = "btnToFolder";
            btnToFolder.Size = new Size(75, 23);
            btnToFolder.TabIndex = 3;
            btnToFolder.Text = "У папку";
            btnToFolder.UseVisualStyleBackColor = true;
            btnToFolder.Click += btnToFolder_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 450);
            Controls.Add(btnToFolder);
            Controls.Add(txtbCount);
            Controls.Add(btnLoadUrl);
            Controls.Add(pbImage);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private Button btnLoadUrl;
        private TextBox txtbCount;
        private Button btnToFolder;
    }
}
