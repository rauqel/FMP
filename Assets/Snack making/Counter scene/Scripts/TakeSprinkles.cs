using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TakeSprinkles : MonoBehaviour
{
    public GameObject sprinkleJar;
    public Collider2D sprinkleCollider;
    public Sprite sprinklePour;
    public Image breadSprinkles;

    float pourTime = 0f;
    int pourCount = 0;
    bool pourValid;
    bool pouring;

    bool pickedUp = false;
    bool sprinklesOn;

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
        if (pourCount == 0)
        {
            pourValid = true;
        }
        else
        {
            pourValid = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bread")
        {
            if (knifeScript.breadButtered)
            {
                sprinkleJar.GetComponent<SpriteRenderer>().sprite = sprinklePour;

                //
                if (pourValid)
                {
                    pourTime += Time.deltaTime;
                    if (pourTime >= 1.4 && pourTime <= 2.5)
                    {
                        pourCount += 1;
                        pouring = true;
                        if (pouring)
                        {
                            Debug.Log("pouring");
                            breadSprinkles.fillAmount += 1.0f / 2.3f * Time.deltaTime;
                        }
                        pourValid = false;
                    }
                }
            }
        }
    }
}
