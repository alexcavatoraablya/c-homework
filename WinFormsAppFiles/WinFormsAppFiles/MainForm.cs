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
                //MessageBox.Show("Файл за замовчуванням знайдено.");
            }
            else
            {
                MessageBox.Show("Файл за замовчуванням не знайдено.");
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            //alert
            //MessageBox.Show("Обираємо файл");
            

            //клас для відкриття вибору файлів
            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            //показуємо діалогове вікно
            //var dialogResult = dlgOpenFile.ShowDialog();
            DialogResult dialogResult = dlgOpenFile.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                    //отримуємо повний шлях до файлу
                    string filePath = dlgOpenFile.FileName;

                    //виводимо шлях у текстове поле
                    textBox1.Text = filePath;

                    pbImage.Image = Image.FromFile(filePath);
                //MessageBox.Show("Ви обрали файл: " + filePath);

            }

        }
        
    }
    
}
