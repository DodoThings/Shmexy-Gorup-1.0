using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.ComponentModel.Design;

public class GameManager : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public List<Card> discardPile = new List<Card>();
    public List<Card> hand = new List<Card>();

    public Transform[] cardSlots;
    public bool[] availbleCardSlots;

    public TextMeshProUGUI deckSizeText;
    public TextMeshProUGUI discardPileText;

    public int punch = 1;
    public int kick = 2;
    public int block = 1;
    public int dodge = 2;
    public int uppercut = 5;



    public void ActiveCards()
    {

    }


    public void DrawCard()
    {
        
        
            if (deck.Count >= 1)
            {
                Card randCard = deck[Random.Range(0, deck.Count)];
                Debug.Log("Cards Drawn");
                
                for (int i = 0; i < availbleCardSlots.Length; i++)
                {

                    if (availbleCardSlots[i] == (true))
                    {



                        randCard.gameObject.SetActive(true);
                        randCard.handIndex = i;

                        randCard.transform.position = cardSlots[i].position;
                        randCard.hasBeenPlayed = false;

                        availbleCardSlots[i] = false;
                        deck.Remove(randCard);
                        return;

                    }

                }
            }
            
        
    }

    public void Shuffle()
    {
        if(discardPile.Count >= 20)
        {
            foreach(Card card in discardPile)
            {
                deck.Add(card);
            }
            discardPile.Clear();

        }
    }
    
    private void Update()
    {
        deckSizeText.text = deck.Count.ToString();
        discardPileText.text = discardPile.Count.ToString();
    }

}

