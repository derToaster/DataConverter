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
    /// Interaction logic for CurrencyView.xaml
    /// </summary>
    public partial class CurrencyView : UserControl
    {


        public CurrencyView()
        {
            InitializeComponent();




            initCurrencies.SelectedIndex = 0;
            
            resultCurrencies.SelectedIndex = 0;

            ArrayList currencies = new ArrayList { "EUR", "USD", "JPY", "GBP" };

            initCurrencies.ItemsSource = currencies;
            resultCurrencies.ItemsSource = currencies;

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double initialAmount = Double.Parse(amountInput.Text);
            switch (initCurrencies.SelectedIndex)
            {
                #region EUR
                case 0://EUR
                switch (resultCurrencies.SelectedIndex)
                    {
                        case 0:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount, resultCurrencies.SelectedItem);
                            break;
                        case 1:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 1.12055, resultCurrencies.SelectedItem);
                            break;
                        case 2:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 120.448, resultCurrencies.SelectedItem);
                            break;
                        case 3:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 0.90374, resultCurrencies.SelectedItem);
                            break;
                        default:
                            break;
                    }
                break;
                #endregion
                #region USD
                case 1:///USD
            switch (resultCurrencies.SelectedIndex)
                    {
                        case 0:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 0.892371, resultCurrencies.SelectedItem);
                            break;
                        case 1:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount, resultCurrencies.SelectedItem);
                            break;
                        case 2:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount* 107.513, resultCurrencies.SelectedItem);
                            break;
                        case 3:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 0.806147, resultCurrencies.SelectedItem);
                            break;

                        default:
                            break;
                    }
                     break;
                #endregion
                #region JPY
                case 2:///JPY
                    switch (resultCurrencies.SelectedIndex)
                    {
                        case 0:
                            if ((initialAmount * 0.00830284) < 1)
                            {
                                resultText.Content = String.Format("{0} {1}", initialAmount * 0.00830284, resultCurrencies.SelectedItem);
                            }
                            else
                            {
                                resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 0.00830284, resultCurrencies.SelectedItem);
                            }    
                            break;
                        case 1:
                            if ((initialAmount * 0.00930268) < 1)
                            {
                                resultText.Content = String.Format("{0} {1}", initialAmount * 0.00930268, resultCurrencies.SelectedItem);

                            }
                            else
                            {
                                resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 0.00930268, resultCurrencies.SelectedItem);
                            }
                            break;
                        case 2:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount , resultCurrencies.SelectedItem);
                            break;
                        case 3:
                            if ((initialAmount * 0.00749898) < 1)
                            {
                                resultText.Content = String.Format("{0} {1}", initialAmount * 0.00749898, resultCurrencies.SelectedItem);

                            }
                            else
                            {
                                resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 0.00749898, resultCurrencies.SelectedItem);

                            }
                            break;

                        default:
                            break;
                    }
                     break;
                #endregion
                #region GBP
                case 3:///GBP
                    switch (resultCurrencies.SelectedIndex)
                    {
                        case 0:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 1.10750, resultCurrencies.SelectedItem);
                            break;
                        case 1:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 1.24014, resultCurrencies.SelectedItem);
                            break;
                        case 2:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount * 133.284, resultCurrencies.SelectedItem);
                            break;
                        case 3:
                            resultText.Content = String.Format("{0:0.##} {1}", initialAmount, resultCurrencies.SelectedItem);
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
