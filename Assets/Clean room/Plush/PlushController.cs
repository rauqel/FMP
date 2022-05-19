/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlushController : MonoBehaviour
{
    public BedClean bedScript;
    public Text errorMsg;

    bool oneDestroyed;
    public GameObject oneButton;
    public GameObject oneClean;

    bool twoDestroyed;
    public GameObject twoButton;
    public GameObject twoClean;

    bool threeDestroyed;
    public GameObject threeButton;
    public GameObject threeClean;

    bool fourDestroyed;
    public GameObject fourButton;
    public GameObject fourClean;

    public bool plushCleaned;

    public void DestroyOne()
    {
        if (bedScript.bedCleaned)
        {
            Destroy(oneButton);
            oneDestroyed = true;
            errorMsg.enabled = false;
        }
        else
        {
            errorMsg.enabled = true;
        }
    }
    public void DestroyTwo()
    {
        if (bedScript.bedCleaned)
        {
            Destroy(twoButton);
            twoDestroyed = true;
            errorMsg.enabled = false;
        }
        else
        {
            errorMsg.enabled = true;
        }
    }
    public void DestroyThree()
    {
        if (bedScript.bedCleaned)
        {
            Destroy(threeButton);
            threeDestroyed = true;
            errorMsg.enabled = false;
        }
        else
        {
            errorMsg.enabled = true;
        }
    }
    public void DestroyFour()
    {
        if (bedScript.bedCleaned)
        {
            Destroy(fourButton);
            fourDestroyed = true;
            errorMsg.enabled = false;
        }
        else
        {
            errorMsg.enabled = true;
        }
    }

    private void Start()
    {
        oneClean.SetActive(false);
        twoClean.SetActive(false);
        threeClean.SetActive(false);
        fourClean.SetActive(false);
        errorMsg.enabled = false;
    }

    void Update()
    {
        if (oneDestroyed)
        {
            oneClean.SetActive(true);
        }
        if (twoDestroyed)
        {
            twoClean.SetActive(true);
        }
        if (threeDestroyed)
        {
            threeClean.SetActive(true);
        }
        if (fourDestroyed)
        {
            fourClean.SetActive(true);
        }
        if(oneDestroyed && twoDestroyed && threeDestroyed && fourDestroyed)
        {
            plushCleaned = true;
        }
    }
}*/
