using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlushController : MonoBehaviour
{
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
        Destroy(oneButton);
        oneDestroyed = true;
    }
    public void DestroyTwo()
    {
        Destroy(twoButton);
        twoDestroyed = true;
    }
    public void DestroyThree()
    {
        Destroy(threeButton);
        threeDestroyed = true;
    }
    public void DestroyFour()
    {
        Destroy(fourButton);
        fourDestroyed = true;
    }

    private void Start()
    {
        oneClean.SetActive(false);
        twoClean.SetActive(false);
        threeClean.SetActive(false);
        fourClean.SetActive(false);
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
}
