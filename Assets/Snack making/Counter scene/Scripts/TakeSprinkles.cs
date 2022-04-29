using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeSprinkles : MonoBehaviour
{
    public GameObject sprinkleJar;
    public Collider2D sprinkleCollider;
    public Sprite sprinkleInHand;
    public GameObject breadSprinkles;

    bool pickedUp = false;
    bool sprinklesOn;

    public TakeBread breadScript;
    public TakeKnife knifeScript;

    private void Start()
    {
        breadSprinkles.SetActive(false);
    }

    void Update()
    {
        Vector2 mousePosition = Camera.main.WorldToScreenPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (breadScript.breadActive && knifeScript.butteredKnife)
            {
                if (!pickedUp)
                {
                    Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);

                    Debug.Log(targetObject.gameObject.name);

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
        if (pickedUp)
        {
            sprinkleJar.GetComponent<SpriteRenderer>().sprite = sprinkleInHand;

            if (Input.GetMouseButtonDown(0))
            {
                Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);

                if(targetObject == breadScript.breadSlice)
                {
                    sprinklesOn = true;
                }
            }
        }

        if (sprinklesOn)
        {
            breadSprinkles.SetActive(true);
            //SceneManager.LoadScene()
        }
    }
}
