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
        int X_int = 69;
        int Y_int = 69;
        public MainWindow()
        {
            Quadrants = "";
            Console.WriteLine(Quadrants);
            InitializeComponent();
        }

        private void ButtonTest_Click(object sender, RoutedEventArgs e)

        {

            Quadrants = txtbxTest.Text;
            int.TryParse(txtbxTest.Text.Substring(0, Quadrants.IndexOf('\r')), out X_int);

            Console.WriteLine(X_int.ToString());

            int.TryParse(txtbxTest.Text.Substring(Quadrants.IndexOf('\r') + 2, Quadrants.Length - Quadrants.IndexOf('\r') - 2), out Y_int);

            Console.WriteLine(Y_int.ToString());

            if (X_int > 0)
            {
                if (Y_int > 0)
                {
                    lblTest.Content = "Quadrant 1";
                }
            }
            else if (X_int < 0)
            {
                if (Y_int > 0)
                {
                    lblTest.Content = "Quadrant 2";
                }
            }
            else if (X_int < 0 || Y_int < 0)
            {
                lblTest.Content = "Quadrant 3";
            }
            else if (X_int > 0 || Y_int < 0)
            {
                lblTest.Content = "Quadrant 4";
            }
            /*  Quadrants = txtbxTest.Text;
            if (Quadrants == "hi")
            {
                lblTest.Content = "YAY";
            }*/

        
        } 
    }
}
