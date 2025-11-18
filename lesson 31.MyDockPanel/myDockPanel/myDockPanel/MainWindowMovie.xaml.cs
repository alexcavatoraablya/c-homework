using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MainWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowMovie()
        {
            InitializeComponent();
            var movie = new Movie
            {
                Title = "The Pink Panther",
                Year = "1963",
                Description = "Фільм про розслідування Жака Клузо.",
                PosterUrl = "images/posterPP.jpg",
                Rating = 7
            };
            var win = new myDockPanel(movie);
            win.Show();

            DataContext = movie;
        }
    }
}