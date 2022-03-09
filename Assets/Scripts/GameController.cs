using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    static public GameController instance = null;
    public Deck playerDeck = new Deck();
    public Deck enemyDeck = new Deck();

    public Hand playerHand = new Hand();
    public Hand enemyHand = new Hand();

    public List<CardData> cards = new List<CardData>();


    public Sprite[] healthNumbers = new Sprite[10];
    public Sprite[] damageNumbers = new Sprite[10];

    public GameObject cardPrefab = null;
    public Canvas canvas = null;

    private void Awake()
    {
        instance = this;

        playerDeck.Create();
        enemyDeck.Create();

        StartCoroutine(DealHands());
    }
    public void Quit()
    {
        SceneManager.LoadScene(0);
    }

    public void SkipTurn()
    {
        Debug.Log("SkipTurn");
    }

    internal IEnumerator DealHands()
    {
        yield return new WaitForSeconds(1);

        for (int t = 0; t < 7; t++)
        {
            playerDeck.DealCard(playerHand);
            //enemyDeck.DealCard(enemyHand);
            yield return new WaitForSeconds(1);
            Debug.Log(t);
        }

    }

}
