using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkTrigger : MonoBehaviour
{
    public Transform playerTransform;
    [SerializeField] float smallScale = 0.5f;
    private float playerScaleX;
    private float playerScaleY;

    // Start is called before the first frame update
    void Start()
    {
        playerScaleX = playerTransform.localScale.x;
        playerScaleY = playerTransform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerTransform.localScale = new Vector2(playerScaleX*smallScale, playerScaleY*smallScale);
        }
    }
}
