using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int hitsToKill;
    public int points;
    private int numberOfHits;
    private SpriteRenderer myspriteRenderer;
     
    string Block_Square;

    private void Start()
    {
        myspriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ball")
        {

            numberOfHits++;

            if (numberOfHits == hitsToKill +1)
            {
                
            }
            if (numberOfHits == hitsToKill)
            {
                // destroy the object
                Destroy(this.gameObject);
            }
            Debug.Log(collision.gameObject.name);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        

    }
}
