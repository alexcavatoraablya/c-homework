using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ListViewImageView
{
    public partial class MainForm : Form
    {
        //фото для ImageView - зберігає фото
        //Дані фото потрібні для роботи ImageView
        private ImageList largeImageList;
        public MainForm()
        {
            InitializeComponent();
            ////після ініціалізації ми закинеио фото
            //largeImageList = new ImageList();
            //largeImageList.ImageSize = new Size(42, 42); //розмір іконки 
            //largeImageList.ColorDepth = ColorDepth.Depth32Bit;
            ////клас чкий може з мережі викачати фото
            //using HttpClient client = new HttpClient();
            ////качає з мережі фото по адресі - отримуємо байти фото
            //byte[] data = client.GetByteArrayAsync("https://p.novaskin.me/6720725015855104.png").Result;
            ////зберігаємо байти у memory stream
            //using var ms = new System.IO.MemoryStream(data);
            ////створюємо фото на основі об'єкта memory stream
            //Image img = Image.FromStream(ms);
            ////додаємо дане фото у масив і називаємо його folder
            //largeImageList.Images.Add("folder", img);
            ////створюємо новий елемент у ListView називаємо його папка і даємо ідентифікатор фото folder
            //myLv.Items.Add(new ListViewItem("Папка", "folder"));
            //myLv.Items.Add(new ListViewItem("віктор", "folder"));
            //myLv.LargeImageList = largeImageList;

            largeImageList = new ImageList();
            largeImageList.ImageSize = new Size(128, 128); //розмір іконки 
            largeImageList.ColorDepth = ColorDepth.Depth32Bit;

            string path = @"C:\Users\STUDENT\Desktop\images";
            //отримуємо всі файли з папки
            string[] images = Directory.GetFiles(path);
            //перебираємо всі файли
            foreach (string image in images)
            {
                try
                {
                    //отримує назву файлу з повного шляху
                    string fileName = Path.GetFileName(image);
                    //читає байти фото з файлу
                    byte[] data = System.IO.File.ReadAllBytes(image);
                    //зберігає байти у memory stream
                    using var ms = new System.IO.MemoryStream(data);
                    //створює фото на основі об'єкта memory stream
                    var img = Image.FromStream(ms);
                    //додає дане фото у масив і називаємо його folder
                    largeImageList.Images.Add(fileName, img);
                    //відображає файл та його фото
                    myLv.Items.Add(new ListViewItem(fileName, fileName));
                }
                catch //(Exception ex)
                {
                    //MessageBox.Show($"Error loading image {image}: {ex.Message}");
                }
            }
            //прив'язує масив фото до ListView
            myLv.LargeImageList = largeImageList;

        }
    }
}
