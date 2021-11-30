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

namespace Conjugation_of_Verbs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string input;
        string output;
        string mode;

        Program program = new Program();

        public MainWindow()
        {
            InitializeComponent();

        }
        
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            mode = "I";
            input = Inputbox.Text;
            output = program.Verb(input, mode);

            Outputbox.Text = output;

        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
