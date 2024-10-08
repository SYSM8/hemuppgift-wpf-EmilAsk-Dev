using System.Windows;
using System.Windows.Controls;

namespace Hemuppgift_WPF
{
    public partial class WrapPanelWindow : Window
    {
        public WrapPanelWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //kollar så att mainwrappanel är null ?!??!?!
            if (MainWrapPanel != null)
            {
                //kollar om checkmarken är i checkad
                if (VerticalRadioButton.IsChecked == true)
                {
                    //orientering vertical 
                    MainWrapPanel.Orientation = Orientation.Vertical;
                }
                else
                {
                    //orientering horizontal
                    MainWrapPanel.Orientation = Orientation.Horizontal;
                }
            }

        }
    }
}
