using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Concept_ChildLaughter : Concept
{
    // Start is called before the first frame update
    void Start()
    {
        conceptName = "Child's Laughter";
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnMouseDown()
    {
        conceptObject = GameObject.Find("Child's Laughter");
        AddConcept(conceptObject);
        
    }
}
