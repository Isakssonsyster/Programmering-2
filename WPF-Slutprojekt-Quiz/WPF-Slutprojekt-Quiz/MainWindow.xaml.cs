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
    public partial class MainWindow : Window   // Klassen är till för meny fönstret där man kan välja vilken genre man vill spela
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void POP(object sender, RoutedEventArgs e)
        {

            WindowPOP windowPOP = new WindowPOP();   
            windowPOP.ShowDialog();  //Tar dig till WindowPOP alltså fönstret där man kan gissa på vilka poplåtar det är

        }

        private void RAP(object sender, RoutedEventArgs e)
        {

            WindowRAP windowRAP = new WindowRAP();
            windowRAP.ShowDialog();  //Tar dig till WindowRAP alltså fönstret där man kan gissa på vilka rapplåtar det är

        }

        private void ROCK(object sender, RoutedEventArgs e)
        {

            WindowROCK windowROCK = new WindowROCK();
            windowROCK.ShowDialog();  //Tar dig till WindowROCK alltså fönstret där man kan gissa på vilka rocklåtar det är

        }
    }
}

