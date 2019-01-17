using System;
using Xunit;
using Collections;
using Collections.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CardOneWorks()
        {
            //Arrange
            Card cardOne = new Card();
            cardOne.CardSuit = CardSuites.Hearts;
            cardOne.CardValue = CardValues.Ace;

            Card cardTwo = new Card();
            cardTwo.CardSuit = CardSuites.Diamonds;
            cardTwo.CardValue = CardValues.Five;

            //act
            Deck<Card> deck = new Deck<Card>();
            deck.Add(cardOne);
            deck.Add(cardTwo);
            //assert

            Assert.Contains(cardOne, deck.internalItems);
        }

        [Fact]
        public void CardTwoWorks()
        {
            //Arrange
            Card cardOne = new Card();
            cardOne.CardSuit = CardSuites.Hearts;
            cardOne.CardValue = CardValues.Ace;

            Card cardTwo = new Card();
            cardTwo.CardSuit = CardSuites.Diamonds;
            cardTwo.CardValue = CardValues.Five;

            //act
            Deck<Card> deck = new Deck<Card>();
            deck.Add(cardOne);
            deck.Add(cardTwo);
            //assert

            Assert.Contains(cardTwo, deck.internalItems);
        }

        [Fact]
        public void GetSetWorks()
        {
            //Arrange
            Card cardOne = new Card();
            cardOne.CardSuit = CardSuites.Hearts;
            cardOne.CardValue = CardValues.Ace;

            Card cardTwo = new Card();
            cardTwo.CardSuit = CardSuites.Diamonds;
            cardTwo.CardValue = CardValues.Five;
            var heart = cardOne.CardSuit;
            //act
            Deck<Card> deck = new Deck<Card>();
            deck.Add(cardOne);
            deck.Add(cardTwo);
            //assert

            Assert.Equal(heart, cardOne.CardSuit);
        }

        
    }
}
