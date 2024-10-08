using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Hemuppgift_WPF
{
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
            CreateGridCells(); 
        }

        private void CreateGridCells()
        {
            //går igenom alla grids och lägger en border 
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    // Create a border for the cell
                    Border border = new Border
                    {
                        //hur bordern ska se ut
                        BorderBrush = Brushes.Black,
                        BorderThickness = new Thickness(1),
                        Background = Brushes.Transparent 
                    };

                   //sätter in raden och columen
                    Grid.SetRow(border, row);
                    Grid.SetColumn(border, col);

                   
                    MainGrid.Children.Add(border);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //kollar så dom funkar
            if (int.TryParse(RowInput.Text, out int row) && int.TryParse(ColumeInput.Text, out int column))
            {
                //kollar så att det finns tillräckligt med rader och columer 
                if (row >= 0 && row < 6 && column >= 0 && column < 6) 
                {
                    //tar cellen
                    var cell = GetCell(row, column);
                    //kollar så den inte är null
                    if (cell != null)
                    {
                        //lägger en backgrund
                        cell.Background = new SolidColorBrush(Colors.LightGreen);

                        //skapar ett objekt för vad som ska vara i cellen
                        TextBlock textBlock = new TextBlock
                        {
                            Text = $"Row: {row}, Col: {column}",
                            VerticalAlignment = VerticalAlignment.Center,
                            HorizontalAlignment = HorizontalAlignment.Center
                        };

                        //sätter arv på trxtblock
                        cell.Child = textBlock;
                    }
                }
                else
                {
                    //om användaren matar in fel index för rad och colum
                    MessageBox.Show("Please enter valid row and column numbers.");
                }
            }
            else
            {
                //om användaren matar in en bokstav
                MessageBox.Show("Invalid input. Please enter numeric values.");
            }
        }

        private Border GetCell(int row, int column)
        {
            //tar alla celler i maingrid.childen 
            foreach (var child in MainGrid.Children)
            {
                // Kontrollera om 'child' är av typen 'Border' och ligger i den angivna raden och kolumnen i Grid.
                // Om båda villkoren är uppfyllda, returnera border objektet.
                if (child is Border border && Grid.GetRow(border) == row && Grid.GetColumn(border) == column)
                {
                    return border;
                }
            }
            return null;
        }
    }
}
