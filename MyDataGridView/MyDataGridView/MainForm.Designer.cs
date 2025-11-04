namespace MyDataGridView
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
            components = new System.ComponentModel.Container();
            dgvUsers = new DataGridView();
            label1 = new Label();
            btnAdd = new Button();
            btnRandom = new Button();
            txtbCount = new TextBox();
            imageList1 = new ImageList(components);
            colUserId = new DataGridViewTextBoxColumn();
            colUserPIB = new DataGridViewTextBoxColumn();
            colUserPhone = new DataGridViewTextBoxColumn();
            colUserEmail = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { colUserId, colUserPIB, colUserPhone, colUserEmail });
            dgvUsers.Location = new Point(12, 104);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.Size = new Size(661, 334);
            dgvUsers.TabIndex = 1;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(222, 9);
            label1.Name = "label1";
            label1.Size = new Size(239, 30);
            label1.TabIndex = 0;
            label1.Text = "Список користувачів";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(529, 64);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRandom
            // 
            btnRandom.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRandom.Location = new Point(166, 64);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(144, 34);
            btnRandom.TabIndex = 4;
            btnRandom.Text = "Додати рандом";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // txtbCount
            // 
            txtbCount.Location = new Point(12, 73);
            txtbCount.Name = "txtbCount";
            txtbCount.Size = new Size(148, 23);
            txtbCount.TabIndex = 5;
            txtbCount.TextChanged += txtbCount_TextChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // colUserId
            // 
            colUserId.HeaderText = "Id";
            colUserId.Name = "colUserId";
            colUserId.ReadOnly = true;
            // 
            // colUserPIB
            // 
            colUserPIB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUserPIB.HeaderText = "ПІБ";
            colUserPIB.Name = "colUserPIB";
            colUserPIB.ReadOnly = true;
            // 
            // colUserPhone
            // 
            colUserPhone.HeaderText = "Телефон";
            colUserPhone.Name = "colUserPhone";
            colUserPhone.ReadOnly = true;
            // 
            // colUserEmail
            // 
            colUserEmail.HeaderText = "Пошта";
            colUserEmail.Name = "colUserEmail";
            colUserEmail.ReadOnly = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 450);
            Controls.Add(txtbCount);
            Controls.Add(btnRandom);
            Controls.Add(btnAdd);
            Controls.Add(dgvUsers);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "MainForm";
            Text = "Користувачі";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private Label label1;
        private Button btnAdd;
        private Button btnRandom;
        private TextBox txtbCount;
        private ImageList imageList1;
        private DataGridViewTextBoxColumn colUserId;
        private DataGridViewTextBoxColumn colUserPIB;
        private DataGridViewTextBoxColumn colUserPhone;
        private DataGridViewTextBoxColumn colUserEmail;
    }
}
