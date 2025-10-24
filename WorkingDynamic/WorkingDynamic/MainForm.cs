namespace WorkingDynamic
{
    public partial class MainForm : Form
    {
        private TextBox[,] textBoxes = new TextBox[0, 0];
        public MainForm()
        {
            InitializeComponent();

            cbRowsA.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRowsA.Items.Add("2");
            cbRowsA.Items.Add("3");
            cbRowsA.Items.Add("4");
            cbRowsA.Items.Add("5");
            cbRowsA.SelectedIndex = 0;

            cbRowsB.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRowsB.Items.Add("2");
            cbRowsB.Items.Add("3");
            cbRowsB.Items.Add("4");
            cbRowsB.Items.Add("5");
            cbRowsB.SelectedIndex = 0;
        }

        private void ClearItemsView()
        {
            int n = textBoxes.GetLength(0);
            int m = textBoxes.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    this.gbA.Controls.Remove(textBoxes[i, j]);
                }
            }
        }

        private void clearItemsView()
        {
            int n = textBoxes.GetLength(0);
            int m = textBoxes.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    this.gbB.Controls.Remove(textBoxes[i, j]);
                }
            }
        }

        private void btnBuilder_Click(object sender, EventArgs e)
        {
            clearItemsView();

            int n = int.Parse(txtCount.Text);
            int m = int.Parse(txtCount1.Text);
            //MessageBox.Show($"Побудовано об'єктів: {count}");

            //створення масиву текстових полів
            textBoxes = new TextBox[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    textBoxes[i, j] = new TextBox
                    {
                        Location = new Point(20 + j * 60, 40 + i * 60),
                        Size = new Size(50, 39),
                        Name = $"txtDynamic{j + i + 1}"
                    };
                    this.gbA.Controls.Add(textBoxes[i, j]);
                }

            }


        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            string str = ""; //зберігає рядок значень із полів
            foreach (var txtBox in textBoxes)
            {
                str += txtBox.Text + " ";
            }
            MessageBox.Show(str);
        }

        private void txtCount1_Click(object sender, EventArgs e)
        {

        }

        private void txtCount1_TextChanged(object sender, EventArgs e)
        {

        }

        private void builderMatrixA(int n, int m)
        {
            clearItemsView();
            // Створення масиву текстових полів
            textBoxes = new TextBox[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    textBoxes[i, j] = new TextBox
                    {
                        Location = new Point(20 + j * 60, 40 + i * 60),
                        Size = new Size(50, 39),
                        Name = $"txtDynamic{j + i + 1}"
                    };
                    this.gbA.Controls.Add(textBoxes[i, j]);
                }
            }
        }
        private void builderMatrixB(int n, int m)
        {
            clearItemsView();
            // Створення масиву текстових полів
            textBoxes = new TextBox[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    textBoxes[i, j] = new TextBox
                    {
                        Location = new Point(20 + j * 60, 40 + i * 60),
                        Size = new Size(50, 39),
                        Name = $"txtDynamic{j + i + 1}"
                    };
                    this.gbB.Controls.Add(textBoxes[i, j]);
                }
            }
        }

        private void cbRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectItem = cbRowsA.SelectedItem;
            int n = int.Parse(selectItem.ToString());
            int m = n; // квадратна матриця
            builderMatrixA(n, m);
            builderMatrixB(n, m);
            //MessageBox.Show(selectItem.ToString());
        }
    }
}
