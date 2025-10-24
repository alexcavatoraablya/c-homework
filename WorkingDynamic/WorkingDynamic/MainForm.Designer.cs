namespace WorkingDynamic
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
            txtCount = new TextBox();
            label = new Label();
            btnBuilder = new Button();
            btnCalculation = new Button();
            txtCount1 = new TextBox();
            gbA = new GroupBox();
            cbRowsA = new ComboBox();
            gbB = new GroupBox();
            cbRowsB = new ComboBox();
            SuspendLayout();
            // 
            // txtCount
            // 
            txtCount.Location = new Point(28, 36);
            txtCount.Margin = new Padding(4);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(116, 29);
            txtCount.TabIndex = 0;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = SystemColors.Control;
            label.Location = new Point(28, 11);
            label.Name = "label";
            label.Size = new Size(73, 21);
            label.TabIndex = 1;
            label.Text = "Кількість";
            // 
            // btnBuilder
            // 
            btnBuilder.Location = new Point(283, 37);
            btnBuilder.Name = "btnBuilder";
            btnBuilder.Size = new Size(97, 29);
            btnBuilder.TabIndex = 2;
            btnBuilder.Text = "Будувати";
            btnBuilder.UseVisualStyleBackColor = true;
            btnBuilder.Click += btnBuilder_Click;
            // 
            // btnCalculation
            // 
            btnCalculation.Location = new Point(386, 36);
            btnCalculation.Name = "btnCalculation";
            btnCalculation.Size = new Size(105, 30);
            btnCalculation.TabIndex = 3;
            btnCalculation.Text = "Обчислити";
            btnCalculation.UseVisualStyleBackColor = true;
            btnCalculation.Click += btnCalculation_Click;
            // 
            // txtCount1
            // 
            txtCount1.Location = new Point(152, 36);
            txtCount1.Margin = new Padding(4);
            txtCount1.Name = "txtCount1";
            txtCount1.Size = new Size(116, 29);
            txtCount1.TabIndex = 4;
            txtCount1.Click += txtCount1_Click;
            txtCount1.TextChanged += txtCount1_TextChanged;
            // 
            // gbA
            // 
            gbA.Location = new Point(28, 87);
            gbA.Name = "gbA";
            gbA.Size = new Size(273, 257);
            gbA.TabIndex = 5;
            gbA.TabStop = false;
            gbA.Text = "Матриця А";
            // 
            // cbRowsA
            // 
            cbRowsA.FormattingEnabled = true;
            cbRowsA.Location = new Point(28, 361);
            cbRowsA.Name = "cbRowsA";
            cbRowsA.Size = new Size(116, 29);
            cbRowsA.TabIndex = 5;
            cbRowsA.SelectedIndexChanged += cbRows_SelectedIndexChanged;
            // 
            // gbB
            // 
            gbB.Location = new Point(320, 87);
            gbB.Name = "gbB";
            gbB.Size = new Size(273, 257);
            gbB.TabIndex = 6;
            gbB.TabStop = false;
            gbB.Text = "Матриця B";
            gbB.Enter += gbB_Enter;
            // 
            // cbRowsB
            // 
            cbRowsB.FormattingEnabled = true;
            cbRowsB.Location = new Point(152, 361);
            cbRowsB.Name = "cbRowsB";
            cbRowsB.Size = new Size(116, 29);
            cbRowsB.TabIndex = 6;
            cbRowsB.SelectedIndexChanged += cbRowsB_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 547);
            Controls.Add(cbRowsB);
            Controls.Add(gbB);
            Controls.Add(cbRowsA);
            Controls.Add(gbA);
            Controls.Add(txtCount1);
            Controls.Add(btnCalculation);
            Controls.Add(btnBuilder);
            Controls.Add(label);
            Controls.Add(txtCount);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Example";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCount;
        private Label label;
        private Button btnBuilder;
        private Button btnCalculation;
        private TextBox txtCount1;
        private GroupBox gbA;
        private ComboBox cbRowsA;
        private GroupBox gbB;
        private ComboBox cbRowsB;
    }
}
