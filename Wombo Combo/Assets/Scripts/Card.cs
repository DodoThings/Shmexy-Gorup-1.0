using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public bool hasBeenPlayed;

    public int handIndex;

    private GameManager gm;

    public int cardsUsed = 0;



    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    private void OnMouseDown()
    {
        if (cardsUsed < 3)
        {

            if (hasBeenPlayed == false)
            {

                transform.position += Vector3.up * 0.5f;
                hasBeenPlayed = true;
                gm.availbleCardSlots[handIndex] = true;
                

                Invoke("MoveToDiscardPile", 3f);

            }
            
        }
        
    }
    public void active()
    {
        if (hasBeenPlayed == true)
        {

        }
    }



    void MoveToDiscardPile()
    {
        gm.discardPile.Add(this);
        gameObject.SetActive(false);
    }
}
