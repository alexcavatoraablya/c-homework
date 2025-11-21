namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Ви дійсно хочете вийти з програми?",
                "Підтвердження виходу",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Ви дійсно хочете вийти з програми?",
              "Підтвердження виходу",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatUserForm dlg = new CreatUserForm();
            dlg.ShowDialog();
        }
    }
}
