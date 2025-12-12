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

namespace WPF1SemesterOpgave
{
    /// <summary>
    /// Interaction logic for Page1Login.xaml
    /// </summary>
    public partial class Page1Login : Page
    {
        public Page1Login()
        {
            InitializeComponent();


        }

        private void textOverblik_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
           
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            //string userBrugernavn = brugernavnUser.Text;
            //string userPassword = passwordUser.Text;
            //if (userBrugernavn == "admin" && userPassword == "hello") //Jeg vælger brugernavn og password
            //{
              var mainWindow = (Main)Application.Current.MainWindow; //Find mainwindow af programmet
              mainWindow.MainFrame.Navigate(new Page2Overblik()); //Fortæller mainwindow at Page2Overblik skal vises
            //}
            //else
            //{
            //    MessageBox.Show("Forkert brugernavn og password. Prøv igen"); //Beder om at vise en fejlbesked ved forkerte oplysninger indtastet

            //}  
        }

    }
}