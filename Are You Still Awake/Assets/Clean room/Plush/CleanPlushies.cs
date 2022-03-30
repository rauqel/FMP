using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CleanPlushies : MonoBehaviour
{
    public CleanBed allowPlushie;

    Vector3 plush1;
    Vector3 plush2;
    Vector3 plush3;
    Vector3 plush4;

    public GameObject text;

    void Start()
    {
        plush1 = new Vector3(-7.17f, 3.7f, -1f);
        plush2 = new Vector3(-6.6f, 3.75f, -1f);
        plush3 = new Vector3(-6.08f, 3.75f, -1f);
        plush4 = new Vector3(-5.52f, 3.82f, -1f);

        text.SetActive(false);
    }

    void OnMouseDown()
    {
        if (allowPlushie.bedCleaned == false)
        {
            text.SetActive(true);
        }
        else if(allowPlushie.bedCleaned == true)
        {
            text.SetActive(false);
            if (gameObject.tag == "plushOne")
            {
                gameObject.transform.position = plush1;
            }
            else if (gameObject.tag == "plushTwo")
            {
                gameObject.transform.position = plush2;
            }
            else if (gameObject.tag == "plushThree")
            {
                gameObject.transform.position = plush3;
            }
            else if (gameObject.tag == "plushFour")
            {
                gameObject.transform.position = plush4;
            }
        }
    }
}
