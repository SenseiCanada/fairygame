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

    public static event Action<ConceptCollectionNotifier> OnConceptCollected;

    [SerializeField]
    public string conceptName;
    public int slotTag;


    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (OnConceptCollected != null)
        {
            conceptObject = this.gameObject;
            //conceptObject.SetActive(false);
            OnConceptCollected(this);
            
        }
    }

}
