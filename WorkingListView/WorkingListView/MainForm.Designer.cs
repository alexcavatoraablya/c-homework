namespace WorkingListView
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
            ListViewItem listViewItem1 = new ListViewItem("Мої файли");
            ListViewItem listViewItem2 = new ListViewItem("Документи");
            label1 = new Label();
            mylistView = new ListView();
            btnAdd = new Button();
            cbDrivers = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(231, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 30);
            label1.TabIndex = 1;
            label1.Text = "Файлова система";
            // 
            // mylistView
            // 
            mylistView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            mylistView.Location = new Point(12, 54);
            mylistView.Name = "mylistView";
            mylistView.Size = new Size(639, 384);
            mylistView.TabIndex = 2;
            mylistView.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 39);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbDrivers
            // 
            cbDrivers.FormattingEnabled = true;
            cbDrivers.Location = new Point(486, 18);
            cbDrivers.Name = "cbDrivers";
            cbDrivers.Size = new Size(165, 23);
            cbDrivers.TabIndex = 4;
            cbDrivers.SelectedIndexChanged += cbDrivers_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 450);
            Controls.Add(cbDrivers);
            Controls.Add(btnAdd);
            Controls.Add(mylistView);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Відображення ListView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListView mylistView;
        private Button btnAdd;
        private ComboBox cbDrivers;
    }
}
