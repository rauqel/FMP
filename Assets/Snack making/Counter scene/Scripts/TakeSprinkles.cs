using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeSprinkles : MonoBehaviour
{
    public GameObject sprinkleJar;
    public Collider2D sprinkleCollider;
    public Sprite sprinklePour;
    public Sprite breadSprinkles;

    int pourCount = 0;

    bool pickedUp = false;

    public TakeBread breadScript;
    public TakeKnife knifeScript;

    void Update()
    {
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
        }

        //
        if (pourCount != 0)
        {
            breadScript.breadSlice.GetComponent<SpriteRenderer>().sprite = breadSprinkles;
            //SceneManager.LoadScene("MainScene");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bread")
        {
            if (knifeScript.breadButtered)
            {
                sprinkleJar.GetComponent<SpriteRenderer>().sprite = sprinklePour;
                pourCount += 1;
            }
        }
    }
}