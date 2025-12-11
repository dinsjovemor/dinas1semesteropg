using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Media;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WPF1SemesterOpgave
{ 
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            MainFrame.Navigate(new Page1Login()); //Fortæller her at jeg vil have en Frame til at vise siderne, starter med at vise login-siden

        }
    }
}
