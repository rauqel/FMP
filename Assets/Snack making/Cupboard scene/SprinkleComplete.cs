using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SprinkleComplete : MonoBehaviour
{
    public SprinkleCheck sprinkleCheck;

    float nextScene;

    // Update is called once per frame
    void Update()
    {
        if (!sprinkleCheck.isActiveAndEnabled)
        {
            nextScene += Time.deltaTime;
            if (nextScene >= 1.0f && nextScene <= 1.5f)
            {
                SceneManager.LoadScene("SnackCOUNTER");
            }
        }
    }
}
