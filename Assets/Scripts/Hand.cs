using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Hand
{
    public Card[] cards = new Card[5];
    public Transform[] positions = new Transform[5];
    public string[] animNames = new string[5];
    public bool isPlayers;
}
