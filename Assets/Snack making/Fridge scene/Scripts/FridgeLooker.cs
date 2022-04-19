using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeLooker : MonoBehaviour
{
    public GameObject bottom;
    public GameObject top;

    Vector3 pos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos = new Vector3(transform.position.x, top.transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos = new Vector3(transform.position.x, bottom.transform.position.y, transform.position.z);
        }

        if (transform.position.y != pos.y)
        {
            transform.position = Vector3.Lerp(transform.position, pos, (Time.deltaTime / 2));
        }
    }
}
