using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class KnifeUIscript : MonoBehaviour, IDragHandler
{
    public GameObject knifeObject;
    public Collider2D knifeCollider;

    bool dragging;

    RectTransform rt;

    public void Start()
    {
        rt = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        rt.position = Input.mousePosition; 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == ("Hey"))
        {
            Debug.Log("working");
        }
    }
}
