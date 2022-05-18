using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarCompletion : MonoBehaviour
{
    public Image completionBar;

    float knifePU = 0.25f;
    float butterOn = 0.25f;
    float sprinklePU = 0.25f;
    float sprinklesOn = 0.25f;

    public Bread2UIscript breadCheck;

    void Start()
    {
        completionBar.fillAmount = 0;  
    }

    void Update()
    {
        if (breadCheck.butterOn)
        {
            if(completionBar.fillAmount < 0.5f)
            {
                completionBar.fillAmount += butterOn / 1 * Time.deltaTime;
            }
            else
            {
                completionBar.fillAmount = 0.5f;
            }
        }
    }
}
