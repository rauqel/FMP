using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanLitter : MonoBehaviour
{
    Vector3 cleanWrapper;
    Vector3 cleanWrapper2;
    Vector3 cleanWrapper3;

    void Start()
    {
        cleanWrapper = new Vector3(1.826f, 3.815f, -2);
        cleanWrapper2 = new Vector3(1.622f, 3.982f, -2);
        cleanWrapper3 = new Vector3(1.838f, 4.124f, -2);
    }

    void OnMouseDown()
    {
        if (gameObject.tag == "WrapperOne")
        {
            gameObject.transform.position = cleanWrapper;
        }
        else if (gameObject.tag == "WrapperTwo")
        {
            gameObject.transform.position = cleanWrapper2;
        }
        else if (gameObject.tag == "WrapperThree")
        {
            gameObject.transform.position = cleanWrapper3;
        }
    }
}
