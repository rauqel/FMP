using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LitterController : MonoBehaviour
{
    public bool litterCleaned;

    public W1 w1;
    bool oneDestroyed; 
    public GameObject cleaned1;

    public W2 w2;
    bool twoDestroyed;
    public GameObject cleaned2;

    public W3 w3;
    bool threeDestroyed;
    public GameObject cleaned3;

    private void Start()
    {
        cleaned1.SetActive(false);
        cleaned2.SetActive(false);
        cleaned3.SetActive(false);
    }
    void Update()
    {
        if (w1.pressed1)
        {
            oneDestroyed = true;
            if (oneDestroyed) 
            {
                cleaned1.SetActive(true);
            }
        }
        if (w2.pressed2)
        {
            twoDestroyed = true;
            if (twoDestroyed)
            {
                cleaned2.SetActive(true);
            }
        }
        if (w3.pressed3)
        {
            threeDestroyed = true;
            if (threeDestroyed)
            {
                cleaned3.SetActive(true);
            }
        }

        if(oneDestroyed && twoDestroyed && threeDestroyed)
        {
            litterCleaned = true;
        }
    }
}
