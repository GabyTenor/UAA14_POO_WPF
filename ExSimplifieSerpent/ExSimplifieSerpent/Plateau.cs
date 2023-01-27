using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace ExSimplifieSerpent
{
    class Plateau
    {    
        public void SetUpGame(Button[,] buttons, Grid plate)
        {
            MainWindow plateau = (ExSimplifieSerpent.MainWindow)App.Current.MainWindow;
            for (int i = 0; i < 10; i++)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                plate.ColumnDefinitions.Add(colDef);
                RowDefinition rowDef = new RowDefinition();
                plate.RowDefinitions.Add(rowDef);

                Grid.SetColumn(plate, 0);
                Grid.SetRow(plate, 1);
            }

            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j] = new Button();

                    if ((i + 1) % 2 == 0)
                    {
                        if ((j + 1) % 2 != 0)
                        {
                            buttons[i, j].Background = Brushes.Aqua;
                        }
                        else
                        {
                            buttons[i, j].Background = Brushes.Red;
                        }
                    }
                    else
                    {
                        if ((j + 1) % 2 == 0)
                        {
                            buttons[i, j].Background = Brushes.Aqua;
                        }
                        else
                        {
                            buttons[i, j].Background = Brushes.Red;
                        }
                    }

                    if (i % 2 == 0)
                    {
                        buttons[i, j].Content = 10 * i + j + 1;
                    }
                    else
                    {
                        buttons[i, j].Content = (10 * i) + 10 - j;
                    }
                    Grid.SetColumn(buttons[i, j], j);
                    Grid.SetRow(buttons[i, j], i);
                    plate.Children.Add(buttons[i, j]);

                }
            }

            buttons[0, 0].Content = "X";
            plateau.grdMain.Children.Add(plate);
        }
    }
}
