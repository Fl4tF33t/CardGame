using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCard : MonoBehaviour
{
    GameObject card;

    void Start()
    {
        card = GameObject.Find("Card");
    }
    public void DeleteCards()
    {
        Destroy(card);
    }
}
