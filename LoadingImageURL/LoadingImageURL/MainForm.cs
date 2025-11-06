using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Security.Policy;

namespace LoadingImageURL
{
    public partial class MainForm : Form
    {
        string imgUrl = "https://thispersondoesnotexist.com/";
        private readonly HttpClient client = new();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadUrl_Click(object sender, EventArgs e)
        {
            LoadImage();
        }
        public async Task LoadImage()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int n = 5;
            for(int i = 0; i < n; i++)
            {
                //завантаження з інтернету в масив байт
                byte[] imageBytes = await client.GetByteArrayAsync(imgUrl);
                using var ms = new MemoryStream(imageBytes);

                pbImage.Image = Image.FromStream(ms);

                var dir = Path.Combine(Directory.GetCurrentDirectory(), "images");
                if(!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                string fileSave = Path.Combine(dir, "images" + i + ".jpg");
                FileStream fs = new FileStream(fileSave, FileMode.Create);
                fs.Write(ms.ToArray());
                fs.Close();
            }
            
            //byte[] imageBytes = await client.GetByteArrayAsync(imgUrl);
            //using var ms = new MemoryStream(imageBytes);

            //photo = Image.FromStream(ms);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            MessageBox.Show("RunTime " + elapsedTime);
        }

        //Завантажити в папку
        public async Task LoadImageToFolder()
        {
            //завантаження з інтернету в масив байт
            byte[] imageBytes = await client.GetByteArrayAsync(imgUrl);
            //потік пам'яті з масиву байт
            using var ms = new MemoryStream(imageBytes);
            //шлях до папки зображень
            string dir = Path.Combine(Directory.GetCurrentDirectory(), "images");
            //ім'я файлу
            string imageName = "vova.jpg";
            //створення папки, якщо її немає
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            //повний шлях до файлу
            string savePath = Path.Combine(dir, imageName);
            //створення файлового потоку для запису
            FileStream fileStream =
                new FileStream(savePath, FileMode.Create, FileAccess.Write);
            //массив байт з потоку пам'яті
            byte[] bytes = ms.ToArray();
            //запис массива байт в файловий поток
            fileStream.Write(bytes);
            fileStream.Close();
            //pbImage.Image = Image.FromStream(ms);
            //photo = Image.FromStream(ms);
        }
        //У папку кнопку натиснули
        private void btnToFolder_Click(object sender, EventArgs e)
        {
            LoadImageToFolder();
        }

        private void txtbCount_Click(object sender, EventArgs e)
        {

        }
    }
}
