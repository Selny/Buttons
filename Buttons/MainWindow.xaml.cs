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

namespace Buttons
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            byte[] colorData = new byte[3];
            rand.NextBytes(colorData);
            if(sender is Button btn)
            {
                btn.Background = new SolidColorBrush(Color.FromArgb(255, colorData[0], colorData[1], colorData[2]));
                MessageBox.Show($"Button value: {btn.Content}\nColor info: {btn.Background}");
            }
        }

        private void btn_RClick(object sender, MouseButtonEventArgs e)
        {
            if(sender is Button btn)
            {
                if(int.Parse(btn.Content.ToString()) > 3) spV.Children.Remove(btn);
                else spH.Children.Remove(btn);
                Title += btn.Content + " ";
            }
        }
    }
}
