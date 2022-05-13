using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskClean : MonoBehaviour
{
    public Sprite cleanVer;
    public bool cleanedDesk;
    public void cleanDesk()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = cleanVer;
        //Change above script to access the sourceimage instead of sprite, lesson ended before i could.
        cleanedDesk = true;
    }
}
