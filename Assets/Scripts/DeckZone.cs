using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = UnityEngine.Random;

public class DeckZone : MonoBehaviour
{
    [SerializeField] private List<GameObject> deck = new List<GameObject>();
    [SerializeField] private GameObject hand;
    [SerializeField] private Transform[] cardSlots;
    private bool[] availableCardsSlots;

    private void OnMouseDown()
    {
        DrawCard();
    }

    // Start is called before the first frame update
    void Start()
    {
        availableCardsSlots = new bool[cardSlots.Length];
        for (int i = 0; i < availableCardsSlots.Length; i++)
        {
            availableCardsSlots[i] = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void DrawCard()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (deck.Count >= 1)
            {
                var toDraw = Random.Range(0, deck.Count - 1);
                Debug.Log(toDraw);
                GameObject card = Instantiate(deck[toDraw], hand.transform);
                for (int i = 0; i < availableCardsSlots.Length; i++)
                {
                    if (availableCardsSlots[i])
                    {
                        availableCardsSlots[i] = false;
                        card.transform.position = cardSlots[i].transform.position;
                        deck.Remove(deck[toDraw]);
                        return;
                    }
                }
            }
        }
    }
}