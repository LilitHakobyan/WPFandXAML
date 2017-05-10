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

namespace MenuLengApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmdLenguage_Click(object sender, RoutedEventArgs e)
        { if (cmdLenguage.Content == "Язык")
            {
                cmdBack.Content = "Back";
                cmdClose.Content = "Close";
                cmdNext.Content = "Next";
                cmdLenguage.Content = "Lenguage";
               
            }
            else
            {
                cmdBack.Content = "Назад";
                cmdClose.Content = "Закрить";
                cmdNext.Content = "Вперед";
                cmdLenguage.Content = "Язык";
            }
            
        }
        private void cmdClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
