using Bogus;

namespace MyDataGridView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            object[] items =
            {
                "1",
                "Непол Віктор Вікторович",
                "+380631234567",
                "nepol@gmail.com",
            };
            dgvUsers.Rows.Add(items);
        }

        private void txtbCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            var userFaker = new Faker<User>()
            .RuleFor(u => u.Id, f => f.IndexFaker + 1)
            .RuleFor(u => u.PIB, f => f.Name.FullName())
            .RuleFor(u => u.Phone, f => f.Phone.PhoneNumber("+380#########"))
            .RuleFor(u => u.Email, f => f.Internet.Email());

            int n = int.Parse(txtbCount.Text);
            List<User> users = userFaker.Generate(n);

            foreach (var user in users)
            {
                object[] items =
                {
                    user.Id.ToString(),
                    user.PIB.ToString(),
                    user.Phone.ToString(),
                    user.Email.ToString(),
                };
                dgvUsers.Rows.Add(items);
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
