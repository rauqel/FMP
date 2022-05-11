using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LitterController : MonoBehaviour
{
    public W1 w1;
    public Button wrapper1;
    public Image cleaned1;

    public W2 w2;
    public Button wrapper2;
    public Image cleaned2;

    public W3 w3;
    public Button wrapper3;
    public Image cleaned3;

    private void Start()
    {
        cleaned1.SetEnabled(false);
        cleaned2.SetEnabled(false);
        cleaned3.SetEnabled(false);
    }
    void Update()
    {
        if (!w1.gameObject)
        {
            cleaned1.SetEnabled(true);
        }
    }
}
