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
using System.Windows.Shapes;

namespace WPF_Slutprojekt_Quiz
{

    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class WindowRAP : Window
    {

        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int qNum = 0;

        int i;

        int score;

        public WindowRAP()
        {
            InitializeComponent();
            startGame();
            nextQuestion();
        }

        private void checkAnswerRap(object sender, RoutedEventArgs e)
        {

            Button senderButton = sender as Button;

            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }

            scoreTextRap.Content = "  " + score + "/" + questionNumbers.Count;

            nextQuestion();


        }

        private void restartGame()
        {
            score = 0;
            qNum = -1;
            i = 0;

            startGame();
        }

        private void nextQuestion()
        {

            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                restartGame();
            }

            foreach (var x in myCanvasRap.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.LightBlue;
            }

            switch (i)
            {
                case 1:

                    questionTxtRap.Text = "I´m Sorry Miss Jackson, I Am For Real";

                    an1.Content = "Bodak Yellow - Cardi B";
                    an2.Content = "Ms Jackson - Outkast";
                    an3.Content = "Whoopty - CJ";

                    an2.Tag = "1";

                    break;

                case 2:

                    questionTxtRap.Text = "I Came, I Saw, I Praise The Lord...";

                    an1.Content = "Rap God - Eminem";
                    an2.Content = "Spiral - 21 Savage";
                    an3.Content = "Praise The Lord - A$AP Rocky";

                    an3.Tag = "1";

                    break;

                case 3:

                    questionTxtRap.Text = "I Got 1-2-3-4-5-6-7-8 M's In My Bank Account";

                    an1.Content = "Lucid Dreams - Juice WRLD";
                    an2.Content = "Bank Account - 21 Savage";
                    an3.Content = "La La La - bbno$ & y2k";

                    an3.Tag = "1";

                    break;

                case 4:

                    questionTxtRap.Text = "When I Popped Off, Then They Call Me";

                    an1.Content = "Ms Jackson - Outkast";
                    an2.Content = "Spiral - 21 Savage";
                    an3.Content = "La La La - bbno$ & y2k";

                    an1.Tag = "1";

                    break;

                case 5:

                    questionTxtRap.Text = "I Need More Like Mandy, Yeah";

                    an1.Content = "Candy - Machine Gun Kelly";
                    an2.Content = "Candy - Doja Cat";
                    an3.Content = "Bodak Yellow - Cardi B";

                    an1.Tag = "1";

                    break;

                case 6:

                    questionTxtRap.Text = "We play our fantasies out in real life ways and";

                    an1.Content = "Streets - Doja Cat";
                    an2.Content = "Rap God - Eminem";
                    an3.Content = "Lucid Dreams - Juice WRLD";

                    an1.Tag = "1";

                    break;

                case 7:

                    questionTxtRap.Text = "But For Me To Rap Like A Computer...";

                    an1.Content = "Bad And Boujee - Migos";
                    an2.Content = "Lose Yourself - Eminem";
                    an3.Content = "Rap God - Eminem";

                    an3.Tag = "1";

                    break;

                case 8:

                    questionTxtRap.Text = "I still see your shadows in my room";

                    an1.Content = "Lucid Dreams - Juice WRLD";
                    an2.Content = "SAD! - xxxtentacion";
                    an3.Content = "Saint Tropez - Post Malone";

                    an1.Tag = "1";

                    break;

                case 9:

                    questionTxtRap.Text = "I've been broken, heart's contentious";

                    an1.Content = "SAD! - xxxtentacion";
                    an2.Content = "Streets - Doja Cat";
                    an3.Content = "Praise The Lord - A$AP Rocky";

                    an1.Tag = "1";

                    break;

                case 10:

                    questionTxtRap.Text = "The roof go down when I hit switch";

                    an1.Content = "Candy - Machine Gun Kelly";
                    an2.Content = "Saint Tropez - Post Malone";
                    an3.Content = "Whoopty - CJ";

                    an3.Tag = "1";

                    break;
            }

        }

        private void startGame()
        {

            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            questionNumbers = randomList;

            questionOrderRap.Content = null;


            for (int i = 0; i < questionNumbers.Count; i++)
            {
                questionOrderRap.Content += " " + questionNumbers[i].ToString();

            }

        }
    }
}


