using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeBread : MonoBehaviour
{
    public Collider2D loafCollider;
    public Collider2D sliceCollider;

    public GameObject breadLoaf;
    public GameObject breadSlice;

    //public Animator SliceToLife;

    bool dragging = false;
    public bool breadActive;

    // Start is called before the first frame update
    void Start()
    {
        breadSlice.SetActive(false);

        //SliceToLife = breadSlice.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        breadSlice.SetActive(true);
        //SliceToLife.Play("BreadCollect");
    }

    // Update is called once per frame
    void Update()
    {
        if (breadSlice.activeSelf)
        {
            breadActive = true;
        }

        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (!dragging)
            {
                Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);

                if (targetObject == loafCollider)
                {
                    breadSlice.SetActive(true);
                    dragging = true;
                }
            }
            else
            {
                dragging = false;
            }
        }

        if(dragging)
        {
            sliceCollider.transform.position = mousePosition;
        }
    }
}
