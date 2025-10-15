namespace Calculator
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
            btnPlus = new Button();
            txtA = new TextBox();
            btnMinus = new Button();
            txtB = new TextBox();
            lbResult = new Label();
            btnDivision = new Button();
            btnMultiply = new Button();
            SuspendLayout();
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.White;
            btnPlus.Font = new Font("SimSun", 14.25F, FontStyle.Bold);
            btnPlus.Location = new Point(461, 30);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(39, 39);
            btnPlus.TabIndex = 0;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 14F);
            txtA.Location = new Point(21, 37);
            txtA.Name = "txtA";
            txtA.Size = new Size(181, 32);
            txtA.TabIndex = 1;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.White;
            btnMinus.Font = new Font("SimSun", 14.25F, FontStyle.Bold);
            btnMinus.Location = new Point(461, 75);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(39, 39);
            btnMinus.TabIndex = 2;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 14F);
            txtB.Location = new Point(222, 37);
            txtB.Name = "txtB";
            txtB.Size = new Size(175, 32);
            txtB.TabIndex = 3;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.BackColor = Color.Transparent;
            lbResult.Font = new Font("Segoe UI", 14F);
            lbResult.Location = new Point(21, 89);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(63, 25);
            lbResult.TabIndex = 4;
            lbResult.Text = "label1";
            lbResult.Click += lbResult_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.White;
            btnDivision.Font = new Font("SimSun", 14.25F, FontStyle.Bold);
            btnDivision.Location = new Point(461, 120);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(39, 39);
            btnDivision.TabIndex = 5;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.White;
            btnMultiply.Font = new Font("SimSun", 14.25F, FontStyle.Bold);
            btnMultiply.Location = new Point(461, 165);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(39, 39);
            btnMultiply.TabIndex = 6;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 419);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivision);
            Controls.Add(lbResult);
            Controls.Add(txtB);
            Controls.Add(btnMinus);
            Controls.Add(txtA);
            Controls.Add(btnPlus);
            Name = "MainForm";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlus;
        private TextBox txtA;
        private Button btnMinus;
        private TextBox txtB;
        private Label lbResult;
        private Button btnDivision;
        private Button btnMultiply;
    }
}
