using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarCompletion : MonoBehaviour
{
    Image completionBar;

    public Bread2UIscript bread2Check;
    public BreadUIscript breadCheck;
    public KnifeUIscript knifeCheck;
    public SprinkleUIscript sprinkleCheck;

    float progress = 0f;
    float currentProgress1 = 0f;
    float currentProgress2 = 0f;
    bool progressAdded1;
    bool counterAdded1;
    int counter;

    void Start()
    {
        completionBar = GetComponent<Image>();
    }

    void Update()
    {
        if (breadCheck.breadSlice.activeSelf)
        {
            if (!counterAdded1)
            {
                counter += 1;
                counterAdded1 = true;
            }
        }
        if (knifeCheck.knifeButtered)
        {
            counter += 1;
        }
        if (bread2Check.butterOn)
        {
            counter += 1;
        }
        if (bread2Check.sprinklesOn)
        {
            counter += 1;
        }
        Debug.Log(counter);
        completionBar.fillAmount = Mathf.Lerp(0f, 1.0f, progress);

        if (counter == 1)
        {
            if (progress < currentProgress1 + 0.25f)
            {
                progress += Time.deltaTime / 3.5f;
                //progressAdded1 = true;
            }
        }
        if (knifeCheck.knifeButtered)
        {
            if (progress < currentProgress2 + 0.25f)
            {
                progress += Time.deltaTime / 3.5f;
                //progressAdded2 = true;
            }
        }
    }
}
