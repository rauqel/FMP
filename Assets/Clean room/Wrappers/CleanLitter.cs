using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanLitter : MonoBehaviour
{
    public GameObject wrapperTwo;
    public GameObject wrapperThree;

    Vector3 cleanWrapper;
    Vector3 cleanWrapper2;
    Vector3 cleanWrapper3;

    public bool wrappersCleaned;
    bool wrapper1;
    bool wrapper2;
    bool wrapper3;

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
            wrapper1 = true;
        }
        else if (gameObject.tag == "WrapperTwo")
        {
            gameObject.transform.position = cleanWrapper2;
            wrapper2 = true;
        }
        else if (gameObject.tag == "WrapperThree")
        {
            gameObject.transform.position = cleanWrapper3;
            wrapper3 = true;
        }
    }

    void Update()
    {
       if(wrapper1 && wrapper2 && wrapper3)
        {
            wrappersCleaned = true;
        } 
    }
}
