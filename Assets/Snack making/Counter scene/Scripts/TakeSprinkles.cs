using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeSprinkles : MonoBehaviour
{
    bool pickedUp = false;
    bool sprinklesOn = false;
    public Collider2D sprinkleCollider;

    public GameObject sprinkleJar;
    public Sprite sprinkleInHand;
    public GameObject breadSprinkles;

    public TakeBread breadScript;
    public TakeKnife knifeScript;
    void Update()
    {
        if (sprinklesOn)
        {
            breadSprinkles.SetActive(true);
        }
        else
        {
            breadSprinkles.SetActive(false);
        }

        //
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (breadScript.breadActive)
            {
                if (pickedUp == false)
                {
                    Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);

                    //Debug.Log(targetObject.gameObject.name);

                    if (targetObject == sprinkleCollider)
                    {
                        pickedUp = true;
                    }
                }
                else
                {
                    pickedUp = false;
                }
            }
            else
            {
                pickedUp = false;
            }
        }

        if (pickedUp)
        {
            transform.position = mousePosition;


            sprinkleJar.GetComponent<SpriteRenderer>().sprite = sprinkleInHand;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bread")
        {
            if (knifeScript.breadButtered)
            {
                sprinklesOn = true;
            }
            else
            {
                sprinklesOn = false;
                //otherstuff to do with ERROR MESSAGES and such
            }
        }
    }
}
