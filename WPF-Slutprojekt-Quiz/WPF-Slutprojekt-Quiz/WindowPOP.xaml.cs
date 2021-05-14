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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class WindowPOP : Window
    {

        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int qNum = 0;

        int i;

        int score;

        public WindowPOP()
        {
            InitializeComponent();
            startGame();
            nextQuestion();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
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

            scoreText.Content = "  " + score + "/" + questionNumbers.Count;

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

            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.Lavender;
            }

            switch (i)
            {
                case 1:

                    questionTxt.Text = "If I Was Your Boyfriend";

                    ans1.Content = "Thinking Out Loud - Ed Sheeran";
                    ans2.Content = "Boyfriend - Justin Bieber";
                    ans3.Content = "Thunder - Imagine Dragons";

                    ans2.Tag = "1";

                    break;

                case 2:

                    questionTxt.Text = "Feel The Thunder, Lightning And The Thunder";

                    ans1.Content = "Let It Go - James Bay";
                    ans2.Content = "Eenie Meenie - Justin Bieber & Sean Kingston";
                    ans3.Content = "Thunder - Imagine Dragons";

                    ans3.Tag = "1";

                    break;

                case 3:

                    questionTxt.Text = "All My Tears Have Been Used Up On...";

                    ans1.Content = "Another Love - Tom Odell";
                    ans2.Content = "Summertime Sadness - Lana Del Rey";
                    ans3.Content = "Lovely - Billie Eilish & Khalid";

                    ans1.Tag = "1";

                    break;

                case 4:

                    questionTxt.Text = "I Wish Our Hearts Could Come Together as one";

                    ans1.Content = "Baby - Justin Bieber";
                    ans2.Content = "Eenie Meenie - Justin Bieber & Sean Kingston";
                    ans3.Content = "Beautiful Girls - Sean Kingston";

                    ans2.Tag = "1";

                    break;

                case 5:

                    questionTxt.Text = "Honey Now, Take Me Into Your Loving Arms";

                    ans1.Content = "Thinking Out Loud - Ed Sheeran";
                    ans2.Content = "Watermelon Sugar - Harry Styles";
                    ans3.Content = "Golden - Harry Styles";

                    ans1.Tag = "1";

                    break;

                case 6:

                    questionTxt.Text = "I Want Your Belly And That Summer Feelin'";

                    ans1.Content = "Youngblood - 5 Seconds Of Summer";
                    ans2.Content = "Alone - Alan Walker";
                    ans3.Content = "Watermelon Sugar - Harry Styles";

                    ans3.Tag = "1";

                    break;

                case 7:

                    questionTxt.Text = "You're The Light You're The Night...";

                    ans1.Content = "Outside - Ellie Goulding & Calvin Harris";
                    ans2.Content = "Love Me Like You Do - Ellie Goulding";
                    ans3.Content = "Never Say Never - Justin Bieber";

                    ans2.Tag = "1";

                    break;

                case 8:

                    questionTxt.Text = "If I Was Your Boyfriend";

                    ans1.Content = "Thinking Out Loud - Ed Sheeran";
                    ans2.Content = "Boyfriend - Justin Bieber";
                    ans3.Content = "Thunder - Imagine Dragons";

                    ans2.Tag = "1";

                    break;

                case 9:

                    questionTxt.Text = "I Wanna Feel The Heat With Somebody";

                    ans1.Content = "Walking On Sunshine - Katrina";
                    ans2.Content = "Thriller - Michael Jackson";
                    ans3.Content = "I Wanna Dance With Somebody - Whitney Houston";

                    ans3.Tag = "1";

                    break;

                case 10:

                    questionTxt.Text = "Take Me Away, A Secret Place...";

                    ans1.Content = "Pocketful Of Sunshine - Natasha Bedingfield";
                    ans2.Content = "Take On Me - a-ha";
                    ans3.Content = "Peaches - Justin Bieber";

                    ans1.Tag = "1";

                    break;
            }

        }

        private void startGame()
        {

            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            questionNumbers = randomList;

            questionOrder.Content = null;


            for (int i = 0; i < questionNumbers.Count; i++)
            {
                questionOrder.Content += " " + questionNumbers[i].ToString();

            }

        }

    }
}

