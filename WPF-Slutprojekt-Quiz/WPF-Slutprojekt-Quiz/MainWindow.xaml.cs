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

namespace WPF_Slutprojekt_Quiz
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void POP(object sender, RoutedEventArgs e)
        {

            WindowPOP windowPOP = new WindowPOP();
            windowPOP.ShowDialog();

        }

        private void RAP(object sender, RoutedEventArgs e)
        {

            WindowRAP windowRAP = new WindowRAP();
            windowRAP.ShowDialog();

        }

        private void ROCK(object sender, RoutedEventArgs e)
        {

            WindowROCK windowROCK = new WindowROCK();
            windowROCK.ShowDialog();

        }
    }
}

