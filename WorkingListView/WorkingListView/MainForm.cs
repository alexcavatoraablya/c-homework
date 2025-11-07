namespace WorkingListView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var drivers = Environment.GetLogicalDrives();

            foreach (var driver in drivers)
            {
                cbDrivers.Items.Add(driver);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mylistView.Items.Add(new ListViewItem
            {
                Text = "Привіт козаки"
            });
        }

        private void cbDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbDrivers.SelectedItem.ToString());
            mylistView.Items.Clear();
            string driver = cbDrivers.SelectedItem.ToString();
            foreach (var folder in Directory.GetDirectories(driver))
            {
                mylistView.Items.Add(new ListViewItem
                {
                    Text = Path.GetFileName(folder)
                });
            }

            foreach (var files in Directory.GetFiles(driver))
            {
                mylistView.Items.Add(new ListViewItem
                {
                    Text = Path.GetFileName(files)
                });
            }
        }
    }
}
