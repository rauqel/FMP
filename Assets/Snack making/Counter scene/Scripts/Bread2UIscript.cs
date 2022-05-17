using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//script for the image changing of the bread
public class Bread2UIscript : MonoBehaviour
{
    public KnifeUIscript knifeScript;

    bool butterOn;
    bool sprinlesOn;

    public Sprite butteredBread;
    public Sprite sprinkledBread;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == ("Knife"))
        {
            if (knifeScript.knifeButtered)
            {
                gameObject.GetComponent<Image>().sprite = butteredBread;
                knifeScript.gameObject.GetComponent<Image>().sprite = knifeScript.normalKnife;
                knifeScript.knifeNormal = true;
                knifeScript.knifeButtered = false;
                butterOn = true;
            }
        }
        if(collision.gameObject.name == ("Sprinkle jar"))
        {
            if (butterOn)
            {
                gameObject.GetComponent<Image>().sprite = sprinkledBread;
            }
        }
    }
}
