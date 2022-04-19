using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadCheck : MonoBehaviour
{
    public GameObject breadObject;

    public GameObject noBread;
    public GameObject breadCollect;

    // Start is called before the first frame update
    void Start()
    {
        noBread.SetActive(true);
        breadCollect.SetActive(false);
    }

    void OnMouseDown()
    {
        breadObject.SetActive(false);
        noBread.SetActive(false);
        breadCollect.SetActive(true);
    }
}
