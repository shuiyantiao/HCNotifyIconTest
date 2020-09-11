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

namespace WpfNotifyIconTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/WpfNotifyIconTest;component/Resources/red.png", UriKind.RelativeOrAbsolute);
            image.EndInit();
            icon.Icon = image;
            //this.Hide();
        }

        private bool _isIconGreen = false;

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void IsBlinkEnableWhileChangeIconResourceMenuItem_Click(object sender, RoutedEventArgs e)
        {
            IsBlinkEnableWhileChangeIconResourceMenuItem.IsChecked = !IsBlinkEnableWhileChangeIconResourceMenuItem.IsChecked;
        }

        private void NotifyIcon_Click(object sender, RoutedEventArgs e)
        {
            if (_isIconGreen == false)
            {
                icon.IsBlink = true && IsBlinkEnableWhileChangeIconResourceMenuItem.IsChecked;
                var image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri("pack://application:,,,/WpfNotifyIconTest;component/Resources/green.png", UriKind.RelativeOrAbsolute);
                image.EndInit();
                icon.Icon = image;
                icon.IsBlink = false;
            }
            else
            {
                icon.IsBlink = true && IsBlinkEnableWhileChangeIconResourceMenuItem.IsChecked;
                var image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri("pack://application:,,,/WpfNotifyIconTest;component/Resources/red.png", UriKind.RelativeOrAbsolute);
                image.EndInit();
                icon.Icon = image;
                icon.IsBlink = false;
            }
            _isIconGreen = !_isIconGreen;
        }

    }
}
