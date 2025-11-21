using System.Collections.ObjectModel;
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
using WpfMVVMDataGrid.Models;
using Bogus;

namespace WpfMVVMDataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //спеціальна колекція яка підтримує сповіщення View про зміни у колекції
        private ObservableCollection<UserVM> users = new();
        public MainWindow()
        {
            InitializeComponent();
            //Заповнюємо колекцію users
            dgUsers.ItemsSource = users;
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            //var userFaker = new Faker<UserVM>()
            //.RuleFor(u => u.Id, f => f.IndexFaker)
            //.RuleFor(u => u.Name, f => f.Name.FullName())
            //.RuleFor(u => u.Email, f => f.Internet.Email(f.Name.FirstName(), f.Name.LastName()))
            //.RuleFor(u => u.Password, f => f.Internet.Password());
            UserVM newUser = new UserVM();
            newUser.Id = users.Count + 1;
            newUser.Name = "New User " + newUser.Id;
            newUser.Email = "gg@gg.ff";
            newUser.Phone = "+38(050) 111 22 33";
            newUser.Password = "123456";
            newUser.Image = "https://i.pinimg.com/originals/43/06/3c/43063c8162fbbae1cf37df742d2afa1c.jpg";

            users.Add(newUser);
            //users.Add(userFaker);
            //MessageBox.Show("Додати нового користувача");
        }

        private void btnEditUser_Click(object sender, RoutedEventArgs e)
        {
            users[0]
                .Image = "https://assets.dots.live/misteram-public/01978356-8ff2-7017-bbaa-b3367d576463-826x0.png";
            users[0].Phone = "+38(067) 999 88 77";

        }
    }
}