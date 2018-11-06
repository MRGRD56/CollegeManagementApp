using System;
using System.Collections.Generic;
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

namespace StudentsManagementApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public static class Extensions
    {
        public static void ChangeSource(this Frame frame, string uriString)
        {
            frame.Source = new Uri(uriString, UriKind.Relative);
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void HideLeftPanel()
        {
            LeftPanel.Visibility = Visibility.Collapsed;
        }

        private void HideLeftPanelButtonClick(object sender, RoutedEventArgs e)
        {
            HideLeftPanel();
        }

        private void AppClose(object sender, RoutedEventArgs e) => Close();

        private void ShowLeftPanel(object sender, RoutedEventArgs e)
        {
            LeftPanel.Visibility = Visibility.Visible;
        }

        private void OpenStudentsManagementPage(object sender, RoutedEventArgs e)
        {
            //MainFrame.Source = new Uri(, UriKind.Relative);
            MainFrame.ChangeSource("Pages/Students/StudentsMgmtPage.xaml");
            HideLeftPanel();
        }

        private void WelcomePageOpen(object sender, RoutedEventArgs e)
        {
            MainFrame.ChangeSource("Pages/WelcomePage.xaml");
        }
    }
}
