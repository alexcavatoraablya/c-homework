namespace ListViewImageView
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
            myLv = new ListView();
            txtbFolder = new TextBox();
            SuspendLayout();
            // 
            // myLv
            // 
            myLv.Location = new Point(12, 48);
            myLv.Name = "myLv";
            myLv.Size = new Size(798, 485);
            myLv.TabIndex = 0;
            myLv.UseCompatibleStateImageBehavior = false;
            // 
            // txtbFolder
            // 
            txtbFolder.Location = new Point(12, 19);
            txtbFolder.Name = "txtbFolder";
            txtbFolder.Size = new Size(210, 23);
            txtbFolder.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 545);
            Controls.Add(txtbFolder);
            Controls.Add(myLv);
            Name = "MainForm";
            Text = "Файловий провідник";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView myLv;
        private TextBox txtbFolder;
    }
}
