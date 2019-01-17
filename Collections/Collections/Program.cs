using Collections.Classes;
using System;



namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PutCardsInDeck();
            UserInterface();


        }

        public static void UserInterface()
        {
            //interface is running

            bool running = true;

            //while the interface is runn run this code
            while (running)
            {
                Console.WriteLine("please choose option 1, 2, 3, or 4");
                Console.WriteLine("1: Delete a card");
                Console.WriteLine("2: See Cards in Dealer's deck");
                Console.WriteLine("3: Deal");
                Console.WriteLine("4: Exit");
                try
                {

                    string userSelection = Console.ReadLine();

                    int userSelect = Convert.ToInt32(userSelection);

                    if (userSelect == 1 || userSelect == 2 || userSelect == 3 || userSelect == 4)
                    {
                        switch (userSelect)
                        {
                            //if user chooses withdrawal
                            case 1:
                                Deck<Card> mDeck = PutCardsInDeck();

                                RemoveFromDeck(mDeck);
                                Console.WriteLine();
                                Console.WriteLine();

                                break;

                            case 2:
                                Deck<Card> myDeck = PutCardsInDeck();
                                PrintAllCards(myDeck);
                                Console.WriteLine();
                                Console.WriteLine();
                                break;

                            case 3:
                                Deck<Card> myDeckDeal = PutCardsInDeck();
                                Deal(myDeckDeal);
                                break;

                            default:
                                Environment.Exit(0);
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Please Choose a valid option, press enter to continue");
                        Console.ReadLine();
                        UserInterface();

                    }
                }
                catch
                {
                    Console.WriteLine();
                }
            }
        }


        public static Deck<Card> PutCardsInDeck()
        {
            Card cardOne = new Card();
            cardOne.CardSuit = CardSuites.Hearts;
            cardOne.CardValue = CardValues.Ace;

            Card cardTwo = new Card();
            cardTwo.CardSuit = CardSuites.Diamonds;
            cardTwo.CardValue = CardValues.Five;

            Card cardThree = new Card();
            cardThree.CardSuit = CardSuites.Spades;
            cardThree.CardValue = CardValues.Seven;

            Card cardFour = new Card();
            cardFour.CardSuit = CardSuites.Clubs;
            cardFour.CardValue = CardValues.Four;

            Card cardFive = new Card();
            cardFive.CardSuit = CardSuites.Diamonds;
            cardFive.CardValue = CardValues.Six;

            Card cardSix = new Card();
            cardSix.CardSuit = CardSuites.Hearts;
            cardSix.CardValue = CardValues.Jack;

            Card cardSeven = new Card();
            cardSeven.CardSuit = CardSuites.Spades;
            cardSeven.CardValue = CardValues.Ace;

            Card cardEight = new Card();
            cardEight.CardSuit = CardSuites.Clubs;
            cardEight.CardValue = CardValues.Ten;

            Card cardNine = new Card();
            cardNine.CardSuit = CardSuites.Spades;
            cardNine.CardValue = CardValues.Two;

            Card cardTen = new Card();
            cardTen.CardSuit = CardSuites.Diamonds;
            cardTen.CardValue = CardValues.Eight;

            Card cardEleven = new Card();
            cardEleven.CardSuit = CardSuites.Clubs;
            cardEleven.CardValue = CardValues.Ace;




            Deck<Card> deck = new Deck<Card>();
            deck.Add(cardOne);
            deck.Add(cardTwo);
            deck.Add(cardThree);
            deck.Add(cardFour);
            deck.Add(cardFive);
            deck.Add(cardSix);
            deck.Add(cardSeven);
            deck.Add(cardEight);
            deck.Add(cardNine);
            deck.Add(cardTen);
            deck.Add(cardEleven);

            return deck;
            
        }

        public static void PrintAllCards(Deck<Card> deck)
        {
            Console.WriteLine("The Cards in the dearler's deck");
            for (int i = 0; i < deck.currentIndex; i++)
            {
                Console.Write($":{deck.internalItems[i].CardSuit} {deck.internalItems[i].CardValue}, ");
                
            }
        }

        public static void Deal(Deck<Card> deck)
        {
            Console.WriteLine("Player one deck: empty");
            Console.WriteLine("Player Two deck: empty");
            Console.WriteLine();
            Deck<Card> myDeck = PutCardsInDeck();
            PrintAllCards(myDeck);
            Console.WriteLine();
            Card[] playerOne = new Card[5];
            Console.WriteLine();
            Console.WriteLine("Player one cards");

            for (int i = 0; i < 5; i++)
            {
                playerOne[i] = deck.internalItems[i];
                Console.WriteLine($":{playerOne[i].CardSuit} {playerOne[i].CardValue}");


            }

            Console.WriteLine();
            Card[] playerTwo = new Card[5];
            Console.WriteLine("Player two cards");
            int counter = 0;  
            
            for (int i = 5; i < 10; i++)
            {
                
                playerTwo[counter] = deck.internalItems[i];
                Console.WriteLine($":{playerTwo[counter].CardSuit} {playerTwo[counter].CardValue}");
                counter++;
            }
            Console.WriteLine();
            Card[] LeftInDeck = new Card[5];
            int counter2 = 0;
            Console.WriteLine("Card left in dea;er's deck");
            

            for (int i = 10; i < 11; i++)
            {
                LeftInDeck[counter2] = deck.internalItems[i];
                Console.WriteLine($":{LeftInDeck[counter2].CardSuit} {LeftInDeck[counter2].CardValue}");
                counter2++;
            }
            Console.WriteLine();
        }

        public static void RemoveFromDeck(Deck<Card> deck)
        {
            for (int i = 0; i < deck.currentIndex; i++)
            {
                Console.Write($"{deck.internalItems[i].CardSuit} {deck.internalItems[i].CardValue}, ");

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Card to remove: {deck.internalItems[deck.currentIndex - 1].CardSuit} {deck.internalItems[deck.currentIndex - 1].CardValue}, ");
            deck.RemoveCards();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < deck.currentIndex; i++)
            {
                Console.Write($"{deck.internalItems[i].CardSuit} {deck.internalItems[i].CardValue}, ");

            }
            Console.WriteLine();

        }
         
    }
}
