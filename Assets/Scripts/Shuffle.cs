using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffle : MonoBehaviour
{
    public List<string> deck = new List<string>();
    public List<string> hand = new List<string>();
    public List<int> usedNumbers = new List<int>();


    public int x;
    public int deckSize;
    
    
    // Start is called before the first frame update
    void Start()
    {
        #region mordor
        deck.Add("+1/+1 to all fire");
        deck.Add("+1/+1 to all water");
        deck.Add("+1/+1 to all grass");
        deck.Add("1 mana fire");
        deck.Add("2 mana fire");
        deck.Add("3 mana fire");
        deck.Add("4 mana fire");
        deck.Add("1 mana water");
        deck.Add("2 mana water");
        deck.Add("3 mana water");
        deck.Add("4 mana water");
        deck.Add("1 mana grass");
        deck.Add("2 mana grass");
        deck.Add("3 mana grass");
        deck.Add("4 mana grass");
        deck.Add("SUMMON");
        deck.Add("active: +1/+1");
        deck.Add("active: hand size +1");
        deck.Add("active: keep a card");
        deck.Add("active: +1 mana");
        deck.Add("if all same colour, unlock");
        x = 0;
        deckSize = 20; 
        #endregion

        for (int i = 0; i < 5; i++)
        {
            x = Random.RandomRange(0, deck.Count);
            while (usedNumbers.Contains(x))
            {
                x = Random.RandomRange(0, deck.Count);
            }
            hand.Add(deck[x]);
            usedNumbers.Add(x);
        }
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(hand[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
