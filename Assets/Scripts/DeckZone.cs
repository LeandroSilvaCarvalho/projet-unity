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
    private void OnMouseDown()
    {
        DrawCard();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void DrawCard()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Clicked");
            var toDraw = Random.Range(0, deck.Count-1);
            Debug.Log(toDraw);
            GameObject card = Instantiate(deck[toDraw],hand.transform);
            deck.Remove(deck[toDraw]);
            //card.transform.SetParent(hand.transform);
        }
    }
}
