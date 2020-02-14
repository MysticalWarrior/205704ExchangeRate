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

using System.IO;
using System.Net;

namespace _205704ExchangeRate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            WebClient webClient = new WebClient();
            string input = webClient.DownloadString("https://api.exchangeratesapi.io/latest");
            string CAD = input.Substring(input.IndexOf("CAD") - 1, (input.IndexOf(",", input.IndexOf("CAD")) - input.IndexOf("CAD")));
            ///length is position of last letter-position of first letter
            //MessageBox.Show(CAD);//troubleshooting
            Double.TryParse(CAD.Substring(CAD.IndexOf(":") + 1, CAD.Length - (CAD.IndexOf(":") + 1)), out double cad);
            //MessageBox.Show(cad.ToString());//troubleshooting

            string USD = input.Substring(input.IndexOf("USD") - 1, (input.IndexOf(",", input.IndexOf("USD")) - input.IndexOf("USD")));
            ///length is position of last letter-position of first letter
            //MessageBox.Show(USD);//troubleshooting
            Double.TryParse(USD.Substring(USD.IndexOf(":") + 1, USD.Length - (USD.IndexOf(":") + 1)), out double usd);
            //MessageBox.Show(usd.ToString());//troubleshooting

            /*blank form:
                * string [$###} = input.Substring(input.IndexOf("[$###]") - 1, (input.IndexOf(",", input.IndexOf("[#$$$]")) - input.IndexOf("[$###]")));
                ///length is position of last letter-position of first letter
                //MessageBox.Show([$###]);//troubleshooting
                Double.TryParse([$###].Substring([$###].IndexOf(":") + 1, [$###].Length - ([$###].IndexOf(":") + 1)), out double [$$$]);
                //MessageBox.Show([$$$].ToString());//troubleshooting
            */
        }
    }
}
