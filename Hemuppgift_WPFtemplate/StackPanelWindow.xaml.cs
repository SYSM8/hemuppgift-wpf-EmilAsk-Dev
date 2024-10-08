using System.Windows;
using System.Windows.Controls;

namespace Hemuppgift_WPF
{
    public partial class StackPanelWindow : Window
    {
        public StackPanelWindow()
        {
            InitializeComponent(); 
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //fick lägga till en null check för att något gick snett när jag inte :)
            if (MainStackPanel != null)
            {
                //ändrar orientering om checkmarken är checkad eller inte
                if (VerticalRadioButton.IsChecked == true)
                {
                    //orientering vertical 
                    MainStackPanel.Orientation = Orientation.Vertical; 
                }
                else
                {
                    //orientering horizontal
                    MainStackPanel.Orientation = Orientation.Horizontal; 
                }
            }
            
        }
    }
}
