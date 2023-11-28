using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ConceptCollectionNotifier : MonoBehaviour
{
    public GameObject conceptObject;
    public Sprite conceptIcon;
    public bool isInInventory = false;

    public static event Action<ConceptCollectionNotifier> OnConceptCollected;
    public static event Action<ConceptCollectionNotifier> OnConceptTraded;


    [SerializeField]
    public string conceptName;
    public string conceptMechanic;
    public int slotTag;


    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (OnConceptCollected != null)
        {
            conceptObject = this.gameObject;
            //conceptObject.SetActive(false);
            OnConceptCollected(this);
            this.isInInventory = true;
            
        }
    }

    public void OnTradeButton1Click()
    {
        if (conceptObject.CompareTag("Slot1"))
        {
            conceptObject = this.gameObject;
            OnConceptTraded(this);
        }
        
    }



    

}
