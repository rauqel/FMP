using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Barcontroller : MonoBehaviour
{
    Image completionBar;

    public W1 w1;
    public W2 w2;
    public W3 w3;
    public W4 w4;
    public W5 w5;

    float progress = 0f;

    private void Start()
    {
        completionBar = GetComponent<Image>();
    }
}
