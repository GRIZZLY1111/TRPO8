using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace TRPO8.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainScreen.xaml
    /// </summary>
    public partial class MainScreen : Page
    {
        private Doctor CurrentDoctor;
        public MainScreen(Doctor? doctor =null)
        {
            CurrentDoctor = new Doctor();
            CurrentDoctor=doctor;
            DataContext = this;
            InitializeComponent();
        }
        private void CreatePacientButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrDoctor());
        }
        private void StartPriemButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrDoctor());
        }
        private void IzmeneniePacientButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrDoctor());
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
