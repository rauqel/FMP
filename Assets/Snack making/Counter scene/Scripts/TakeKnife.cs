using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeKnife : MonoBehaviour
{
    //knife dragging
    bool dragging = false;
    public Collider2D knifeCollider;

    public GameObject knifeObject;
    public Sprite butteredKnife;

    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (dragging == false)
            {
                Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);

                //Debug.Log(targetObject.gameObject.name);

                if (targetObject == knifeCollider)
                {
                    dragging = true;
                }
            }
            else
            {
                dragging = false;
            }
        }

        if (dragging)
        {
            transform.position = mousePosition;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Butter")
        {
            knifeObject.GetComponent<SpriteRenderer>().sprite = butteredKnife;
        }
    }
}