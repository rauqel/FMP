using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BreadCheck : MonoBehaviour
{
    public GameObject breadObject;

    public GameObject noBread;
    public GameObject breadCollect;

    public bool gotBread;

    // Start is called before the first frame update
    void Start()
    {
        gotBread = false;

        noBread.SetActive(true);
        breadCollect.SetActive(false);
    }

    void OnMouseDown()
    {
        breadObject.SetActive(false);
        noBread.SetActive(false);
        breadCollect.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (!breadObject.activeSelf)
        {
            gotBread = true;
        }
    }
}
