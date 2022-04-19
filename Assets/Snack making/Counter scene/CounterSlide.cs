using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterSlide : MonoBehaviour
{
    public GameObject left;
    public GameObject right;

    Vector3 look;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            look = new Vector3(left.transform.position.x, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            look = new Vector3(right.transform.position.x, transform.position.y, transform.position.z);
        }

        if (transform.position.x != look.x)
        {
            transform.position = Vector3.Lerp(transform.position, look, (Time.deltaTime / 2));
        }
    }
}
