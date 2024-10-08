using System.Windows;

namespace Hemuppgift_WPF
{
    public partial class DockPanelWindow : Window
    {
        public DockPanelWindow()
        {
            InitializeComponent();
        }

        private void CenterButton_Click(object sender, RoutedEventArgs e)
        {
            //gör knappen osynlig 
            CenterButton.Visibility = Visibility.Collapsed;
            //gör texten synlig (skulle egentligt vara en bild)
            VictoryImage.Visibility = Visibility.Visible; 
        }
    }
}
