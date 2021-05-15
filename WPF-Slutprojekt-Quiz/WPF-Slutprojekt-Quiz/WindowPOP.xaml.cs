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
    public partial class WindowPOP : Window   //Klassen är till för att göra frågorna och hur det ska fungera för pop fönstret
    {

        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //List över numren på frågorna

        int qNum = 0;  //Värdet på hur många frågor som frågats

        int i; 

        int score; //Variabel för vilken score spelaren är på

        public WindowPOP()  
        {
            InitializeComponent();
            startGame();
            nextQuestion();
        }

        private void checkAnswer(object sender, RoutedEventArgs e) 
        {

            Button senderButton = sender as Button; //Gör knapparna till en sender

            if (senderButton.Tag.ToString() == "1") 
            {
                score++;  //Om Tag i knappen är ett kommer score numret att öka med ett
            }

            if (qNum < 0)
            {
                qNum = 0; // Om frågenumret som spelaren är på är mindre än 0 kommer qNum vara 0
            }
            else
            {
                qNum++; //Annars ökas det med ett.
            }

            scoreText.Content = "  " + score + "/" + questionNumbers.Count;  //Kommer skriva ut efter man svarat på frågan hur många poämg av 10 som man har

            nextQuestion(); //Spelar upp nästa fråga

        }

        private void restartGame() //Startar om spelet genom att score blir 0, qNum går tillbaka med minus 1 och i blir 0, sedan spelas spelet om.
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
                i = questionNumbers[qNum]; //Om frågan den är på är mindre än antalet frågor, skrivs en ny fråga ut
            }
            else
            {
                restartGame(); //Annars spelas spelet om
            }

            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";  //Nya knappar ska ha Tags tillbaka till 0
                x.Background = Brushes.Lavender;  //Sätter färgerna på knapparna till Lavender
            }

            switch (i) //Vilka frågor som finns i spelet, svaren som finns och sedan vilken av frågorna som är rätt, alltså vilken som har en Tag på 1
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

            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList(); //Gör frågenumrena till en randomized lista

            questionNumbers = randomList;

            questionOrder.Content = null; 


            for (int i = 0; i < questionNumbers.Count; i++)
            {
                questionOrder.Content += " " + questionNumbers[i].ToString(); //Skriver ut den Randomized listan

            }

        }

    }
}

