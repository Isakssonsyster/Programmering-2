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
    public partial class WindowROCK : Window  //Har exakt samma kod som i WindowPOP, förutom att frågorna och svaren är annorlunda
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int qNum = 0;

        int i;

        int score;

        public WindowROCK()
        {
            InitializeComponent();
            startGame();
            nextQuestion();
        }

        private void checkAnswerRock(object sender, RoutedEventArgs e)
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

            scoreTextRock.Content = "  " + score + "/" + questionNumbers.Count;

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
                x.Background = Brushes.LightGreen;
            }

            switch (i)
            {
                case 1:

                    questionTxtRock.Text = "Can't tell if this is true or dream";

                    an1.Content = "Sweet Child O' Mine - Guns N' Roses";
                    an2.Content = "One - Metallica";
                    an3.Content = "Human Race - Three Days Grace";

                    an2.Tag = "1";

                    break;

                case 2:

                    questionTxtRock.Text = "'Cause I'm cut deep, my heart won't beat";

                    an1.Content = "I Need Help - Papa Roach";
                    an2.Content = "Never Too Late - Three Days Grace";
                    an3.Content = "Wrong Side Of Heaven - Five Finger Death Punch";

                    an1.Tag = "1";

                    break;

                case 3:

                    questionTxtRock.Text = "Started with a kick and punch, A claw to the face";

                    an1.Content = "Human Race - Three Days Grace";
                    an2.Content = "Last Resort - Papa Roach";
                    an3.Content = "Zombie - The Cranberries";

                    an1.Tag = "1";

                    break;

                case 4:

                    questionTxtRock.Text = "Falling further and further away, Getting closer every day";

                    an1.Content = "The Diary Of Jane - Breaking Benjamin";
                    an2.Content = "Gone Forever - Three Days Grace";
                    an3.Content = "Wrong Side Of Heaven - Five Finger Death Punch";

                    an3.Tag = "1";

                    break;

                case 5:

                    questionTxtRock.Text = "No stop signs, Speed limit";

                    an1.Content = "Lydia - Highly Suspect";
                    an2.Content = "Highway To Hell - ACDC";
                    an3.Content = "Throne - Bring Me The Horizon";

                    an3.Tag = "1";

                    break;

                case 6:

                    questionTxtRock.Text = "I was an ocean, lost in the open";

                    an1.Content = "Throne - Bring Me The Horizon";
                    an2.Content = "Bring Me To Life - Evanescenes";
                    an3.Content = "I Apologize - Five Finger Death Punch";

                    an1.Tag = "1";

                    break;

                case 7:

                    questionTxtRock.Text = "How can you see into my eyes, like open doors";

                    an1.Content = "Going Under - Evanescenes";
                    an2.Content = "Bring Me To Life - Evanescenes";
                    an3.Content = "Enter Sandman - Metallica";

                    an2.Tag = "1";

                    break;

                case 8:

                    questionTxtRock.Text = "Take my hand, We're off to never-never land, yeah";

                    an1.Content = "Enter Sandman - Metallica ";
                    an2.Content = "I Need Help - Papa Roach";
                    an3.Content = "Carry On Wayward Son - Kansas";

                    an1.Tag = "1";

                    break;

                case 9:

                    questionTxtRock.Text = "I've seen better days So unafraid in my youth";

                    an1.Content = "Pain - Three Days Grace";
                    an2.Content = "Lydia - Highly Suspect";
                    an3.Content = "Last Resort - Papa Roach";

                    an2.Tag = "1";

                    break;

                case 10:

                    questionTxtRock.Text = "You're sick of feeling numb, You're not the only one";

                    an1.Content = "Carry On Wayward Son - Kansas";
                    an2.Content = "The Diary Of Jane - Breaking Benjamin";
                    an3.Content = "Pain - Three Days Grace";

                    an3.Tag = "1";

                    break;
            }

        }

        private void startGame()
        {

            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            questionNumbers = randomList;

            questionOrderRock.Content = null;


            for (int i = 0; i < questionNumbers.Count; i++)
            {
                questionOrderRock.Content += " " + questionNumbers[i].ToString();

            }

        }
    }
}

