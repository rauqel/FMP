using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ButterCheck : MonoBehaviour
{
    public GameObject butterObject;

    public GameObject noButter;
    public GameObject butterCollect;

    // Start is called before the first frame update
    void Start()
    {
        noButter.SetActive(true);
        butterCollect.SetActive(false);
    }
    
    void OnMouseDown()
    {
        butterObject.SetActive(false);
        noButter.SetActive(false);
        butterCollect.SetActive(true);
    }
}
