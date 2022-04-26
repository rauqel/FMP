using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeKnife : MonoBehaviour
{
    //knife
    public GameObject knifeObject;
    public Collider2D knifeCollider;
    bool dragging = false;

    public Sprite butteredKnife;
    public Sprite normalKnife;

    bool buttered;

    //bread
    public GameObject breadObject;
    public Sprite butteredBread;

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (!dragging)
        {
            if (Input.GetMouseButton(0))
            {
                Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);

                if (targetObject == knifeCollider)
                {
                    dragging = true;
                    targetObject.transform.position = mousePosition;
                }
            }
        }
        if (dragging)
        {
            dragging = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Butter")
        {
            knifeObject.GetComponent<SpriteRenderer>().sprite = butteredKnife;
            buttered = true;
        }

        if(collision.gameObject.tag == "Bread")
        {
            if (buttered)
            {
                knifeObject.GetComponent<SpriteRenderer>().sprite = normalKnife;
                breadObject.GetComponent<SpriteRenderer>().sprite = butteredBread;
                buttered = false;
            }
        }
    }
}
