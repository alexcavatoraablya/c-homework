using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsAppFiles
{
    public partial class MainForm : Form
    {
        private string noImage = @"images\1.jpg";
        public MainForm()
        {
            InitializeComponent();

            if (File.Exists(noImage))
            {
                pbImage.Image = Image.FromFile(noImage);
                //MessageBox.Show("���� �� ������������� ��������.");
            }
            else
            {
                MessageBox.Show("���� �� ������������� �� ��������.");
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            //alert
            //MessageBox.Show("������� ����");
            

            //���� ��� �������� ������ �����
            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            //�������� �������� ����
            //var dialogResult = dlgOpenFile.ShowDialog();
            DialogResult dialogResult = dlgOpenFile.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                    //�������� ������ ���� �� �����
                    string filePath = dlgOpenFile.FileName;

                    //�������� ���� � �������� ����
                    textBox1.Text = filePath;

                    pbImage.Image = Image.FromFile(filePath);
                //MessageBox.Show("�� ������ ����: " + filePath);

            }

        }
        
    }
    
}
