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

namespace Hemuppgift_WPF
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

        private void ButtonGrid_Click(object sender, RoutedEventArgs e)
        {
            var GridWindow = new GridWindow();
            GridWindow.Show();
        }

        private void ButtonStackPanel_Click(object sender, RoutedEventArgs e)
        {
            var StackPanel = new StackPanelWindow();
            StackPanel.Show();
        }

        private void ButtonWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            var WrapPanel = new WrapPanelWindow();
            WrapPanel.Show();
        }

        private void ButtonDockPanel_Click(object sender, RoutedEventArgs e)
        {
            var DockPanel = new DockPanelWindow();
            DockPanel.Show();
        }
    }
}