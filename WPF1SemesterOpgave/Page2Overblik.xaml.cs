using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF1SemesterOpgave
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page2Overblik : Page
    {
        public Page2Overblik()
        {
            InitializeComponent();
            
        }

        private void ButtonMedlemshåndtering_Click(object sender, RoutedEventArgs e)
        {
            Main mainWindow = (Main)Application.Current.MainWindow; //Find mainwindow af programmet
            mainWindow.MainFrame.Navigate(new Page3Medlemmer()); //Fortæller mainwindow at Page3Medlemmer skal vises
        }

        private void ButtonKursushåndtering_Click(object sender, RoutedEventArgs e)
        {
            Main mainWindow = (Main)Application.Current.MainWindow; //Find mainwindow af programmet
            mainWindow.MainFrame.Navigate(new Page4Kurser()); //Fortæller mainwindow at Page4Kurser skal vises
        }
    }
}
