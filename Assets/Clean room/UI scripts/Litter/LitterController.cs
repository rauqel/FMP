using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LitterController : MonoBehaviour
{
    public W1 w1;
    bool oneDestroyed; 
    public Image cleaned1;

    public W2 w2;
    bool twoDestroyed;
    public Image cleaned2;

    public W3 w3;
    bool threeDestroyed;
    public Image cleaned3;

    void Update()
    {
        if (w1.pressed1)
        {
            oneDestroyed = true;
            if (oneDestroyed) 
            {
            }
        }
        if (w2.pressed2)
        {
            twoDestroyed = true;
            /*if (twoDestroyed)
            {
                code;
            }*/
        }
        if (w3.pressed3)
        {
            threeDestroyed = true;
            /*if (threeDestroyed)
            {
                code;
            }*/
        }
    }
}
