using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class FridgeChecklist : MonoBehaviour
{
    public GameObject mainText;

    public GameObject noBread;
    public GameObject noButter;

    public GameObject breadCollect;
    public GameObject butterCollect;
    bool butterClicked;
    bool breadClicked;

    public GameObject breadObject;
    public GameObject butterObject;

    float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        mainText.SetActive(true);
        noBread.SetActive(true);
        noButter.SetActive(true);

        breadCollect.SetActive(false);
        butterCollect.SetActive(false);
    }

    void OnMouseDown()
    {
        if(gameObject.tag == "Bread")
        {
            Destroy(gameObject);
            noBread.SetActive(false);
            breadCollect.SetActive(true);
            breadClicked = true;
        }
        if (gameObject.tag == "Butter")
        {
            Destroy(gameObject);
            noButter.SetActive(false);
            butterCollect.SetActive(true);
            butterClicked = true;
        }
    }

    void Update()
    {
        if (butterClicked == true && breadClicked == true)
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
            if (timer >= 2.0f && timer <= 3.0f)
            {
                SceneManager.LoadScene("SnackCOUNTER");
            }
        }
    }
}
