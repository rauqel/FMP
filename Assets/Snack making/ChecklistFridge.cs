using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecklistFridge : MonoBehaviour
{
    public bool gotBread;
    public bool gotButter;
    private void OnMouseDown()
    {
        if(gameObject.tag == "Bread")
        {
            Destroy(gameObject);
            gotBread = true;
        }
        if(gameObject.tag == "Butter")
        {
            Destroy(gameObject);
            gotButter = true;
        }
    }
}
