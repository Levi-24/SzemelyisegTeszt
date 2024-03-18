using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SzemelyisegTeszt
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SubWindow subWindow = new SubWindow();
            subWindow.Show();

            string str1 = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            string str5 = "";

            foreach (CheckBox checkBox in stackp1.Children)
            {
                if (checkBox.IsChecked == true) str1 += Convert.ToString(checkBox.Content) + ",";
                subWindow.lbl1.Content = str1;
            }

            foreach (CheckBox checkBox in stackp2.Children)
            {
                if (checkBox.IsChecked == true) str2 += Convert.ToString(checkBox.Content) + ",";
                subWindow.lbl2.Content = str2;
            }

            foreach (CheckBox checkBox in stackp3.Children)
            {
                if (checkBox.IsChecked == true) str3 += Convert.ToString(checkBox.Content) + ",";
                subWindow.lbl3.Content = str3;
            }

            foreach (CheckBox checkBox in stackp4.Children)
            {
                if (checkBox.IsChecked == true) str4 += Convert.ToString(checkBox.Content) + ",";
                subWindow.lbl4.Content = str4;
            }

            foreach (CheckBox checkBox in stackp5.Children)
            {
                if (checkBox.IsChecked == true) str5 += Convert.ToString(checkBox.Content) + ",";
                subWindow.lbl5.Content = str5;
            }
        }
    }
}