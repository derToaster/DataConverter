using System;
using System.Collections;
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

namespace DataConverter.UserControls
{
    /// <summary>
    /// Interaction logic for WeightView.xaml
    /// </summary>
    public partial class WeightView : UserControl
    {
        public WeightView()
        {
            InitializeComponent();

            ArrayList weightUnits = new ArrayList {"Kilograms", "Pounds", "Stones","Ounces" };
            initialUnits.ItemsSource = weightUnits;
            initialUnits.SelectedIndex = 0;
            resultUnits.ItemsSource = weightUnits;
            resultUnits.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double initialAmount = Double.Parse(weightInput.Text);
            switch (initialUnits.SelectedIndex)
            {
                #region Kilograms
                case 0://Kilograms
                    switch (resultUnits.SelectedIndex)
                    {
                        case 0:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount, resultUnits.SelectedItem);
                            break;
                        case 1:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 2.20462, resultUnits.SelectedItem);
                            break;
                        case 2:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 0.157472857135078, resultUnits.SelectedItem);
                            break;
                        case 3:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 35.273933176256910826, resultUnits.SelectedItem);
                            break;
                        default:
                            break;
                    }
                    break;
                #endregion
                #region Pounds
                case 1:///Pounds
                    switch (resultUnits.SelectedIndex)
                    {
                        case 0:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 0.453592, resultUnits.SelectedItem);
                            break;
                        case 1:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount, resultUnits.SelectedItem);
                            break;
                        case 2:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 0.07142851316357143, resultUnits.SelectedItem);
                            break;
                        case 3:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 15.999986948640000151, resultUnits.SelectedItem);
                            break;

                        default:
                            break;
                    }
                    break;
                #endregion
                #region Stones
                case 2:///Stones
                    switch (resultUnits.SelectedIndex)
                    {
                        case 0:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 6.35029, resultUnits.SelectedItem);
                            break;
                        case 1:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 13.9999929888, resultUnits.SelectedItem);
                            break;
                        case 2:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount, resultUnits.SelectedItem);
                            break;
                        case 3:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 223.99988782080001215, resultUnits.SelectedItem);
                            break;

                        default:
                            break;
                    }
                    break;
                #endregion
                #region Ounces
                case 3:///Ounces
                    switch (resultUnits.SelectedIndex)
                    {
                        case 0:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 0.028349508927558823845, resultUnits.SelectedItem);
                            break;
                        case 1:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 0.062499968700000005373, resultUnits.SelectedItem);
                            break;
                        case 2:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 0.0044642834785714293269, resultUnits.SelectedItem);
                            break;
                        case 3:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount, resultUnits.SelectedItem);
                            break;
                        default:
                            break;
                    }
                    break;
                #endregion

                default:
                    break;
            }

        }
    }
}
