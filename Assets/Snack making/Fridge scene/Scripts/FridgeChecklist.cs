using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class FridgeChecklist : MonoBehaviour
{
    public GameObject mainText;

    public BreadCheck breadCheck;
    public ButterCheck butterCheck;

    float nextSceneCount = 0f;

    // Start is called before the first frame update
    void Start()
    {
        mainText.SetActive(true);
    }

    void Update()
    {
        if (!breadCheck.isActiveAndEnabled && !butterCheck.isActiveAndEnabled)
        {
            nextSceneCount += Time.deltaTime;
            Debug.Log(nextSceneCount);
            if (nextSceneCount >= 2.0f && nextSceneCount <= 3.0f)
            {
                SceneManager.LoadScene("SnackCOUNTER");
            }
        }
    }
}
