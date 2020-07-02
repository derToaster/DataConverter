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
    /// Interaction logic for MeasurementView.xaml
    /// </summary>
    public partial class MeasurementView : UserControl
    {
        public MeasurementView()
        {
            
            
            InitializeComponent();
            ArrayList unitList = new ArrayList { "Meters", "Feet", "Inches", "Miles" };


            initialUnits.ItemsSource = unitList;
            initialUnits.SelectedIndex = 0;
            resultUnits.ItemsSource = unitList;
            resultUnits.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double initialAmount = Double.Parse(measureInput.Text);
            switch (initialUnits.SelectedIndex)
            {
                #region Meters
                case 0://Meters
                    switch (resultUnits.SelectedIndex)
                    {
                        case 0:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount, resultUnits.SelectedItem);
                            break;
                        case 1:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 3.28084, resultUnits.SelectedItem);
                            break;
                        case 2:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 39.37008, resultUnits.SelectedItem);
                            break;
                        case 3:
                            if ((initialAmount * 0.00062137121212121) < 1)
                            {
                                resultText.Content = String.Format("{0} {1}", initialAmount * 0.00062137121212121, resultUnits.SelectedItem);
                            }else
                            {
                                resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 0.00062137121212121, resultUnits.SelectedItem);
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                #endregion
                #region Feet
                case 1:///Feet
                    switch (resultUnits.SelectedIndex)
                    {
                        case 0:
                            if ((initialAmount * 0.3048000097535989994) < 1)
                            {
                                resultText.Content = String.Format("{0} {1}", initialAmount * 0.3048000097535989994, resultUnits.SelectedItem);
                            }
                            else
                            {
                                resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 0.3048000097535989994, resultUnits.SelectedItem);
                            }
                            break;
                        case 1:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount, resultUnits.SelectedItem);
                            break;
                        case 2:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 12.000000383999960718, resultUnits.SelectedItem);
                            break;
                        case 3:
                            if ((initialAmount * 0.00018939394545454483467) < 1)
                            {
                                resultText.Content = String.Format("{0} {1}", initialAmount * 0.00018939394545454483467, resultUnits.SelectedItem);
                            }
                            else
                            {
                                resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 0.00018939394545454483467, resultUnits.SelectedItem);
                            }
                            break;

                        default:
                            break;
                    }
                    break;
                #endregion
                #region Inches
                case 2:///Inches
                    switch (resultUnits.SelectedIndex)
                    {
                        case 0:
                            if ((initialAmount * 0.025400000812799913147) < 1)
                            {
                                resultText.Content = String.Format("{0} {1}", initialAmount * 0.025400000812799913147, resultUnits.SelectedItem);

                            }
                            else
                            {
                                resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 0.025400000812799913147, resultUnits.SelectedItem);
                            }
                            break;
                        case 1:
                            if ((initialAmount * 0.083333335999999716415) < 1)
                            {
                                resultText.Content = String.Format("{0} {1}", initialAmount * 0.083333335999999716415, resultUnits.SelectedItem);

                            }
                            else
                            {
                                resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 0.083333335999999716415, resultUnits.SelectedItem);
                            }
                            break;
                        case 2:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount, resultUnits.SelectedItem);
                            break;
                        case 3:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 1.578282878787873509e-5, resultUnits.SelectedItem);
                            break;

                        default:
                            break;
                    }
                    break;
                #endregion
                #region Miles
                case 3:///Miles
                    switch (resultUnits.SelectedIndex)
                    {
                        case 0:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 1609.3440514990027168, resultUnits.SelectedItem);
                            break;
                        case 1:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 5280.0001689599821475, resultUnits.SelectedItem);
                            break;
                        case 2:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 63360.002027519796684, resultUnits.SelectedItem);
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
