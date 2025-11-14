using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TRPO8.Pages;

namespace TRPO8
{
    /// <summary>
    /// Логика взаимодействия для ListPage.xaml
    /// </summary>
    public partial class ListPage : Page
    {
        public ObservableCollection<Doctor> Doctor { get; set; } = new();
        public Doctor? SelectedDoctor { get; set; }
        public ListPage()
        {
            Doctor.Add(new Doctor()
            {
                ID = 1,
                LastName = "Петров",
                Name = "Иван",
                MiddleName = "Васильевич",
                Specialisation = "Санитар",
                Password = "Password",
            });
            Doctor.Add(new Doctor()
            {
                ID = 2,
                LastName = "Петров",
                Name = "Максим",
                MiddleName = "Васильевич",
                Specialisation = "Санитар",
                Password = "Password",
            });
            Doctor.Add(new Doctor()
            {
                ID = 3,
                LastName = "Петров",
                Name = "Иван",
                MiddleName = "Васильевич",
                Specialisation = "Санитар",
                Password = "Password",
            });
            Doctor.Add(new Doctor()
            {
                ID = 4,
                LastName = "Петров",
                Name = "Иван",
                MiddleName = "Васильевич",
                Specialisation = "Санитар",
                Password = "Password",
            });
            Doctor.Add(new Doctor()
            {
                ID = 5,
                LastName = "Петров",
                Name = "Иван",
                MiddleName = "Васильевич",
                Specialisation = "Санитар",
                Password = "Password",
            });
            Doctor.Add(new Doctor()
            {
                ID = 6,
                LastName = "Петров",
                Name = "Иван",
                MiddleName = "Васильевич",
                Specialisation = "Санитар",
                Password = "Password",
            });
            InitializeComponent();
            DataContext = this;
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedDoctor == null)
            {
                MessageBox.Show("Пользователь не выбран");
                return;
            }
            bool confirm = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes;
            if (confirm)
            {
                Doctor.Remove(SelectedDoctor);
            }
        }
        private void RegistrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrDoctor());
        }
    }
}

