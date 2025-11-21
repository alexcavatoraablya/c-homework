
namespace WinFormsApp2
{
    partial class CreatUserForm
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
            label1 = new Label();
            txtLastName = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            lebal4 = new Label();
            pbImage = new PictureBox();
            txtImage = new TextBox();
            label4 = new Label();
            BtnSalect = new Button();
            button1 = new Button();
            BtnClosed = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 0;
            label1.Text = "Призвіще";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(12, 33);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(240, 29);
            txtLastName.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 29);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(41, 21);
            label2.TabIndex = 2;
            label2.Text = "Ім'я";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 29);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 4;
            label3.Text = "Телефон";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 29);
            txtEmail.TabIndex = 7;
            // 
            // lebal4
            // 
            lebal4.AutoSize = true;
            lebal4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lebal4.Location = new Point(12, 196);
            lebal4.Name = "lebal4";
            lebal4.Size = new Size(157, 21);
            lebal4.TabIndex = 6;
            lebal4.Text = "Електронна пошта";
            // 
            // pbImage
            // 
            pbImage.Location = new Point(258, 33);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(236, 216);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 8;
            pbImage.TabStop = false;
            // 
            // txtImage
            // 
            txtImage.Location = new Point(500, 59);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(240, 29);
            txtImage.TabIndex = 10;
            txtImage.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(500, 35);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 9;
            label4.Text = "Фото";
            // 
            // BtnSalect
            // 
            BtnSalect.Location = new Point(500, 94);
            BtnSalect.Name = "BtnSalect";
            BtnSalect.Size = new Size(110, 57);
            BtnSalect.TabIndex = 11;
            BtnSalect.Text = "Обрати фото";
            BtnSalect.UseVisualStyleBackColor = true;
            BtnSalect.Click += BtnSalect_Click;
            // 
            // button1
            // 
            button1.Location = new Point(258, 255);
            button1.Name = "button1";
            button1.Size = new Size(120, 57);
            button1.TabIndex = 12;
            button1.Text = "Створити✅";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtnClosed
            // 
            BtnClosed.Location = new Point(378, 255);
            BtnClosed.Name = "BtnClosed";
            BtnClosed.Size = new Size(116, 57);
            BtnClosed.TabIndex = 13;
            BtnClosed.Text = "Скасувати❌";
            BtnClosed.UseVisualStyleBackColor = true;
            // 
            // CreatUserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 336);
            Controls.Add(BtnClosed);
            Controls.Add(button1);
            Controls.Add(BtnSalect);
            Controls.Add(txtImage);
            Controls.Add(label4);
            Controls.Add(pbImage);
            Controls.Add(txtEmail);
            Controls.Add(lebal4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txtLastName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "CreatUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Створити Користувача";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private TextBox txtLastName;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtEmail;
        private Label lebal4;
        private PictureBox pbImage;
        private TextBox txtImage;
        private Label label4;
        private Button BtnSalect;
        private Button button1;
        private Button BtnClosed;
    }
}