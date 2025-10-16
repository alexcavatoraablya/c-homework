namespace Register
{
    public partial class Form1 : Form
    {
        UserSex[] listRoles =
        {
                new UserSex("Чоловік"),
                new UserSex("Жінка")
        };
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(listRoles);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
