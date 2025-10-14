namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            lbResult.Text = (a + b).ToString();
            //string text = txtA.Text;
            //MessageBox.Show(text);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            lbResult.Text = (a - b).ToString();
            //string text = txtB.Text;
            //MessageBox.Show(text);
        }

        private void lbResult_Click(object sender, EventArgs e)
        {

        }
    }
}
