using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Hand
{
    public Card[] cards = new Card[5];
    public Transform[] positions = new Transform[5];
    public Transform[] playPositions = new Transform[5];
    public string[] animNames = new string[5];
    public bool isPlayers;

    public void BurnCard(Card card)
    {
        for(int i=0; i<5; i++)
        {
            if(cards[i] == card)
            {
                GameObject.Destroy(cards[i].gameObject);
                cards[i] = null;
                GameController.instance.playerDeck.DealCard(this);
                break;
            }
        }
    }

    public void PlayCard(Card card)
    {
        for (int i = 0; i < 5; i++)
        {
            if (cards[i] == card)
            {
                cards[i] = null;
                GameController.instance.playerDeck.DealCard(this);
                break;
            }
        }
    }
}
