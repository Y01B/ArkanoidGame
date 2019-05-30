using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int hitsToKill;
    public int points;
    private int numberOfHits = 0;
    private SpriteRenderer myspriteRenderer;
    public Sprite BlockBroken1;
    public Sprite BlockBroken2;


    private void Start()
    {
        myspriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ball")
        {


            numberOfHits++;

            //switch (numberOfHits)
            // {
            //  case 1:
            //myspriteRenderer.sprite = BlockBroken1;
            //  Destroy(this.gameObject);
            //  break;
            // case 2:

            //  break;
            //  default:
            //  break;
            //gameObject.SetActive(true);


            if (numberOfHits == 1)
            {
                myspriteRenderer.sprite = BlockBroken1;
            }
            if (numberOfHits == 2)
            {
                myspriteRenderer.sprite = BlockBroken2;
            }
            if (numberOfHits == hitsToKill)
            {
                //destroy the object
                Destroy(this.gameObject);

            }
            Debug.Log(collision.gameObject.name);
        }
    }


    }

    



