using OOPLib;
using OOPLib.Models;
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

namespace WpfApp
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

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            string pickedGender = cbSelectGender.Text;
            string pickedLanguage =cbSelectLanguage.Text;
            string pickedScreenSize = cbSelectedSize.Text;
            Repository.SaveWPFSettings(new WPFSettings(pickedGender, pickedLanguage, pickedScreenSize));
            Hide();
            new FootballMain().Show();
        }
    }
}
