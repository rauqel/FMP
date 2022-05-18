using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Biting : MonoBehaviour
{
    public Bread2UIscript breadScript;
    public GameObject breadEmpty;

    public Sprite bOne;
    public Sprite bTwo;
    public Sprite bThree;
    public Sprite bFour;
    public Sprite bFive;
    public Sprite bSix;
    public Sprite bSeven;
    public Sprite bEight;
    public Sprite bNine;
    public Sprite bTen;
    public Sprite bEleven;
    public Sprite bTwelve;
    public Sprite bThirteen;
    public Sprite bFourteen;
    public Sprite bFifteen;
    public Sprite bSixteen;
    public Sprite bSeventeen;
    public Sprite bEighteen;
    public Sprite bNineteen;
    public Sprite bTwenty;
    public Sprite bTwentyOne;
    public Sprite bTwentyTwo;

    public int biteCounter = 0;

    public void BreadBites()
    {
        if (breadScript.sprinklesOn)
        {
            biteCounter += 1;
        }
    }

    public void Update()
    {
        if(biteCounter == 1)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bOne;
        }
        if (biteCounter == 2)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bTwo;
        }
        if (biteCounter == 3)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bThree;
        }
        if (biteCounter == 4)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bFour;
        }
        if (biteCounter == 5)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bFive;
        }
        if (biteCounter == 6)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bSix;
        }
        if (biteCounter == 7)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bSeven;
        }
        if (biteCounter == 8)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bEight;
        }
        if (biteCounter == 9)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bNine;
        }
        if (biteCounter == 10)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bTen;
        }
        if (biteCounter == 11)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bEleven;
        }
        if (biteCounter == 12)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bTwelve;
        }
        if (biteCounter == 13)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bThirteen;
        }
        if (biteCounter == 14)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bFourteen;
        }
        if (biteCounter == 15)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bFifteen;
        }
        if (biteCounter == 16)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bSixteen;
        }
        if (biteCounter == 17)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bSeventeen;
        }
        if (biteCounter == 18)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bEighteen;
        }
        if (biteCounter == 19)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bNineteen;
        }
        if (biteCounter == 20)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bTwenty;
        }
        if (biteCounter == 21)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bTwentyOne;
        }
        if (biteCounter == 22)
        {
            breadScript.gameObject.GetComponent<Image>().sprite = bTwentyTwo;
        }
        if (biteCounter == 23)
        {
            Destroy(breadEmpty);
            //SceneManager.LoadScene("MainScene");
        }
    }
}
