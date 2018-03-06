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

namespace u2_j1_QuadrantsStuff_Sebastian
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
         
    {
        string Quadrants;

        public MainWindow()
        {
            Quadrants = "i want to die";
            Console.WriteLine(Quadrants);
            InitializeComponent();
        }
       
        private void ButtonTest_Click(object sender, RoutedEventArgs e)

        {
            Quadrants = txtbxTest.Text;
            if (Quadrants == "hi")
            {
                lblTest.Content = "YAY";
            }

        
        } 
    }
}
