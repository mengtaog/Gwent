using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DeckController : MonoBehaviour
{
    public Text deckText;
    public List<Card> deck = new List<Card>();
    public int cardNums;
    // Start is called before the first frame update
    private void Awake()
    {
        cardNums = 20;
    }

    void Start()
    {
        int index;
        for(int i = 0; i < cardNums; ++i)
        {
            index = Random.Range(0, 6);
            deck.Add(CardDatabase.cardList[index]);
            //print(deck[i].cardName);
        }
    }

   
    public Card PopCard()
    {
        
        Card card = deck[deck.Count - 1];
        deck.Remove(deck[deck.Count - 1]);
        if(cardNums > 0) cardNums--;
        UpdateText();
        return card;
    }

    private void Shuffle()
    {
        for(int i = cardNums-1; i > 0; --i)
        {
            Card tmp = deck[i];
            int current = Random.Range(0, i + 1);
            deck[i] = deck[current];
            deck[current] = tmp;
        }
    }

    private void UpdateText()
    {
        deckText.text = cardNums.ToString();
    }

    private void printCard()
    {
        if(deck.Count > 0)
        {
            foreach (Card i in deck)
            {
                print(i.cardName);
            }
        }
    }
}
