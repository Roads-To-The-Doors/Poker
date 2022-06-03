using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Названия
        private static string[] names =
        {
            "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"
        };

        // Масти
        private static string[] suits =
        {
            "Hearts", "Diamonds", "Clubs", "Spades"
        };

        // Карта
        public struct card
        {
            public string name;

            public string suit;

            public int range;

            public card(string _name, string _suit, int _range)
            {
                this.name = _name;

                this.suit = _suit;

                this.range = _range;
            }
        }

        // Колода
        private static card[] deck = new card[52];

        // Руки
        private static card[] hands = new card[5];

        /// <summary>
        /// Заполняет колоду
        /// </summary>
        private static void FillDeck()
        {
            int countCards = 0;

            int countRange = 0;

            for (int countNames = 0; countNames < names.Length; ++countNames)
            {
                for (int countSuits = 0; countSuits < suits.Length; ++countSuits)
                {
                    deck[countCards] = new card(names[countNames], suits[countSuits], countRange);

                    ++countCards;
                }

                ++countRange;
            }
        }

        /// <summary>
        /// Возвращает рандомное число
        /// </summary>
        private static int GetRandomNumber()
        {
            Random random = new Random();

            int length = deck.Length;
            /*
            Random rnd = new Random(random.Next());

            int[] randNums = new int[10];

            for (int i = 0; i < randNums.Length; ++i)
            {
                randNums[i] = rnd.Next(0, length);
            }

            int[] randNum_s = new int[5];

            for (int i = 0; i < randNum_s.Length; ++i)
            {
                randNum_s[i] = randNums[rnd.Next(0, randNums.Length)];
            }

            int numberRandomCard = randNum_s[random.Next(0, 5)];
            */
            int numberRandomCard = random.Next(0, length);

            return numberRandomCard;
        }

        /// <summary>
        /// Получает рандомную карту
        /// </summary>
        private static card GetRandomCard()
        {
            int number;

            string _name;

            string _suit;

            do
            {
                number = GetRandomNumber();

                _name = deck[number].name;

                _suit = deck[number].suit;
            }
            while (_name == "none" || _suit == "none");

            card cardToReturn = deck[number];

            deck[number].name = "none";
                
            deck[number].suit = "none";

            return cardToReturn;
        }

        /// <summary>
        /// Дает карты в руки
        /// </summary>
        private static void FillHands()
        {
            for (int n = 0; n < 5; ++n)
            {
                hands[n] = GetRandomCard();
            }
        }

        /// <summary>
        /// Выводит карты на экран
        /// </summary>
        private static void OutCards(card element, PictureBox picture)
        {
            string suit = element.suit;

            string name = element.name;

            switch (suit)
            {
                case "Hearts":

                    switch (name)
                    {
                        case "2":

                            picture.Image = Properties.Resources.TwoOfHearts;

                            break;

                        case "3":

                            picture.Image = Properties.Resources.ThreeOfHearts;

                            break;

                        case "4":

                            picture.Image = Properties.Resources.FourOfHearts;

                            break;

                        case "5":

                            picture.Image = Properties.Resources.FiveOfHearts;

                            break;

                        case "6":

                            picture.Image = Properties.Resources.SixOfHearts;

                            break;

                        case "7":

                            picture.Image = Properties.Resources.SevenOfHearts;

                            break;

                        case "8":

                            picture.Image = Properties.Resources.EightOfHearts;

                            break;

                        case "9":

                            picture.Image = Properties.Resources.NineOfHearts;

                            break;

                        case "10":

                            picture.Image = Properties.Resources.TenOfHearts;

                            break;

                        case "Jack":

                            picture.Image = Properties.Resources.JackOfHearts;

                            break;

                        case "Queen":

                            picture.Image = Properties.Resources.QueenOfHearts;

                            break;

                        case "King":

                            picture.Image = Properties.Resources.KingOfHearts;

                            break;

                        case "Ace":

                            picture.Image = Properties.Resources.AceOfHearts;

                            break;
                    }

                    break;

                case "Diamonds":

                    switch (name)
                    {
                        case "2":

                            picture.Image = Properties.Resources.TwoOfDiamonds;

                            break;

                        case "3":

                            picture.Image = Properties.Resources.ThreeOfDiamonds;

                            break;

                        case "4":

                            picture.Image = Properties.Resources.FourOfDiamonds;

                            break;

                        case "5":

                            picture.Image = Properties.Resources.FiveOfDiamonds;

                            break;

                        case "6":

                            picture.Image = Properties.Resources.SixOfDiamonds;

                            break;

                        case "7":

                            picture.Image = Properties.Resources.SevenOfDiamonds;

                            break;

                        case "8":

                            picture.Image = Properties.Resources.EightOfDiamonds;

                            break;

                        case "9":

                            picture.Image = Properties.Resources.NineOfDiamonds;

                            break;

                        case "10":

                            picture.Image = Properties.Resources.TenOfDiamonds;

                            break;

                        case "Jack":

                            picture.Image = Properties.Resources.JackOfDiamonds;

                            break;

                        case "Queen":

                            picture.Image = Properties.Resources.QueenOfDiamonds;

                            break;

                        case "King":

                            picture.Image = Properties.Resources.KingOfDiamonds;

                            break;

                        case "Ace":

                            picture.Image = Properties.Resources.AceOfDiamonds;

                            break;
                    }

                    break;

                case "Clubs":

                    switch (name)
                    {
                        case "2":

                            picture.Image = Properties.Resources.TwoOfClubs;

                            break;

                        case "3":

                            picture.Image = Properties.Resources.ThreeOfClubs;

                            break;

                        case "4":

                            picture.Image = Properties.Resources.FourOfClubs;

                            break;

                        case "5":

                            picture.Image = Properties.Resources.FiveOfClubs;

                            break;

                        case "6":

                            picture.Image = Properties.Resources.SixOfClubs;

                            break;

                        case "7":

                            picture.Image = Properties.Resources.SevenOfClubs;

                            break;

                        case "8":

                            picture.Image = Properties.Resources.EightOfClubs;

                            break;

                        case "9":

                            picture.Image = Properties.Resources.NineOfClubs;

                            break;

                        case "10":

                            picture.Image = Properties.Resources.TenOfClubs;

                            break;

                        case "Jack":

                            picture.Image = Properties.Resources.JackOfClubs;

                            break;

                        case "Queen":

                            picture.Image = Properties.Resources.QueenOfClubs;

                            break;

                        case "King":

                            picture.Image = Properties.Resources.KingOfClubs;

                            break;

                        case "Ace":

                            picture.Image = Properties.Resources.AceOfClubs;

                            break;
                    }

                    break;

                case "Spades":

                    switch (name)
                    {
                        case "2":

                            picture.Image = Properties.Resources.TwoOfSpades;

                            break;

                        case "3":

                            picture.Image = Properties.Resources.ThreeOfSpades;

                            break;

                        case "4":

                            picture.Image = Properties.Resources.FourOfSpades;

                            break;

                        case "5":

                            picture.Image = Properties.Resources.FiveOfSpades;

                            break;

                        case "6":

                            picture.Image = Properties.Resources.SixOfSpades;

                            break;

                        case "7":

                            picture.Image = Properties.Resources.SevenOfSpades;

                            break;

                        case "8":

                            picture.Image = Properties.Resources.EightOfSpades;

                            break;

                        case "9":

                            picture.Image = Properties.Resources.NineOfSpades;

                            break;

                        case "10":

                            picture.Image = Properties.Resources.TenOfSpades;

                            break;

                        case "Jack":

                            picture.Image = Properties.Resources.JackOfSpades;

                            break;

                        case "Queen":

                            picture.Image = Properties.Resources.QueenOfSpades;

                            break;

                        case "King":

                            picture.Image = Properties.Resources.KingOfSpades;

                            break;

                        case "Ace":

                            picture.Image = Properties.Resources.AceOfSpades;

                            break;
                    }

                    break;
            }
        }

        /*************************** комбинации ***************************/

        private static bool FindPair(card[] cards)
        {
            string[] names = new string[cards.Length];

            for (int p = 0; p < cards.Length; ++p)
            {
                names[p] = cards[p].name;
            }

            Array.Sort(names);

            bool _0 = false;

            bool _1 = false;

            bool _2 = false;

            bool _3 = false;

            bool _4 = false;

            if (names[0] == names[1]) _0 = true;

            if (names[1] == names[2]) _1 = true;

            if (names[2] == names[3]) _2 = true;

            if (names[3] == names[4]) _3= true;

            if (_0 || _1 || _2 || _3 || _4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool FindTwoPair(card[] cards)
        {
            string[] names = new string[cards.Length];

            for (int p = 0; p < cards.Length; ++p)
            {
                names[p] = cards[p].name;
            }

            Array.Sort(names);

            bool _0 = false;

            bool _1 = false;

            bool _2 = false;

            if (names[0] == names[1] && names[2] == names[3]) _0 = true;

            if (names[0] == names[1] && names[3] == names[4]) _1 = true;

            if (names[1] == names[2] && names[3] == names[4]) _2 = true;

            if (_0 || _1 || _2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool FindThreeOfAKind(card[] cards)
        {
            string[] names = new string[cards.Length];

            for (int p = 0; p < cards.Length; ++p)
            {
                names[p] = cards[p].name;
            }

            Array.Sort(names);

            bool _0 = false;

            bool _1 = false;

            bool _2 = false;

            if (names[0] == names[1] && names[1] == names[2]) _0 = true;

            if (names[1] == names[2] && names[2] == names[3]) _1 = true;

            if (names[2] == names[3] && names[3] == names[4]) _2 = true;

            if (_0 || _1 || _2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool FindStraight(card[] cards)
        {
            int[] array = new int[cards.Length];

            for (int p = 0; p < cards.Length; ++p)
            {
                array[p] = cards[p].range;
            }

            Array.Sort(array);

            int equally = 0;

            for (int p = 0; p < array.Length - 1; ++p)
            {
                if (array[p] == array[p + 1] - 1)
                    ++equally;
            }

            if (equally == array.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool FindFlush(card[] cards)
        {
            string[] array = new string[cards.Length];

            for (int p = 0; p < cards.Length; ++p)
            {
                array[p] = cards[p].suit;
            }

            int equally = 0;

            for (int p = 1; p < array.Length; ++p)
            {
                if (array[0] == array[p])
                    ++equally;
            }

            if (equally == array.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool FindFullHouse(card[] cards)
        {
            string[] names = new string[cards.Length];

            for (int p = 0; p < names.Length; ++p)
            {
                names[p] = cards[p].name;
            }

            Array.Sort(names);

            string _0 = names[0];

            string _1 = names[1];

            string _2 = names[2];

            string _3 = names[3];

            string _4 = names[4];

            if (((_0 == _1 && _1 == _2) && (_3 == _4)) || ((_2 == _3 && _3 == _4) && (_0 == _1)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool FindFourOfAKind(card[] cards)
        {
            string[] names = new string[cards.Length];

            for (int p = 0; p < names.Length; ++p)
            {
                names[p] = cards[p].name;
            }

            Array.Sort(names);

            string _0 = names[0];

            string _1 = names[1];

            string _2 = names[2];

            string _3 = names[3];

            string _4 = names[4];

            if ((_0 == _1 && _1 == _2 && _2 == _3) || (_1 == _2 && _2 == _3 && _3 == _4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool FindStraightFlush(card[] cards)
        {
            bool straight = FindStraight(cards);

            bool flush = FindFlush(cards);

            if (straight & flush)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool FindRoyalFlush(card[] cards)
        {
            string[] names = new string[cards.Length];

            Array.Sort(names);

            bool _10 = false;

            bool jack = false;

            bool queen = false;

            bool king = false;

            bool ace = false;

            bool suits = false;

            if (cards[0].suit == cards[1].suit &&
                cards[1].suit == cards[2].suit &&
                cards[2].suit == cards[3].suit &&
                cards[3].suit == cards[4].suit) suits = true;

            if (names[0] == "10") _10 = true;

            if (names[1] == "jack") jack = true;

            if (names[2] == "queen") queen = true;

            if (names[3] == "king") king = true;

            if (names[4] == "ace") ace = true;

            if (_10 && jack && queen && king && ace && suits)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /******************************************************************/

        /// <summary>
        /// Находит комбинации
        /// </summary>
        private static string FindACombination(card[] cards)
        {
            string result = "High Card";

            if (FindPair(cards)) result = "Pair";

            if (FindTwoPair(cards)) result = "Two Pair";

            if (FindThreeOfAKind(cards)) result = "Three Of A Kind";

            if (FindStraight(cards)) result = "Straight";

            if (FindFlush(cards)) result = "Flush";

            if (FindFullHouse(cards)) result = "Full House";

            if (FindFourOfAKind(cards)) result = "Four Of A Kind";

            if (FindStraightFlush(cards)) result = "Straight Flush";

            if (FindRoyalFlush(cards)) result = "Royal Flush";

            return result;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;

            cardOne.Enabled = false;

            cardTwo.Enabled = false;

            cardThree.Enabled = false;

            cardFour.Enabled = false;

            cardFive.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (state.Text != "" && Convert.ToInt32(state.Text) <= Convert.ToInt32(money.Text) && Convert.ToInt32(state.Text) > 0)
            {
                int sum = Convert.ToInt32(money.Text) - Convert.ToInt32(state.Text);

                money.Text = Convert.ToString(sum);

                state.Enabled = false;

                button1.Enabled = false;

                button2.Enabled = true;

                cardOne.Enabled = true;

                cardTwo.Enabled = true;

                cardThree.Enabled = true;

                cardFour.Enabled = true;

                cardFive.Enabled = true;

                cardOne.Checked = false;

                cardTwo.Checked = false;

                cardThree.Checked = false;

                cardFour.Checked = false;

                cardFive.Checked = false;

                FillDeck();

                FillHands();

                OutCards(hands[0], pictureBox1);

                OutCards(hands[1], pictureBox2);

                OutCards(hands[2], pictureBox3);

                OutCards(hands[3], pictureBox4);

                OutCards(hands[4], pictureBox5);

                infoBox.Text = FindACombination(hands);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cardOne.Checked)
            {
                hands[0] = GetRandomCard();

                OutCards(hands[0], pictureBox1);
            }

            if (cardTwo.Checked)
            {
                hands[1] = GetRandomCard();

                OutCards(hands[1], pictureBox2);
            }

            if (cardThree.Checked)
            {
                hands[2] = GetRandomCard();

                OutCards(hands[2], pictureBox3);
            }

            if (cardFour.Checked)
            {
                hands[3] = GetRandomCard();

                OutCards(hands[3], pictureBox4);
            }

            if (cardFive.Checked)
            {
                hands[4] = GetRandomCard();

                OutCards(hands[4], pictureBox5);
            }

            infoBox.Text = FindACombination(hands);

            int myState = Convert.ToInt32(state.Text);

            int r = Convert.ToInt32(state.Text);

            state.Text = "";
            
            switch (infoBox.Text)
            {
                case "High Card":

                    myState *= 0;

                    break;

                case "Pair":

                    myState *= 1;

                    break;
                    
                case "Two Pair":

                    myState *= 2;

                    break;

                case "Three Of A Kind":

                    myState *= 3;

                    break;

                case "Straight":

                    myState *= 4;

                    break;

                case "Flush":

                    myState *= 5;

                    break;

                case "Full House":

                    myState *= 7;

                    break;

                case "Four Of A Kind":

                    myState *= 20;

                    break;

                case "Straight Flush":

                    myState *= 50;

                    break;

                case "Royal Flush":

                    myState *= 100;

                    break;
            }

            summary.Text = Convert.ToString(myState - r);

            money.Text = Convert.ToString(Convert.ToInt32(money.Text) + myState);

            button1.Enabled = true;

            button2.Enabled = false;

            cardOne.Enabled = false;

            cardTwo.Enabled = false;

            cardThree.Enabled = false;

            cardFour.Enabled = false;

            cardFive.Enabled = false;

            state.Enabled = true;

            if (Convert.ToInt32(money.Text) <= 0)
            {
                MessageBox.Show("Вы проиграли!");

                Application.Exit();
            }
        }
    }
}