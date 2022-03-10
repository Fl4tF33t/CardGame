using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    public GameObject handPanel = null;
    public GameObject playBoard = null;
    public GameObject[] manaBall = new GameObject[3];

    public bool isPlayable = false;

    public int turns = 1;
    public int manaAmount = 3;
    public Text turnScore = null;
    public int score = 0;

    private void Awake()
    {
        instance = this;

        playerDeck.Create();
        enemyDeck.Create();

        StartCoroutine(DealHands());
       
        
    }

    private void Update()
    {
        if (turns == 9)
        {
            SceneManager.LoadScene(1);
        }
        if (manaAmount == 1)
        {
            manaBall[0].SetActive(true);
            manaBall[1].SetActive(false);
            manaBall[2].SetActive(false);
            manaBall[3].SetActive(false);
        }
        else if (manaAmount == 2)
        {
            manaBall[0].SetActive(true);
            manaBall[1].SetActive(true);
            manaBall[2].SetActive(false);
            manaBall[3].SetActive(false);
        }
        else if (manaAmount == 3)
        {
            manaBall[0].SetActive(true);
            manaBall[1].SetActive(true);
            manaBall[2].SetActive(true);
            manaBall[3].SetActive(false);
        }
        else if (manaAmount == 4)
        {
            manaBall[0].SetActive(true);
            manaBall[1].SetActive(true);
            manaBall[2].SetActive(true);
            manaBall[3].SetActive(true);
        }
        else if (manaAmount == 0)
        {
            manaBall[0].SetActive(false);
            manaBall[1].SetActive(false);
            manaBall[2].SetActive(false);
            manaBall[3].SetActive(false);
        }
        
        turnScore.text = "Turn: " + turns + "   Score: " + score;
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
    }

    public void SkipTurn()
    {
        Debug.Log("EndTurn");
        // for (int i = 0; i < 5; i++)
        //{
        //  playerHand.cards[i] = null;
        //}
        //GameObject.Destroy(playerHand.cards[1]);
        handPanel = GameObject.Find("HandPanel");
        foreach(Transform child in handPanel.transform)
        {
            Destroy(child.gameObject);
        }
        
        StartCoroutine(DealHands());
        manaAmount = 3;
        turns++;
    }

    internal IEnumerator DealHands()
    {
        yield return new WaitForSeconds(1);
        for (int t = 0; t < 5; t++)
        {
            playerDeck.DealCard(playerHand);
           // enemyDeck.DealCard(enemyHand);
            yield return new WaitForSeconds(1);
        }
        isPlayable = true;
        
    }

}
